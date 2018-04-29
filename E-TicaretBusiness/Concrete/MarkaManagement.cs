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
    public class MarkaManagement:IMarkaService
    {
        EFMarkaData _markaManagement = new EFMarkaData();
        public void Add(Marka entity)
        {
            _markaManagement.Add(entity);
        }

        public void Delete(Marka entity)
        {
            _markaManagement.Delete(entity);
        }

        public void Update(Marka entity)
        {
            _markaManagement.Update(entity);
        }

        public Marka Get(System.Linq.Expressions.Expression<Func<Marka, bool>> filter = null)
        {
            return _markaManagement.Get(filter);
        }

        public ICollection<Marka> GetAll(System.Linq.Expressions.Expression<Func<Marka, bool>> filter = null)
        {
            return _markaManagement.GetAll(filter);
        }
    }
}
