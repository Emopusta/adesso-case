using Core.Application.Dtos;

namespace Application.Features.Groups.Queries.GetList;

public class GetListGroupListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}