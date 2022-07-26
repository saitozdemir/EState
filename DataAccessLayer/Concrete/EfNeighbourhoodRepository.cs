using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using EntityLayer.Entity;

namespace DataAccessLayer.Concrete
{
    public class EfNeighbourhoodRepository : GenericRepository<Neighbourhood, DataContext>, INeighbourhoodRepository
    {
        private DataContext _context;

        public EfNeighbourhoodRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
