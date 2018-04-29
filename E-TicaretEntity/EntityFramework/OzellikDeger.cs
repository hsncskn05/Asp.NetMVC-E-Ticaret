using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class OzellikDeger : IEntity
    {
        public OzellikDeger()
        {
            this.UrunOzelliks = new List<UrunOzellik>();
        }

        public int id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> OzellikTipID { get; set; }
        public bool Sonlandi { get; set; }
        public virtual OzellikTip OzellikTip { get; set; }
        public virtual ICollection<UrunOzellik> UrunOzelliks { get; set; }
    }
}
