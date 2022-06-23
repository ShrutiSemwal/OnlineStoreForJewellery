using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStoreForJewellery.Models;

namespace OnlineStoreForJewellery.Repository.IRepository
{
   public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
