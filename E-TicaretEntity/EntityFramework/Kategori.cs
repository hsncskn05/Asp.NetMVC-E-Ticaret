using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class Kategori : IEntity
    {
        public Kategori()
        {
            this.OzellikTips = new List<OzellikTip>();
            this.Uruns = new List<Urun>();
        }

        public int id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> ResimID { get; set; }
        public virtual Resim Resim { get; set; }
        public bool Sonlandi { get; set; }
        public virtual ICollection<OzellikTip> OzellikTips { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
