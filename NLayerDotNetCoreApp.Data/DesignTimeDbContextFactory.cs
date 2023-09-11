using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NLayerDotNetCoreApp.Data.EntityFramework;

namespace NLayerDotNetCoreApp.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AppDbContext> dbContextOptionsBuilder = new();

            IConfiguration config = new ConfigurationBuilder()
           .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NLayerDotNetCoreApp.API"))
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .Build();

            var connectionString = config.GetConnectionString("Dev_ConString");
            dbContextOptionsBuilder.UseSqlServer(connectionString);

            return (AppDbContext)Activator.CreateInstance(typeof(AppDbContext), dbContextOptionsBuilder.Options);
        }
    }
}
