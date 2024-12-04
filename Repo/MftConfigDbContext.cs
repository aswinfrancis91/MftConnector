using Microsoft.EntityFrameworkCore;

namespace MftConnector.Repo;

public class MftConfigDbContext :DbContext
{
    public DbSet<MftConfig> MftConfig { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=LocalDatabase.db");
    }
}