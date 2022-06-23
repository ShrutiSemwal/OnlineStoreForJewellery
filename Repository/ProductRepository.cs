using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStoreForJewellery.Repository.IRepository;
using OnlineStoreForJewellery.Models;

namespace OnlineStoreForJewellery.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDBContext _db;

        public ProductRepository(AppDBContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                
                objFromDb.Price = obj.Price;
               
                
                objFromDb.ItemId = obj.ItemId;
                
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
