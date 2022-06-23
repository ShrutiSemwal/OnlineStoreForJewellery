using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStoreForJewellery.Models;
using OnlineStoreForJewellery.Repository.IRepository;

namespace OnlineStoreForJewellery.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        private AppDBContext _db;

        public ItemRepository(AppDBContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Item obj)
        {
            _db.Items.Update(obj);
        }
    }
}
