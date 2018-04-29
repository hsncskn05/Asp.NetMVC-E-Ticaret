using E_TicaretBusiness.Concrete;
using E_TicaretEntity.EntityFramework;
using E_TicaretUI.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TicaretUI.Controllers
{
    public class UrunController : Controller
    {
        //
        // GET: /Urun/




        UrunManagement _urunManagement = new UrunManagement();
        KategoriManagement _kategoriManagement = new KategoriManagement();
        MarkaManagement _markaManagement = new MarkaManagement();
        UrunOzellikManagement _urunozellikManagement = new UrunOzellikManagement();
        public ActionResult Urunler()
        {
         

         IEnumerable<UrunKategoriMarkaViewModel> urun = _urunManagement.GetAll(x=>x.Sonlandi==false && x.Kategori.Sonlandi==false && x.Marka.Sonlandi==false).Select(x => new UrunKategoriMarkaViewModel()

             {
                  Aciklama=x.Aciklama,
                  Adi=x.Adi,
                 
                  id=x.id,
                  AlisFiyat = x.AlisFiyat,
                  EklenmeTarih=x.EklenmeTarih,
                  KategoriID=x.KategoriID,
                  MarkaID=x.MarkaID,
                   SatisFiyat=x.SatisFiyat,
                  SonKullanmaTarih=x.SonKullanmaTarih,
                  KategoriAdi=_kategoriManagement.Get(y=>y.id==x.KategoriID).Adi,
                  MarkaAdi = _markaManagement.Get(y=>y.id==x.MarkaID).Adi


             }).ToList();


            return View(urun);
    
            
        }
        public ActionResult UrunEkle()
        {
            ViewBag.Kategoriler = _kategoriManagement.GetAll();
            ViewBag.Markalar = _markaManagement.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun urun)
        {
            _urunManagement.Add(urun);

            return RedirectToAction("Urunler");
        }


        public ActionResult UrunSil(int? id)
        {
            Urun urn = _urunManagement.Get(x => x.id == id);


            return View(urn);
        }

         [HttpPost, ActionName("UrunSil")]
        public ActionResult UrunSil1(int? id)
        {
            Urun silinecekUrun = null;
            UrunOzellik silinecekOzellik = null;
             if(id.HasValue)
             {
                 silinecekUrun=_urunManagement.Get(x=>x.id==id);
               //  silinecekOzellik = _urunozellikManagement.Get(x => x.UrunID == id);
                 try
                 {
                 //    _urunozellikManagement.Delete(silinecekOzellik);
                     _urunManagement.Delete(silinecekUrun);
                 }
                 catch (Exception)
                 {

                     return View(silinecekUrun);
                 }
             }
            
            return RedirectToAction("Urunler");
        }

        public ActionResult UrunGuncelle(int? id)
         {
             Urun urun = null;
             if (id.HasValue)
             {
                 urun = _urunManagement.Get(o => o.id == id);
                 
                 //IEnumerable<SelectListItem> categoryList = _kategoriManagement.GetAll().AsEnumerable().Select(c => new SelectListItem
                 //{
                 //    Text = c.Adi,
                 //    Value =c.id.ToString()
                 //});
                 var categoryList = _kategoriManagement.GetAll();

                 ViewBag.Kategoriler = categoryList;
                 IEnumerable<SelectListItem> markaList = _markaManagement.GetAll().AsEnumerable().Select(c => new SelectListItem
                 {
                     Text = c.Adi,
                     Value = c.id.ToString()
                 });

                 ViewBag.Markalar = markaList;
                 return View(urun);
             }
             


             return View();
         }

        [HttpPost]
        public ActionResult UrunGuncelle(Urun urun)
        {

            if(urun.id!=null)
            {
                Urun urunguncelle = _urunManagement.Get(o => o.id == urun.id);
                urunguncelle.Adi = urun.Adi;
                urunguncelle.Aciklama = urun.Aciklama;
                urunguncelle.AlisFiyat = urun.AlisFiyat;
                urunguncelle.SatisFiyat = urun.SatisFiyat;
                urunguncelle.KategoriID = urun.KategoriID;
                urunguncelle.MarkaID = urun.MarkaID;
                try
                {
                    _urunManagement.Update(urunguncelle);
                }
                catch (Exception)
                {

                    return View(urun);
                }
                return RedirectToAction("Urunler");
            }
            
       

            return View();
        }

        public ActionResult UrunAktif()
        {
            var urun = _urunManagement.GetAll(x => x.Sonlandi == true);

            return View(urun);
        }

        public ActionResult UrunAktifGuncelle(int ? id)
        {
            Urun urun = _urunManagement.Get(x => x.id == id);

            return View(urun);
        }

        [HttpPost,ActionName("UrunAktifGuncelle")]
        public ActionResult UrunAktifGuncelle1(Urun urun)
        {
            Urun durumguncelle = null;
            if (urun.id != null)
            {
                durumguncelle = _urunManagement.Get(x => x.id == urun.id);
                durumguncelle.Sonlandi = urun.Sonlandi;
                try
                {
                    _urunManagement.Update(durumguncelle);
                }
                catch (Exception)
                {

                    return View(urun);
                }

                return RedirectToAction("UrunAktif");
            }
            return View();
        }

        public ActionResult UrunResimEkle(int id)
        {
            

            return View(id);
        }

        [HttpPost]
        public ActionResult UrunResimEkle( int uId,HttpPostedFileBase fileupload)
        {
            return View();
        }
 
	}
}