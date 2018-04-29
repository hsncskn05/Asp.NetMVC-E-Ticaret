using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_TicaretUI.Models.Classes
{
    public class UrunKategoriMarkaViewModel
    {
        public int id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public Nullable<System.DateTime> EklenmeTarih { get; set; }
        public Nullable<System.DateTime> SonKullanmaTarih { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> MarkaID { get; set; }
        public  string KategoriAdi { get; set; }
        public  string MarkaAdi { get; set; }
    }
}