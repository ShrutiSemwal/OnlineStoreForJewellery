using OnlineStoreForJewellery.Models;
using OnlineStoreForJewellery.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRespository
    {
        private AppDBContext _db;

        public OrderDetailRepository(AppDBContext db) : base(db)
        {
            _db = db;
        }


        public void Update(OrderDetail obj)
        {
            _db.OrderDetail.Update(obj);
        }
    }
}
