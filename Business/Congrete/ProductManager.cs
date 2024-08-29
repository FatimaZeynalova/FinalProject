using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Congrete.InMemory;
using Entities.Congrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Congrete
{
    public class ProductManager : IProductService
    {
       IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Is kodlari varsa
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategortId == id);
        }

        public List<Product> GetAllByPrice(decimal min, decimal max)
        {
           return _productDal.GetAll(p=>p.UnitPrice<=min && p.UnitPrice<=max);
        }
    }
}
