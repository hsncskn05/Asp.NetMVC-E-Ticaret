using E_TicaretCore.DataAccess;
using E_TicaretData.Abstract;
using E_TicaretData.Context;
using E_TicaretEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TicaretData.Concrete.Entities
{
    public class EFMusteriData : EFRepositoryBase<TicaretContext1, Musteri>, IMusteriData
    {
    }
}
