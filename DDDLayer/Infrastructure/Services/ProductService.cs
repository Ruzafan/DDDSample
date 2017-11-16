using DDDLayer.Domain;
using DDDLayer.Domain.Entities;
using DDDLayer.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Infrastructure.Services
{
    public class ProductService
    {
        public Product Get(int id)
        {
            Product product = (Product)CacheManager.GetFromCache(string.Format("Product-{0}", id));
            if (product.IsDefined())
            {
                return product;
            }

            IDatabase db = Resolver.GetDatabaseObject(Constants.PRODUCT_COLLECTION);
            product = db.Get<Product>(id);
            if (product.IsDefined())
            {
                if (product.Status == Constants.STATUS_ACTIVE)
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> Get(List<int> ids)
        {
            IDatabase db = Resolver.GetDatabaseObject(Constants.PRODUCT_COLLECTION);

            List<Product> products = db.GetList<Product>(ids);
            if (products.IsDefined() && products.Any())
            {
                return products;
            }
            
            return new List<Product>();

        }
    }
}
