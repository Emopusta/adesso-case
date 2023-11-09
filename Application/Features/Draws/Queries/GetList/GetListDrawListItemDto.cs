using Core.Application.Dtos;

namespace Application.Features.Draws.Queries.GetList;

public class GetListDrawListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Picker { get; set; }
    public Guid TeamId { get; set; }
    public Guid GroupId { get; set; }
}