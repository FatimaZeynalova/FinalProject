using Entities.Congrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
