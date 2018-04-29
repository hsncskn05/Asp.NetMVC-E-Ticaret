using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class MusteriAdre : IEntity
    {
        public int id { get; set; }
        public System.Guid MusteriID { get; set; }
        public string Adres { get; set; }
        public string Adi { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
