using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CityValidation : AbstractValidator<City>
    {
        public CityValidation()
        {
            RuleFor(x => x.CityName).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.CityName).Length(3, 50).WithMessage("Name must be between 3 and 50 characters");
        }
    }
}
