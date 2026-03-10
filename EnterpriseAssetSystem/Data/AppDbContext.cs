using Microsoft.EntityFrameworkCore;
using EnterpriseAssetSystem.Models.Entities;



namespace EnterpriseAssetSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<AssetAccount> AssetAccounts { get; set; }

        public DbSet<TransactionLog> TransactionLogs { get; set; }
    }
}
