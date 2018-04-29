using E_TicaretBusiness.Concrete;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TicaretUI.Controllers
{
    public class OzellikTipController : Controller
    {
        //
        // GET: /OzellikTip/

        OzellikTipManagement _ozelliktipManagement = new OzellikTipManagement();
        KategoriManagement _kategoriManagement = new KategoriManagement();
        public ActionResult OzellikTipleri()
        {

          


            IEnumerable<OzellikTip> ozelliktip = _ozelliktipManagement.GetAll(x=>x.Kategori.Sonlandi==false).Select(x => new OzellikTip()

            {
                Aciklama = x.Aciklama,
                Adi = x.Adi,

                id = x.id,
                Kategori = _kategoriManagement.Get(y => y.id == x.KategoriID)



            }).ToList();
            return View(ozelliktip);
        }

        public ActionResult OzellikTipEkle()
        {
            
            return View(_kategoriManagement.GetAll());
        }
        [HttpPost]
        public ActionResult OzellikTipEkle(OzellikTip tip)
        {
            _ozelliktipManagement.Add(tip);
            return RedirectToAction("OzellikTipleri");
        }
	}
}