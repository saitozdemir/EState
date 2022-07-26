using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System.Linq.Expressions;
using Type = EntityLayer.Entity.Type;

namespace BusinessLayer.Concrete
{
    public class TypeManager : IGenericService<Type>, ITypeService
    {
        private ITypeRepository _typeRepository;

        public TypeManager(ITypeRepository TypeRepository)
        {
            _typeRepository = TypeRepository;
        }

        public List<Type> List()
        {
            return _typeRepository.List();
        }

        public void Add(Type p)
        {
            _typeRepository.Add(p);
        }

        public void Update(Type p)
        {
            _typeRepository.Update(p);
        }

        public void Delete(Type p)
        {
            _typeRepository.Delete(p);
        }

        public Type GetById(int id)
        {
            return _typeRepository.GetById(id);
        }

        public List<Type> List(Expression<Func<Type, bool>> filter)
        {
            return _typeRepository.List(filter);
        }
    }
}