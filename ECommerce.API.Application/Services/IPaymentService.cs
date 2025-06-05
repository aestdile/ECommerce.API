using ECommerce.API.Domain.Entities.PaymentManagement;

namespace ECommerce.API.Application.Services;

public interface IPaymentService
{
    Task<bool> ProcessPaymentAsync(int orderId, PaymentMethod method, decimal amount);
    Task<bool> RefundPaymentAsync(int orderId);
}
