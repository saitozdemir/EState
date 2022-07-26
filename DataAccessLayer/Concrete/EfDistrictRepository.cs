using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entity;

namespace DataAccessLayer.Concrete
{
    public class EfDistrictRepository : GenericRepository<District, DataContext>, IDistrictRepository
    {
        private DataContext _context;

        public EfDistrictRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
