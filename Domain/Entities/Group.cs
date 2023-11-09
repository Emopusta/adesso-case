using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Group : Entity<Guid>
{
    public string MatchName{ get; set; }
    public string Name { get; set; }
    public virtual ICollection<Team> Teams { get; set; }
    public Group()
    {
    }

    public Group(Guid id, string matchName, string name)
    {
        Id = id;
        MatchName = matchName;
        Name = name;
    }   
}
