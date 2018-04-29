using E_TicaretBusiness.Concrete;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TicaretUI.Controllers
{
    public class OzellikDegerController : Controller
    {
        //
        // GET: /OzellikDeger/

        OzellikManagement _ozellikdegerManagement = new OzellikManagement();
        OzellikTipManagement _ozelliktipManagement = new OzellikTipManagement();
        public ActionResult OzellikDegerleri()
        {

            IEnumerable<OzellikDeger> ozellikdeger = _ozellikdegerManagement.GetAll(x=>x.OzellikTip.Sonlandi==false).Select(x => new OzellikDeger
            {
                Aciklama=x.Aciklama,
                Adi=x.Adi,
                id=x.id,
                OzellikTip=_ozelliktipManagement.Get(y=>y.id==x.OzellikTipID)


            }).ToList();


            return View(ozellikdeger);
        }

        public ActionResult OzellikDegerEkle()
        {

            return View(_ozelliktipManagement.GetAll());
        }
        [HttpPost]
        public ActionResult OzellikDegerEkle(OzellikDeger oz)
        {
            _ozellikdegerManagement.Add(oz);
            return RedirectToAction("OzellikDegerleri");
        }
	}
}