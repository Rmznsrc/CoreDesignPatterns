using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VEO0HFH\\SQLEXPRESS; initial catalog=CORDesignPatternDB ;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
