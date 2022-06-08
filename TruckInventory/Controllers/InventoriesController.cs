using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TruckInventory.Models;
using System.Collections.Generic;

namespace TruckInventory.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class InventoriesController : ControllerBase
  {
    private readonly TruckInventoryContext _db;
    public InventoriesController(TruckInventoryContext db)
    {
      _db =db;
    }
    [HttpGet]
    public async  Task<ActionResult<IEnumerable<Inventory>>> Get()
    {
      var inventory = await _db.Inventories.ToListAsync();
      return inventory;
    }
    [HttpPost]
    public async Task<ActionResult<Inventory>> Post(Inventory inventory)
    {
      _db.Inventories.Add(inventory);
      _db.SaveChanges();
      return CreatedAtAction("Post",new {id =inventory.InventoryId},inventory);

    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Inventory>>  GetInventory(int id)
    {
    var inventory =  await _db.Inventories.FindAsync(id);
    if(inventory == null)
    {
      return NotFound();
    }
    return  inventory;

    }
  




  }
}