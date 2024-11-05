using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VEO0HFH\\SQLEXPRESS;initial catalog=ObserverDesignPatternDB;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }  
        public DbSet<Discount> Discounts { get; set; }  
        public DbSet<UserProcess> UserProcesses { get; set; }  
    }
}
