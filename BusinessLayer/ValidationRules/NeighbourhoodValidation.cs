using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class NeighbourhoodValidation:AbstractValidator<Neighbourhood>
    {
        public NeighbourhoodValidation()
        {
            RuleFor(x => x.NeighbourhoodName).NotEmpty().WithMessage("NeighbourhoodName is required");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("District is required");
        }
    }
}
