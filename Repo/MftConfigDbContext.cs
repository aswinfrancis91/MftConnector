using Microsoft.EntityFrameworkCore;

namespace ApiConnector.Repo;

public class MftConfigDbContext :DbContext
{
    public DbSet<MftConfig> MftConfig { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=LocalDatabase.db");
    }
}