using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCommerce.Domain.Store.Entities;
using DDDCommerce.Domain.Store.Repositories;
using DDDCommerce.Infra.Contexts;

namespace CCT.CCT.INFRA.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CCT_StoreDataContext _context;

        public ProductRepository(CCT_StoreDataContext context)
        {
            _context = context;
        }

        public User Get(Guid id)
        {
            return _context.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<User> GetUsers(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
