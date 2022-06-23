using OnlineStoreForJewellery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.Repository.IRepository
{
   public  interface IOrderDetailRespository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
    }
}
