using System.Data;
using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class DistricValidation:AbstractValidator<District>
    {
        public DistricValidation()
        {
            RuleFor(x => x.DistrictName).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Name is required");

        }
    }
}
