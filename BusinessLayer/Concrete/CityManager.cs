using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class CityManager:IGenericService<City>, ICityService
    {
        private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public List<City> List()
        {
            return _cityRepository.List();
        }

        public void Add(City p)
        {
            _cityRepository.Add(p);
        }

        public void Update(City p)
        {
            _cityRepository.Update(p);
        }

        public void Delete(City p)
        {
            _cityRepository.Delete(p);
        }

        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        public List<City> List(Expression<Func<City, bool>> filter)
        {
            return _cityRepository.List(filter);
        }
    }
}
