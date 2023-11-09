using Core.Application.Responses;

namespace Application.Features.Groups.Commands.Create;

public class CreatedGroupResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}