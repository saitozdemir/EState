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
    public class EfSituationRepository : GenericRepository<Situation, DataContext>, ISituationRepository
    {
        private DataContext _context;

        public EfSituationRepository(DataContext context) : base(context)
        {
        }
    }
}
