using Microsoft.EntityFrameworkCore;
using Models;

namespace Freebob;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Operator> Operators { get; set; }
    public  DbSet<Order> Orders  { get; set; }
    public  DbSet<Point> Points { get; set; }
    public  DbSet<Request> Requests { get; set; }
    public  DbSet<User> Users { get; set; }


    public void CreateBDNew()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //модификация таблиц в бд
        
    }

}




