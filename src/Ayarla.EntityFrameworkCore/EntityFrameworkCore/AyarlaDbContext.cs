using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ayarla.Authorization.Roles;
using Ayarla.Authorization.Users;
using Ayarla.MultiTenancy;

namespace Ayarla.EntityFrameworkCore
{
    public class AyarlaDbContext : AbpZeroDbContext<Tenant, Role, User, AyarlaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AyarlaDbContext(DbContextOptions<AyarlaDbContext> options)
            : base(options)
        {
        }
    }
}
