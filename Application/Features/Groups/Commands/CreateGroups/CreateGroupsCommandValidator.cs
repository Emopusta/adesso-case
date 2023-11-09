using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
