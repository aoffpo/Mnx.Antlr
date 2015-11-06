using FluentValidation;
using Mnx.Antlr.Post.Listeners.Models;

namespace Mnx.Antlr.Post.Listeners.Validators
{
    public class PostDataValidator : AbstractValidator<PostData>
    {
        public PostDataValidator()
        {
            RuleFor(pd => pd.StartDate)
                .NotNull();
        }
    }
}
