using Core.Application.Responses;

namespace Application.Features.Teams.Commands.Update;

public class UpdatedTeamResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public Guid GroupId { get; set; }
}