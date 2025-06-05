namespace ECommerce.API.Application.DTOs.ProductDTOs;

public class UpdateProductDto
{
    public int Id { get; set; } // yoki route orqali keladi
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string SKU { get; set; } = string.Empty;
    public int StockQuantity { get; set; }
    public int CategoryId { get; set; }
    public bool IsActive { get; set; }
}
