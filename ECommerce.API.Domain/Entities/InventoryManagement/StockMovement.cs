using ECommerce.API.Domain.Entities.ProductManagement;

namespace ECommerce.API.Domain.Entities.InventoryManagement;

public class StockMovement
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int QuantityChanged { get; set; } // + or - quantity
    public string Reason { get; set; } = string.Empty;
    public DateTime ChangedAt { get; set; }

    public Product Product { get; set; } = null!;
}
