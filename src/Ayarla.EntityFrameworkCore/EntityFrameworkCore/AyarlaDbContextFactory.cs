using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Ayarla.Configuration;
using Ayarla.Web;

namespace Ayarla.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AyarlaDbContextFactory : IDesignTimeDbContextFactory<AyarlaDbContext>
    {
        public AyarlaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AyarlaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AyarlaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AyarlaConsts.ConnectionStringName));

            return new AyarlaDbContext(builder.Options);
        }
    }
}
