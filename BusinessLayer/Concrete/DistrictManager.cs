using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class DistrictManager : IGenericService<District>, IDistrictService
    {
        private IDistrictRepository _districtRepository;

        public DistrictManager(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        public List<District> List()
        {
            return _districtRepository.List();
        }

        public void Add(District p)
        {
            _districtRepository.Add(p);
        }

        public void Update(District p)
        {
            _districtRepository.Update(p);
        }

        public void Delete(District p)
        {
            _districtRepository.Delete(p);
        }

        public District GetById(int id)
        {
            return _districtRepository.GetById(id);
        }

        public List<District> List(Expression<Func<District, bool>> filter)
        {
            return _districtRepository.List(filter);
        }
    }
}