namespace Truestory.Validators
{
    using FluentValidation;
    using Truestory.model;

    public class GadgetValidator : AbstractValidator<Gadget>
    {
        public GadgetValidator()
        {
            RuleFor(x => x.name).NotEmpty();
            RuleFor(x => x.data).NotEmpty().WithMessage("Please specify data objec");
            RuleFor(x => x.data.Harddisksize).NotEmpty().WithMessage("Please specify a Hard disk size");
            RuleFor(x => x.data.year).GreaterThanOrEqualTo(2000).WithMessage("Please specify a year greater than 2000");
            RuleFor(x => x.data.price).NotEmpty().WithMessage("Please specify price");
          
        }

         
    }
}

