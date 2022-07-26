using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class AdvertManager:IGenericService<Advert>, IAdvertService
    {
        private IAdvertRepository _advertRepository;

        public AdvertManager(IAdvertRepository advertRepository)
        {
            _advertRepository = advertRepository;
        }

        public List<Advert> List()
        {
            return _advertRepository.List();
        }

        public void Add(Advert p)
        {
            _advertRepository.Add(p);
        }

        public void Update(Advert p)
        {
            _advertRepository.Update(p);
        }

        public void Delete(Advert p)
        {
            _advertRepository.Delete(p);
        }

        public Advert GetById(int id)
        {
            return _advertRepository.GetById(id);
        }

        public List<Advert> List(Expression<Func<Advert, bool>> filter)
        {
            return _advertRepository.List(filter);
        }
    }
}
