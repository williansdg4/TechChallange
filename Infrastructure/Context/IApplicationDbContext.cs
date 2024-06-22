using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Contacts> Contacts { get; set; }
        DbSet<Regions> Regions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
