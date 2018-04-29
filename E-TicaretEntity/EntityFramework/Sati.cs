using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class Sati : IEntity
    {
        public Sati()
        {
            this.SatisDetays = new List<SatisDetay>();
        }

        public int id { get; set; }
        public Nullable<System.Guid> MusteriID { get; set; }
        public System.DateTime SatisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public bool Sepettemi { get; set; }
        public int KargoID { get; set; }
        public int SiparisDurumID { get; set; }
        public string KargoTakipNo { get; set; }
        public virtual Kargo Kargo { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual SiparisDurum SiparisDurum { get; set; }
        public virtual ICollection<SatisDetay> SatisDetays { get; set; }
    }
}
