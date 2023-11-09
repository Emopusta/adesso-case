using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Team : Entity<Guid>
    {
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; }

        public Team()
        {
        }

        public Team(Guid id,string name, Guid countryId, Guid groupId, Group group)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
            GroupId = groupId;
            Group = group;
        }
    }
}
