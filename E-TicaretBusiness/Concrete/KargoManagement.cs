using E_TicaretBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using E_TicaretData.Concrete.Entities;
using E_TicaretEntity.EntityFramework;
namespace E_TicaretBusiness.Concrete
{
    public class KargoManagement:IKargoService
    {
        EFKargoData _kargoManagement = new EFKargoData();
        public void Add(Kargo entity)
        {
            _kargoManagement.Add(entity);
        }

        public void Delete(Kargo entity)
        {
            _kargoManagement.Delete(entity);
        }

        public void Update(Kargo entity)
        {
            _kargoManagement.Update(entity);
        }

        public Kargo Get(System.Linq.Expressions.Expression<Func<Kargo, bool>> filter = null)
        {
            return _kargoManagement.Get(filter);
        }

        public ICollection<Kargo> GetAll(System.Linq.Expressions.Expression<Func<Kargo, bool>> filter = null)
        {
            return _kargoManagement.GetAll(filter);
        }
    }
}
