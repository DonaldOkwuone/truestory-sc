using FluentValidation;
using Truestory.model;
using Truestory.model.pagination;

namespace Truestory.Validators
{
    public class FetchLaptopValidator : AbstractValidator<GadgetRequestParam>
    {
        public FetchLaptopValidator()
        {
            RuleFor(x => x.name).NotEmpty();
        }
    }
}
