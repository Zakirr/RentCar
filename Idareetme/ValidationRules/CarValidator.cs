using FluentValidation;
using Girilenler.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(20);
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(20).When(p=>p.Id==3);
            RuleFor(p => p.CarName).Must(StartWithA).WithMessage("A ile baslamalidir");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
