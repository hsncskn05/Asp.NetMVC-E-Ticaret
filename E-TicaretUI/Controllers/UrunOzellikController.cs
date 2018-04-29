using E_TicaretBusiness.Concrete;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TicaretUI.Controllers
{
    public class UrunOzellikController : Controller
    {
        //
        // GET: /UrunOzellik/
        UrunOzellikManagement _urunozellikManagement = new UrunOzellikManagement();
        OzellikManagement _ozellikdegerManagement = new OzellikManagement();
        OzellikTipManagement _ozelliktipManagement = new OzellikTipManagement();
        UrunManagement _urunManagement = new UrunManagement();
        public ActionResult UrunOzellikleri()
        {
            IEnumerable<UrunOzellik> urunozellik = _urunozellikManagement.GetAll(x=>x.OzellikDeger.Sonlandi==false && x.OzellikTip.Sonlandi==false && x.Urun.Sonlandi==false).Select(x => new UrunOzellik()

            {
                Urun=_urunManagement.Get(y=>y.id==x.UrunID),
                OzellikTip=_ozelliktipManagement.Get(y=>y.id==x.OzellikTipID),
                OzellikDeger=_ozellikdegerManagement.Get(y=>y.id==x.OzellikDegerID)


            }).ToList();
            return View(urunozellik);
        }
        public ActionResult UrunOzellikEkle()
        {

            return View(_urunManagement.GetAll());
        }
        [HttpPost]
        public ActionResult UrunOzellikEkle(UrunOzellik uo)
        {
            _urunozellikManagement.Add(uo);

            return RedirectToAction("UrunOzellikleri");
        }
        public PartialViewResult UrunOzellikTipWidget(int? katId)
        {
            if (katId != null)
            {

                return PartialView(_ozelliktipManagement.GetAll().Where(x => x.KategoriID == katId).ToList());
            }
            else
            {
                return PartialView(_ozelliktipManagement.GetAll());
            }

        }

        public PartialViewResult UrunOzellikDegerWidget(int? tipID)
        {
            if (tipID != null)
            {
                var data = _ozellikdegerManagement.GetAll().Where(x => x.OzellikTipID == tipID).ToList();

                return PartialView(data);
            }
            else
            {
                var data = _ozellikdegerManagement.GetAll();
                return PartialView(data);
            }
        }
	}
}