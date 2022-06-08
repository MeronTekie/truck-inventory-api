using Microsoft.EntityFrameworkCore;
namespace TruckInventory.Models
{
  public class TruckInventoryContext : DbContext
  {
    public TruckInventoryContext(DbContextOptions<TruckInventoryContext> options) 
    :base(options)
    {

    } 
    public DbSet<Inventory> Inventories { get; set;}
  }
}