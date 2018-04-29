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
    public class ResimManagement:IResimService
    {
        EFResimData _resimManagement = new EFResimData();
        public void Add(Resim entity)
        {
            _resimManagement.Add(entity);
        }

        public void Delete(Resim entity)
        {
            _resimManagement.Delete(entity);
        }

        public void Update(Resim entity)
        {
            _resimManagement.Update(entity);
        }

        public Resim Get(System.Linq.Expressions.Expression<Func<Resim, bool>> filter = null)
        {
            return _resimManagement.Get(filter);
        }

        public ICollection<Resim> GetAll(System.Linq.Expressions.Expression<Func<Resim, bool>> filter = null)
        {
            return _resimManagement.GetAll(filter);
        }
    }
}
