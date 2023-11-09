using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IDrawRepository : IAsyncRepository<Draw, Guid>, IRepository<Draw, Guid>
{
}