using System;
using FluentValidation;
using Mnx.Antlr.Data.Models;

namespace Mnx.Antlr.Post.Listeners.Validators
{
    public class PostDataValidator : AbstractValidator<PostData>
    {
        public PostDataValidator()
        {
            RuleFor(pd => pd.StartDate)
                .Must(sd=>sd != DateTime.MinValue).WithMessage("StartDate is Min Date")
                .NotNull().WithMessage("StartDate is null");
          
        }
    }
}
