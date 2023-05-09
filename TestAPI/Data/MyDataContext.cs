using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data;

public class MyDataContext : DbContext
{

    /*public MyDataContext()
    {
        
    }*/
    public MyDataContext(DbContextOptions<MyDataContext> options) : base(options)
    {
        
    }
    public DbSet<Book>? Book { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseNpgsql("Server=localhost;Port=5432;Database=testNET;User Id=postgres;Password=password;");
        }
    }*/
}