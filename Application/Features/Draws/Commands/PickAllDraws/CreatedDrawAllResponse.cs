using Domain.Entities;

namespace Application.Features.Draws.Commands.PickAllDraws
{
    public class CreatedDrawAllResponse
    {
        public string Picker { get; set; }
        public Guid TeamId { get; set; }
        public Guid GroupId { get; set; }

    }
}