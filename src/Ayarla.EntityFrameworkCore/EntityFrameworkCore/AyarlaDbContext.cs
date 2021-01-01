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
        public DbSet<Comment> AyarlaComments { get; set; }
        public DbSet<Favorite> AyarlaFavorites { get; set; }
        public DbSet<AyarlaUsers> AyarlaUsers { get; set; }
        public DbSet<Account> AyarlaAccounts { get; set; }
        public DbSet<Appoinment> AyarlaAppoinments { get; set; }
        public DbSet<AyarlaAuthorization> AyarlaAuthorizations { get; set; }
        public DbSet<BusinessType> AyarlaBusinessTypes { get; set; }
        public DbSet<Employee> AyarlaEmployees { get; set; }
        public DbSet<EmployeeAccount> AyarlaEmployeeAccounts { get; set; }
        public DbSet<EmployeeAvailability> AyarlaEmployeeAvailabilities { get; set; }
        public DbSet<EmployeeService> AyarlaEmployeeServices { get; set; }
        public DbSet<ServiceType> AyarlaServiceTypes { get; set; }
        public DbSet<WorkingDay> AyarlaWorkingDays { get; set; }
        public AyarlaDbContext(DbContextOptions<AyarlaDbContext> options)
            : base(options)
        {
        }
    }
}
