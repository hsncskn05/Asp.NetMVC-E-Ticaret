using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class OzellikTip : IEntity
    {
        public OzellikTip()
        {
            this.OzellikDegers = new List<OzellikDeger>();
            this.UrunOzelliks = new List<UrunOzellik>();
        }

        public int id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public bool Sonlandi { get; set; }
        public virtual ICollection<OzellikDeger> OzellikDegers { get; set; }
        public virtual ICollection<UrunOzellik> UrunOzelliks { get; set; }
    }
}
