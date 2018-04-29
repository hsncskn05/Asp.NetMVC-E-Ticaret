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
    public class OzellikTipManagement:IOzellikTipService
    {
        EFOzellikTipData _ozelliktipManagement = new EFOzellikTipData();
        public void Add(OzellikTip entity)
        {
            _ozelliktipManagement.Add(entity);
        }

        public void Delete(OzellikTip entity)
        {
            _ozelliktipManagement.Delete(entity);
        }

        public void Update(OzellikTip entity)
        {
            _ozelliktipManagement.Update(entity);
        }

        public OzellikTip Get(System.Linq.Expressions.Expression<Func<OzellikTip, bool>> filter = null)
        {
            return _ozelliktipManagement.Get(filter);
        }

        public ICollection<OzellikTip> GetAll(System.Linq.Expressions.Expression<Func<OzellikTip, bool>> filter = null)
        {
            return _ozelliktipManagement.GetAll(filter);
        }
    }
}
