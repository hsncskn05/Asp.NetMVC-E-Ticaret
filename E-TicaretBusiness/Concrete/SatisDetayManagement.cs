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
    public class SatisDetayManagement:ISatisDetayService
    {
        EFSatisDetayData _satisdetayManagement = new EFSatisDetayData();
        public void Add(SatisDetay entity)
        {
            _satisdetayManagement.Add(entity);
        }

        public void Delete(SatisDetay entity)
        {
            _satisdetayManagement.Delete(entity);
        }

        public void Update(SatisDetay entity)
        {
            _satisdetayManagement.Update(entity);
        }

        public SatisDetay Get(System.Linq.Expressions.Expression<Func<SatisDetay, bool>> filter = null)
        {
            return _satisdetayManagement.Get(filter);
        }

        public ICollection<SatisDetay> GetAll(System.Linq.Expressions.Expression<Func<SatisDetay, bool>> filter = null)
        {
            return _satisdetayManagement.GetAll(filter);
        }
    }
}
