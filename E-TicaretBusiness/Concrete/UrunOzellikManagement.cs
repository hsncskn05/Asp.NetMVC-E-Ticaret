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
    public class UrunOzellikManagement:IUrunOzellikService
    {
        EFUrunOzellikData _urunozellikManagement = new EFUrunOzellikData();
        public void Add(UrunOzellik entity)
        {
            _urunozellikManagement.Add(entity);
        }

        public void Delete(UrunOzellik entity)
        {
            _urunozellikManagement.Delete(entity);
        }

        public void Update(UrunOzellik entity)
        {
            _urunozellikManagement.Update(entity);
        }

        public UrunOzellik Get(System.Linq.Expressions.Expression<Func<UrunOzellik, bool>> filter = null)
        {
            return _urunozellikManagement.Get(filter);
        }

        public ICollection<UrunOzellik> GetAll(System.Linq.Expressions.Expression<Func<UrunOzellik, bool>> filter = null)
        {
            return _urunozellikManagement.GetAll(filter);
        }
    }
}
