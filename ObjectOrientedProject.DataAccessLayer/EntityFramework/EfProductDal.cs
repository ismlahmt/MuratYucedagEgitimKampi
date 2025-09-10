using ObjectOrientedProject.DataAccessLayer.Abstract;
using ObjectOrientedProject.DataAccessLayer.Context;
using ObjectOrientedProject.DataAccessLayer.Repositories;
using ObjectOrientedProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext ();
            var values = context.Products.Select(x => new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductDescription = x.ProductDescription,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                CategoryName = x.Category.CategoryName
            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
