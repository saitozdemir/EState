using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entity;

namespace DataAccessLayer.Concrete
{
    public class EfCityRepository:GenericRepository<City, DataContext>, ICityRepository
    {
        private DataContext _context;

        public EfCityRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
