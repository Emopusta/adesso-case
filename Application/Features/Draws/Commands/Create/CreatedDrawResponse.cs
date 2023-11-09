using Core.Application.Responses;

namespace Application.Features.Draws.Commands.Create;

public class CreatedDrawResponse : IResponse
{
    public Guid Id { get; set; }
    public string Picker { get; set; }
    public Guid TeamId { get; set; }
    public Guid GroupId { get; set; }
}