using Core.Application.Responses;

namespace Application.Features.Groups.Queries.GetById;

public class GetByIdGroupResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}