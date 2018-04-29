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
    public class KategoriManagement:IKategoriService
    {
        EFKategoriData _kategoriManagement = new EFKategoriData();
        public void Add(Kategori entity)
        {
            _kategoriManagement.Add(entity);
        }

        public void Delete(Kategori entity)
        {
            _kategoriManagement.Delete(entity);
        }

        public void Update(Kategori entity)
        {
           _kategoriManagement.Update(entity);
        }

        public Kategori Get(System.Linq.Expressions.Expression<Func<Kategori, bool>> filter = null)
        {
            return _kategoriManagement.Get(filter);
        }

        public ICollection<Kategori> GetAll(System.Linq.Expressions.Expression<Func<Kategori, bool>> filter = null)
        {
            return _kategoriManagement.GetAll(filter);
        }
    }
}
