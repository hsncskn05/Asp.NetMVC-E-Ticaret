using E_TicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretEntity.EntityFramework
{
    public partial class UrunOzellik : IEntity
    {
        public int UrunID { get; set; }
        public int OzellikTipID { get; set; }
        public int OzellikDegerID { get; set; }
        public virtual OzellikDeger OzellikDeger { get; set; }
        public virtual OzellikTip OzellikTip { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
