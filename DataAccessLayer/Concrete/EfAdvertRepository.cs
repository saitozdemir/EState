using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entity;

namespace DataAccessLayer.Concrete
{
    public class EfAdvertRepository:GenericRepository<Advert, DataContext>, IAdvertRepository
    {
        private DataContext _context;
        public EfAdvertRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
