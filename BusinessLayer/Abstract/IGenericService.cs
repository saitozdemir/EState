using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> List();

        void Add(T p);
        void Update(T p);
        void Delete(T p);

        T GetById(int id);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
