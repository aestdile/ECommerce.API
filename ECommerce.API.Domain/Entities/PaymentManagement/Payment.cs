using ECommerce.API.Domain.Entities.OrderManagement;

namespace ECommerce.API.Domain.Entities.PaymentManagement;

public class Payment
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int PaymentMethodId { get; set; }
    public decimal Amount { get; set; }
    public bool IsSuccessful { get; set; }
    public DateTime PaidAt { get; set; }

    public Order Order { get; set; } = null!;
    public PaymentMethod PaymentMethod { get; set; } = null!;
}
