namespace TruckInventory.Models
{
  public class Inventory
  {
    public int InventoryId { get; set; }
    public string DispatcherName { get; set; }
    public string DispatcherId { get; set; }
    public string  DriverName {  get; set; }
    public string DriverId { get; set; }
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    public int Distance { get; set; }
    public DateTime Date { get; set; }
  }
}