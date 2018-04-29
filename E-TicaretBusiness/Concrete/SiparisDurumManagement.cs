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
    public class SiparisDurumManagement:ISiparisDurumService
    {
        EFSiparisDurumData _siparisdurumManagement = new EFSiparisDurumData();
        public void Add(SiparisDurum entity)
        {
            _siparisdurumManagement.Add(entity);
        }

        public void Delete(SiparisDurum entity)
        {
            _siparisdurumManagement.Delete(entity);
        }

        public void Update(SiparisDurum entity)
        {
            _siparisdurumManagement.Update(entity);
        }

        public SiparisDurum Get(System.Linq.Expressions.Expression<Func<SiparisDurum, bool>> filter = null)
        {
            return _siparisdurumManagement.Get(filter);
        }

        public ICollection<SiparisDurum> GetAll(System.Linq.Expressions.Expression<Func<SiparisDurum, bool>> filter = null)
        {
            return _siparisdurumManagement.GetAll(filter);
        }
    }
}
