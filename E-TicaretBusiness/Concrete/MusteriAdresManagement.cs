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
    public class MusteriAdresManagement:IMusteriAdresService
    {
        EFMusteriAdresData _musteriadresManagement = new EFMusteriAdresData();
        public void Add(MusteriAdre entity)
        {
            _musteriadresManagement.Add(entity);
        }

        public void Delete(MusteriAdre entity)
        {
            _musteriadresManagement.Delete(entity);
        }

        public void Update(MusteriAdre entity)
        {
            _musteriadresManagement.Update(entity);
        }

        public MusteriAdre Get(System.Linq.Expressions.Expression<Func<MusteriAdre, bool>> filter = null)
        {
            return _musteriadresManagement.Get(filter);
        }

        public ICollection<MusteriAdre> GetAll(System.Linq.Expressions.Expression<Func<MusteriAdre, bool>> filter = null)
        {
            return _musteriadresManagement.GetAll(filter);
        }
    }
}
