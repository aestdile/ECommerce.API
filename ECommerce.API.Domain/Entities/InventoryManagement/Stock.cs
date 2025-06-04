using ECommerce.API.Domain.Entities.ProductManagement;

namespace ECommerce.API.Domain.Entities.InventoryManagement;

public class Stock
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int QuantityAvailable { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Product Product { get; set; } = null!;
}
