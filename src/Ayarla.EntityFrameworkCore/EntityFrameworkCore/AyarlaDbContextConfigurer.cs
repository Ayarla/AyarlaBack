using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ayarla.EntityFrameworkCore
{
    public static class AyarlaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AyarlaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AyarlaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
