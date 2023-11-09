using Core.Application.Responses;

namespace Application.Features.Draws.Queries.GetById;

public class GetByIdDrawResponse : IResponse
{
    public Guid Id { get; set; }
    public string Picker { get; set; }
    public Guid TeamId { get; set; }
    public Guid GroupId { get; set; }
}