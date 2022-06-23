using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStoreForJewellery.Models;
using OnlineStoreForJewellery.Repository.IRepository;


namespace OnlineStoreForJewellery.Repository
{
   public  class UnitOfWork : IUnitOfWork
    {
        private AppDBContext _db;

        public UnitOfWork(AppDBContext db)
        {
            _db = db;
            Item = new ItemRepository(_db);
           
            Product = new ProductRepository(_db);
           
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
        }
        public IItemRepository Item { get; private set; }

        public IProductRepository Product { get; private set; }


        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRespository OrderDetail { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }

       
    }
}
