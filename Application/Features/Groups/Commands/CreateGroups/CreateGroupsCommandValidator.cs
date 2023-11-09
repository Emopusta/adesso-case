using FluentValidation;

namespace Application.Features.Groups.Commands.CreateGroups
{
    public class CreateGroupsCommandValidator : AbstractValidator<CreateGroupsCommand>
    {
        public CreateGroupsCommandValidator()
        {
            RuleFor(c => c.NumberOfGroups).Equal(4).Equal(8);
            RuleFor(c => c.MatchName).NotEmpty();
        }
    }
}
