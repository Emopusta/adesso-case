using Core.Application.Dtos;

namespace Application.Features.Teams.Queries.GetList;

public class GetListTeamListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CountryId { get; set; }
    public Guid GroupId { get; set; }
}