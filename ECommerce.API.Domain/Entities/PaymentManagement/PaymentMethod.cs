namespace ECommerce.API.Domain.Entities.PaymentManagement;

public class PaymentMethod
{
    public int Id { get; set; }
    public string MethodName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; }

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
