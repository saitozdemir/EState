using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ImagesValidation : AbstractValidator<Images>
    {
        public ImagesValidation()
        {
            RuleFor(x => x.ImageName).NotEmpty().WithMessage("ImageName is required");
            RuleFor(x => x.AdvertId).NotEmpty().WithMessage("Advert is required");

        }
    }
}
