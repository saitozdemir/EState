using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class ImagesManager : IGenericService<Images>, IImagesService
    {
        private IImagesRepository _imagesRepository;

        public ImagesManager(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public List<Images> List()
        {
            return _imagesRepository.List();
        }

        public void Add(Images p)
        {
            _imagesRepository.Add(p);
        }

        public void Update(Images p)
        {
            _imagesRepository.Update(p);
        }

        public void Delete(Images p)
        {
            _imagesRepository.Delete(p);
        }

        public Images GetById(int id)
        {
            return _imagesRepository.GetById(id);
        }

        public List<Images> List(Expression<Func<Images, bool>> filter)
        {
            return _imagesRepository.List(filter);
        }
    }
}