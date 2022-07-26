using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class SituationValidation:AbstractValidator<Situation>
    {
        public SituationValidation()
        {
            RuleFor(x => x.SituationName).NotEmpty().WithMessage("Name is required");
        }
    }
}
