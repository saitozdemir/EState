using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entity;

namespace DataAccessLayer.Concrete
{
    public class EfImagesRepository : GenericRepository<Images, DataContext>, IImagesRepository
    {
        private DataContext _context;
        public EfImagesRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
