using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entity;

namespace DataAccessLayer.Concrete
{

    public class EfGeneralSettingsRepository : GenericRepository<GeneralSettings, DataContext>, IGeneralSettingsRepository
    {
        private DataContext _context;
        public EfGeneralSettingsRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
