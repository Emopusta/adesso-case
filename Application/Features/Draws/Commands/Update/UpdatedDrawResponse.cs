using Core.Application.Responses;

namespace Application.Features.Draws.Commands.Update;

public class UpdatedDrawResponse : IResponse
{
    public Guid Id { get; set; }
    public string Picker { get; set; }
    public Guid TeamId { get; set; }
    public Guid GroupId { get; set; }
}