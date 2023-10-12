using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using weatherapi.Models;

namespace weatherapi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        } 
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            try
            {
                var databaseCreater =Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreater != null)
                {
                    if (!databaseCreater.CanConnect())
                    {
                        databaseCreater.Create();
                    }
                    if (!databaseCreater.HasTables())
                    {
                        databaseCreater.CreateTables();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public DbSet<Book> books { get; set; }
    }
}