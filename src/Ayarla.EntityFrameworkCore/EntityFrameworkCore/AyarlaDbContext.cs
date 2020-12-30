using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ayarla.Authorization.Roles;
using Ayarla.Authorization.Users;
using Ayarla.MultiTenancy;
using Ayarla.Authorization.Accounts;

namespace Ayarla.EntityFrameworkCore
{
    public class AyarlaDbContext : AbpZeroDbContext<Tenant, Role, User, AyarlaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<AyarlaComment> AyarlaComments { get; set; }
        public DbSet<AyarlaFavorite> AyarlaFavorites { get; set; }
        public DbSet<AyarlaUsers> AyarlaUsers { get; set; }
        public DbSet<AyarlaAccount> AyarlaAccounts { get; set; }
        public DbSet<AyarlaAppoinment> AyarlaAppoinments { get; set; }
        public DbSet<AyarlaAuthorization> AyarlaAuthorizations { get; set; }
        public DbSet<AyarlaBusinessType> AyarlaBusinessTypes { get; set; }
        public DbSet<AyarlaEmployee> AyarlaEmployees { get; set; }
        public DbSet<AyarlaEmployeeAccount> AyarlaEmployeeAccounts { get; set; }
        public DbSet<AyarlaEmployeeAvailability> AyarlaEmployeeAvailabilities { get; set; }
        public DbSet<AyarlaEmployeeService> AyarlaEmployeeServices { get; set; }
        public DbSet<AyarlaServiceType> AyarlaServiceTypes { get; set; }
        public DbSet<AyarlaWorkingDay> AyarlaWorkingDays { get; set; }
        public AyarlaDbContext(DbContextOptions<AyarlaDbContext> options)
            : base(options)
        {
        }
    }
}
