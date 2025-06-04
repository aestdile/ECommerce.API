using ECommerce.API.Domain.Entities.UserManagement;

namespace ECommerce.API.Domain.Entities.ProductManagement;

public class ProductReview
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; } // Rating should be between 1 and 5
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public Product Product { get; set; } = null!;
    public User User { get; set; } = null!;
}
