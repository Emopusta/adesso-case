using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Draw : Entity<Guid>
{
    public string Picker { get; set; }
    public Guid TeamId { get; set; }
    public Guid GroupId { get; set; }

}
