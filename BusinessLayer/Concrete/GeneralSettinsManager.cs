using System.Linq.Expressions;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entity;

namespace BusinessLayer.Concrete
{
    public class GeneralSettingsManager : IGenericService<GeneralSettings>, IGeneralSettingsService
    {
        private IGeneralSettingsRepository _generalSettings;

        public GeneralSettingsManager(IGeneralSettingsRepository generalSettings)
        {
            _generalSettings = generalSettings;
        }

        public List<GeneralSettings> List()
        {
            return _generalSettings.List();
        }

        public void Add(GeneralSettings p)
        {
            _generalSettings.Add(p);
        }

        public void Update(GeneralSettings p)
        {
            _generalSettings.Update(p);
        }

        public void Delete(GeneralSettings p)
        {
            _generalSettings.Delete(p);
        }

        public GeneralSettings GetById(int id)
        {
            return _generalSettings.GetById(id);
        }

        public List<GeneralSettings> List(Expression<Func<GeneralSettings, bool>> filter)
        {
            return _generalSettings.List(filter);
        }
    }
}