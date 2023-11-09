using Core.Application.Responses;

namespace Application.Features.Teams.Queries.GetById;

public class GetByIdTeamResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public Guid GroupId { get; set; }
}