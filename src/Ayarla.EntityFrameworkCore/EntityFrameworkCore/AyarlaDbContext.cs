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
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<OpenCloseTime> OpenCloseTimes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public DbSet<EmployeeAvailability> EmployeeAvailabilities { get; set; }
        public DbSet<EmployeeService> EmployeeServices { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<WorkingDay> WorkingDays { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public AyarlaDbContext(DbContextOptions<AyarlaDbContext> options)
            : base(options)
        {
        }
    }
}
