using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Data;

namespace DataAccessLayer.Concrete
{
    public class EfTypeRpository : GenericRepository<EntityLayer.Entity.Type, DataContext>, ITypeRepository
    {
        private DataContext _context;

        public EfTypeRpository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
