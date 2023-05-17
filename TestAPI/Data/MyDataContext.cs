using Marques.EFCore.SnakeCase;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data;

public class MyDataContext : DbContext
{
    
    public MyDataContext(DbContextOptions<MyDataContext> options) : base(options)
    {
        
    }
    public DbSet<Book>? Book { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.ToSnakeCase();
    }
}