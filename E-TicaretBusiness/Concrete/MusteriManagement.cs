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
    public class MusteriManagement:IMusteriService
    {
        EFMusteriData _musteriManagement = new EFMusteriData();
        public void Add(Musteri entity)
        {
            _musteriManagement.Add(entity);
        }

        public void Delete(Musteri entity)
        {
            _musteriManagement.Delete(entity);
        }

        public void Update(Musteri entity)
        {
            _musteriManagement.Update(entity);
        }

        public Musteri Get(System.Linq.Expressions.Expression<Func<Musteri, bool>> filter = null)
        {
            return _musteriManagement.Get(filter);
        }

        public ICollection<Musteri> GetAll(System.Linq.Expressions.Expression<Func<Musteri, bool>> filter = null)
        {
            return _musteriManagement.GetAll(filter);
        }
    }
}
