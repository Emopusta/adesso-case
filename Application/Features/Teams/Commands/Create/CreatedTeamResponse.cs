using Core.Application.Responses;

namespace Application.Features.Teams.Commands.Create;

public class CreatedTeamResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public Guid GroupId { get; set; }
}