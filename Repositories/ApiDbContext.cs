using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Repositories;
public class ApiDbContext : DbContext

{
    public DbSet<Auction> Auctions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite("Data Source=database.db");

    }

}