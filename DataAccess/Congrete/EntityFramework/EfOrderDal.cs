using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Congrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Congrete.EntityFramework
{
    public class EfOrderDal: EfEntityRepositoryBase<Order,NorthwindContext>, IOrderDal
    {

    }
}
