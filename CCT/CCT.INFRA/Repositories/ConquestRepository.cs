using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.Domain.Store.Entities;
using CCT.Domain.Store.Repositories;
using CCT.Infra.Contexts;

namespace CCT.CCT.INFRA.Repositories
{
    public class ConquestRepository : IConquestRepository
    {
        private readonly CCT_StoreDataContext _context;

        public ConquestRepository(CCT_StoreDataContext context)
        {
            _context = context;
        }

        public User Get(Guid id)
        {
            return _context.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<User> GetConquests(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
