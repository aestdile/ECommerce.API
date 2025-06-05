using ECommerce.API.Application.DTOs.OrderDTOs;

namespace ECommerce.API.Application.Services;

public interface IEmailService
{
    Task SendOrderConfirmationEmailAsync(string toEmail, OrderResponseDto order);
    Task SendPasswordResetEmailAsync(string toEmail, string resetToken);
}
