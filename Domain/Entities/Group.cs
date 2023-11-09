using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Group : Entity<Guid>
{
    public string Name { get; set; }
    public virtual ICollection<Team> Teams { get; set; }
    public Group()
    {
    }

    public Group(Guid id,string name)
    {
        Id = id;
        Name = name;
    }
}
