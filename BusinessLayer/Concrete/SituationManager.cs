using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class SituationManager : IGenericService<Situation>, ISituationService
    {
        private ISituationRepository _situationManager;

        public SituationManager(ISituationRepository situationRepository)
        {
            _situationManager = situationRepository;
        }

        public List<Situation> List()
        {
            return _situationManager.List();
        }

        public void Add(Situation p)
        {
            _situationManager.Add(p);
        }

        public void Update(Situation p)
        {
            _situationManager.Update(p);
        }

        public void Delete(Situation p)
        {
            _situationManager.Delete(p);
        }

        public Situation GetById(int id)
        {
            return _situationManager.GetById(id);
        }

        public List<Situation> List(Expression<Func<Situation, bool>> filter)
        {
            return _situationManager.List(filter);
        }
    }
}