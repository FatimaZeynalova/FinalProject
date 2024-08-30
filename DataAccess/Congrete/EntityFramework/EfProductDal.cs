﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Congrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Congrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategortId equals c.CategoryId
                             select new ProductDetailDto 
                             {
                                 ProductId=p.ProductId, ProductName=p.ProductName,
                                 CatgoryName=p.CategoryName, UnitInStock=p.UnitsInStock
                             };
                return result.ToList(); 
            }
        }
    }
}
