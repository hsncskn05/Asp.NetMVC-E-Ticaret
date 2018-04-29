using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class Musteri : IEntity
    {
        public Musteri()
        {
            this.MusteriAdres = new List<MusteriAdre>();
            this.Satis = new List<Sati>();
        }

        public System.Guid id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string EMail { get; set; }
        public string Telefon { get; set; }
       
        public virtual ICollection<MusteriAdre> MusteriAdres { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
