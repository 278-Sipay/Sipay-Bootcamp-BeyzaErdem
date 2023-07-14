using FluentValidation;
using SipayApi.Model;

namespace SipayApi.ValidationRules
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Staff person name must not be empty")
                .Length(5,100).WithMessage("Staff person name must be between 5 and 100 characters ");

            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Staff person lastname must not be empty")
                .Length(5, 100).WithMessage("Staff person lastname must be between 5 and 100 characters ");

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Staff person phone must not be empty")
                .Matches(@"^\d+$").WithMessage("Staff person phone must be consists of numbers");

            RuleFor(x => x.Salary).NotEmpty().WithMessage("Staff person salary must not be empty")
                .GreaterThanOrEqualTo(5000).LessThanOrEqualTo(50000).WithMessage("Staff person salary must be between 5000 and 50000");

            RuleFor(x => x.AccessLevel).NotEmpty().WithMessage("Staff person access level to system must not be empty")
                .GreaterThanOrEqualTo(1).LessThanOrEqualTo(5).WithMessage("Staff person access level to system must be between 1 and 5");
        }
    }
}
