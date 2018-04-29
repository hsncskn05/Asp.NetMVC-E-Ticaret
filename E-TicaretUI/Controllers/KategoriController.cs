using E_TicaretBusiness.Concrete;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TicaretUI.Controllers
{
    public class KategoriController : Controller
    {
        //
        // GET: /Kategori/
        KategoriManagement _kategoriManagement = new KategoriManagement();
        public ActionResult Kategoriler()
        {
            var kategori = _kategoriManagement.GetAll(x=>x.Sonlandi==false);
            return View(kategori);
        }

        public ActionResult KategoriEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori kategori)
        {
            _kategoriManagement.Add(kategori);
            return RedirectToAction("Kategoriler");
        }
        public ActionResult KategoriSil(int ? id)
        {
            Kategori kategori=null;

            if(id.HasValue)
            {
                kategori = _kategoriManagement.Get(x => x.id == id);

                return View(kategori);
            }

            return RedirectToAction("Kategoriler");

            
        }
        [HttpPost, ActionName("KategoriSil")]
        public ActionResult KategoriSil1(int? id)
        {
            Kategori silinecekKategori = null;
            //silinecekKategori = _kategoriManagement.GetAll().Where(x=>x.id==id).FirstOrDefault();
            //_kategoriManagement.Delete(silinecekKategori);
            if (id.HasValue)
            {
                silinecekKategori = _kategoriManagement.GetAll().Where(x => x.id == id).FirstOrDefault();
               
                    _kategoriManagement.Delete(silinecekKategori);
                
             
                
            }

            return RedirectToAction("Kategoriler");
        }

        public ActionResult KategoriGuncelle(int? id)
        {
            Kategori kategori = null;
            if(id.HasValue)
            {
                kategori = _kategoriManagement.Get(x => x.id == id);

                return View(kategori);
            }

            return View();
        }

        [HttpPost,ActionName("KategoriGuncelle")]
        public ActionResult KategoriGuncelle1(Kategori kat)
        {
            Kategori guncelkategori = null;
            if(kat.id!=null)
            {
                guncelkategori = _kategoriManagement.Get(x => x.id == kat.id);
                guncelkategori.Adi = kat.Adi;
                guncelkategori.Aciklama = kat.Aciklama;
                try
                {
                    _kategoriManagement.Update(guncelkategori);
                }
                catch (Exception)
                {

                    return View(kat);
                }
                return RedirectToAction("Kategoriler");
            }
            return View();
        }

        public ActionResult KategoriAktif()
        {
            var kat = _kategoriManagement.GetAll(x=>x.Sonlandi==true);


            return View(kat);
        }
        public ActionResult KategoriAktifGuncelle(int? id)
        {
            Kategori kat = _kategoriManagement.Get(x => x.id == id);

          

            return View(kat);
        }

        [HttpPost, ActionName("KategoriAktifGuncelle")]
        public ActionResult KategoriAktifGuncelle1(Kategori kat)
        {
            Kategori durumguncelle = null;
            if(kat.id!=null)
            {
                durumguncelle = _kategoriManagement.Get(x => x.id == kat.id);
                durumguncelle.Sonlandi = kat.Sonlandi;
                try
                {
                    _kategoriManagement.Update(durumguncelle);
                }
                catch (Exception)
                {

                    return View(kat);
                }

                return RedirectToAction("KategoriAktif");
            }

            return View();
        }
	}
}