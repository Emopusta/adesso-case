using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Country : Entity<Guid>
{
    public string Name { get; set; }
    public Country()
    {
    }

    public Country(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
