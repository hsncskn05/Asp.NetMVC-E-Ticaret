using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class SatisDetay : IEntity
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<double> Indirim { get; set; }
        public virtual Sati Sati { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
