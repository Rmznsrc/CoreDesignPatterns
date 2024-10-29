using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VEO0HFH\\SQLEXPRESS;initial catalog=CQRSDesignPatternDB;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Product>Products { get; set; }
    }
}
