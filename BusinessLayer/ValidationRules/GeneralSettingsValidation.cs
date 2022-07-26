using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GeneralSettingsValidation:AbstractValidator<GeneralSettings>
    {
        public GeneralSettingsValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required");
            RuleFor(x => x.ImageName).NotEmpty().WithMessage("Image is required");
        }
    }
}
