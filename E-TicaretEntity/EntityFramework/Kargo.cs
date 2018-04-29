using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class Kargo : IEntity
    {
        public Kargo()
        {
            this.Satis = new List<Sati>();
        }

        public int id { get; set; }
        public string SirketAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
