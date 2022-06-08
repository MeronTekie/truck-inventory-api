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
    
  }
}