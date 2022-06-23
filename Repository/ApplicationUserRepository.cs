using OnlineStoreForJewellery.Repository.IRepository;
using OnlineStoreForJewellery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private AppDBContext _db;

        public ApplicationUserRepository(AppDBContext db) : base(db)
        {
            _db = db;
        }

    }
}
