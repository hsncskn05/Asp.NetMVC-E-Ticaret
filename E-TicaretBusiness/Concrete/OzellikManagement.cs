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
    public class OzellikManagement:IOzellikDegerService
    {
        EFOzellikDegerData _ozellikdegerManagement = new EFOzellikDegerData();
        public void Add(OzellikDeger entity)
        {
            _ozellikdegerManagement.Add(entity);
        }

        public void Delete(OzellikDeger entity)
        {
            _ozellikdegerManagement.Delete(entity);
        }

        public void Update(OzellikDeger entity)
        {
            _ozellikdegerManagement.Update(entity);
        }

        public OzellikDeger Get(System.Linq.Expressions.Expression<Func<OzellikDeger, bool>> filter = null)
        {
            return _ozellikdegerManagement.Get(filter);
        }

        public ICollection<OzellikDeger> GetAll(System.Linq.Expressions.Expression<Func<OzellikDeger, bool>> filter = null)
        {
            return _ozellikdegerManagement.GetAll(filter);
        }
    }
}
