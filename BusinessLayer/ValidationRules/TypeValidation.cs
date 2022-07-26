using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class TypeValidation : AbstractValidator<EntityLayer.Entity.Type>
    {
        public TypeValidation()
        {
            RuleFor(x => x.TypeName).NotEmpty().WithMessage("TypeName is required");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("TypeName is required");

        }
    }
}
