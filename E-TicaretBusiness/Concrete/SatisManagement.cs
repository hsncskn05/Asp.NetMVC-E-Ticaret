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
    public class SatisManagement:ISatisService
    {
        EFSatisData _satisManagement = new EFSatisData();
        public void Add(Sati entity)
        {
            _satisManagement.Add(entity);

        }

        public void Delete(Sati entity)
        {
            _satisManagement.Delete(entity);
        }

        public void Update(Sati entity)
        {
            _satisManagement.Update(entity);
        }

        public Sati Get(System.Linq.Expressions.Expression<Func<Sati, bool>> filter = null)
        {
            return _satisManagement.Get(filter);
        }

        public ICollection<Sati> GetAll(System.Linq.Expressions.Expression<Func<Sati, bool>> filter = null)
        {
            return _satisManagement.GetAll(filter);
        }
    }
}
