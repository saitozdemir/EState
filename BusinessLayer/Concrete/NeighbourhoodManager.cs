using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class NeighbourhoodManager : IGenericService<Neighbourhood>, INeighbourhoodService
    {
        private INeighbourhoodRepository _neighbourhood;

        public NeighbourhoodManager(INeighbourhoodRepository neighbourhood)
        {
            _neighbourhood = neighbourhood;
        }

        public List<Neighbourhood> List()
        {
            return _neighbourhood.List();
        }

        public void Add(Neighbourhood p)
        {
            _neighbourhood.Add(p);
        }

        public void Update(Neighbourhood p)
        {
            _neighbourhood.Update(p);
        }

        public void Delete(Neighbourhood p)
        {
            _neighbourhood.Delete(p);
        }

        public Neighbourhood GetById(int id)
        {
            return _neighbourhood.GetById(id);
        }

        public List<Neighbourhood> List(Expression<Func<Neighbourhood, bool>> filter)
        {
            return _neighbourhood.List(filter);
        }
    }
}