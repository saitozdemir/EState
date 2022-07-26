using System.Text.RegularExpressions;
using EntityLayer.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AdvertValidation:AbstractValidator<Advert>
    {
        public AdvertValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(x => x.AdvertTitle).NotEmpty().WithMessage("Advert's title is required");
            RuleFor(x => x.AdvertTitle).Length(1, 100).WithMessage("Advert's title must be between 1 and 100 characters");
            RuleFor(x => x.AirCondinator).NotEmpty().WithMessage("Advert's aircondinator is required");
            RuleFor(x => x.Area).NotEmpty().WithMessage("Advert's area is required");
            RuleFor(x => x.BadroomNumbers).GreaterThan(0).WithMessage("Badroom's numbers must be greater than 0");
            RuleFor(x => x.NumberOfRooms).GreaterThan(0).WithMessage("Room's number must be greater than 0");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Advert's description is required");
            RuleFor(x => x.Floor).NotEmpty().WithMessage("Advert's floor is required");
            RuleFor(x => x.Garage).NotEmpty().WithMessage("Advert's garage is required");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Advert's price is required");
            RuleFor(x => x.Pool).NotEmpty().WithMessage("Advert's pool is required");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Advert's phone number is required");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("Advert's district is required");
            RuleFor(x => x.TypeId).NotEmpty().WithMessage("Advert's type is required");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Advert's city is required");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("Advert's situation is required");
            RuleFor(x => x.PhoneNumber).Matches(new Regex("^[0-9]{10}$")).WithMessage("Phone number must be 10 digits");
        }
    }
}
