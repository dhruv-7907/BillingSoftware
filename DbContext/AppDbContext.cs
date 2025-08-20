using Billing.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }  
    public DbSet<Department>Departments { get; set; }  
    //public DbSet<Customer> Customers { get; set; }
    //public DbSet<Invoice> Invoices { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Invoice>()
    //        .HasOne(i => i.Customer)
    //        .WithMany(c => c.Invoices)
    //        .HasForeignKey(i => i.CustomerId);
    //}
}