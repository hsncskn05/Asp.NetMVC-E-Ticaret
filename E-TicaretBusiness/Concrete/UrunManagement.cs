using E_TicaretBusiness.Abstract;
using E_TicaretData.Concrete.Entities;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretBusiness.Concrete
{
    public class UrunManagement:IUrunService
    {
        EFUrunData _urunManagement = new EFUrunData();
        public void Add(Urun entity)
        {
            _urunManagement.Add(entity);
        }

        public void Delete(Urun entity)
        {
            _urunManagement.Delete(entity);
        }

        public void Update(Urun entity)
        {
            _urunManagement.Update(entity);
        }

        public Urun Get(System.Linq.Expressions.Expression<Func<Urun, bool>> filter = null)
        {
            return _urunManagement.Get(filter);
        }

        public ICollection<Urun> GetAll(System.Linq.Expressions.Expression<Func<Urun, bool>> filter = null)
        {
            return _urunManagement.GetAll(filter);
        }
    }
}
