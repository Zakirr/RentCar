using FluentValidation;
using Girilenler.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(5);
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.CarName).Must(StartWithA).WithMessage("A ile baslamalidir");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
