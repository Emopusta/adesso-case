using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class GroupRepository : EfRepositoryBase<Group, Guid, BaseDbContext>, IGroupRepository
{
    public GroupRepository(BaseDbContext context) : base(context)
    {
    }
}