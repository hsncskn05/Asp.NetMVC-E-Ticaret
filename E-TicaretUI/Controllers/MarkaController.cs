using E_TicaretBusiness.Concrete;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TicaretUI.Controllers
{
    public class MarkaController : Controller
    {
        //
        // GET: /Marka/
        MarkaManagement _markaManagement = new MarkaManagement();
        ResimManagement _resimManagement = new ResimManagement();
        public ActionResult Markalar()
        {

            IEnumerable<Marka> marka = _markaManagement.GetAll(x=>x.Sonlandi==false).Select(x => new Marka()

            {
                Aciklama = x.Aciklama,
                Adi = x.Adi,

                id = x.id,
                Resim=_resimManagement.Get(y=>y.id==x.ResimID)
              


            }).ToList();

            return View(marka);
        }
        public ActionResult MarkaEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult MarkaEkle(Marka mrk, HttpPostedFileBase filee)
        {
            int resimID = -1;
            if (filee != null)
            {
                Image img = Image.FromStream(filee.InputStream);
                int width = Convert.ToInt32(ConfigurationManager.AppSettings["MarkaWidth"].ToString());
                int height = Convert.ToInt32(ConfigurationManager.AppSettings["MarkaHeight"].ToString());

                string name = "/Content/MarkaResim/" + Guid.NewGuid() + Path.GetExtension(filee.FileName);

                Bitmap bm = new Bitmap(img, width, height);
                bm.Save(Server.MapPath(name));

                Resim rsm = new Resim();
                rsm.OrtaYol = name;

                _resimManagement.Add(rsm);
               
                if (rsm.id != null)
                    resimID = rsm.id;
            }
            if (resimID != -1)
                mrk.ResimID = resimID;

            _markaManagement.Add(mrk);
            return RedirectToAction("Markalar");
        }

        public ActionResult MarkaGuncelle(int? id)
        {
            Marka marka = null;
            if(id.HasValue)
            {
                marka = _markaManagement.GetAll(x=>x.id==id).Select(x => new Marka()

                {
                    Aciklama = x.Aciklama,
                    Adi = x.Adi,
                    ResimID=x.ResimID,
                    id = x.id,
                    Resim = _resimManagement.Get(y => y.id == x.ResimID)



                }).FirstOrDefault();

                return View(marka);
            }

            return View();
        }

        [HttpPost,ActionName("MarkaGuncelle")]
        public ActionResult MarkaGuncelle1(Marka marka, HttpPostedFileBase filee)
        {
            Marka guncelle = null;
            if(marka.id!=null)
            {
                guncelle = _markaManagement.Get(x => x.id == marka.id);

                guncelle.Adi = marka.Adi;
                guncelle.Aciklama = marka.Aciklama;
               
                if (filee != null)
                {
                    Image img = Image.FromStream(filee.InputStream);
                    int width = Convert.ToInt32(ConfigurationManager.AppSettings["MarkaWidth"].ToString());
                    int height = Convert.ToInt32(ConfigurationManager.AppSettings["MarkaHeight"].ToString());

                    string name = "/Content/MarkaResim/" + Guid.NewGuid() + Path.GetExtension(filee.FileName);

                    Bitmap bm = new Bitmap(img, width, height);
                    bm.Save(Server.MapPath(name));

                    Resim rsm = _resimManagement.Get(x => x.id == marka.ResimID);
                    rsm.OrtaYol = name;

                    _resimManagement.Update(rsm);

                    

                  
                }
           

                try
                {
                    _markaManagement.Update(guncelle);

                }
                catch (Exception)
                {

                    return View(marka);
                }
                return RedirectToAction("Markalar");
            }



            return View();
        }

        public ActionResult MarkaSil(int? id)
        {
            Marka marka = _markaManagement.Get(x => x.id == id);

            return View(marka);
        }
        [HttpPost,ActionName("MarkaSil")]
        public ActionResult MarkaSil1(int ? id)
        {
            Marka marka = null;
            if(id.HasValue)
            {
                marka = _markaManagement.Get(x => x.id == id);

                try
                {
                    _markaManagement.Delete(marka);

                }
                catch (Exception)
                {

                    return View(marka);
                }
            }

            return RedirectToAction("Markalar");
        }

        public ActionResult MarkaAktif()
        {
            var marka = _markaManagement.GetAll(x => x.Sonlandi == true);

            return View(marka);
        }

        public ActionResult MarkaAktifguncelle(int ? id)
        {
            Marka marka = _markaManagement.Get(x => x.id == id);


            return View(marka);
        }

        [HttpPost,ActionName("MarkaAktifguncelle")]
        public ActionResult MarkaAktifguncelle1(Marka marka)
        {
            Marka durumguncelle = null;
            if(marka.id!=null)
            {
                durumguncelle = _markaManagement.Get(x => x.id == marka.id);
                durumguncelle.Sonlandi = marka.Sonlandi;
                try
                {
                    _markaManagement.Update(durumguncelle);
                }
                catch (Exception)
                {

                    return View(marka);
                }

                return RedirectToAction("MarkaAktif");


            }

            return View();
        }
	}
}