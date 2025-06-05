using ECommerce.API.Application.DTOs.OrderDTOs;

namespace ECommerce.API.Application.Services;

public interface IOrderService
{
    Task<int> CreateOrderAsync(CreateOrderDto dto);
    Task<OrderResponseDto?> GetOrderByIdAsync(int id);
    Task<List<OrderResponseDto>> GetUserOrdersAsync(int userId);
    Task<bool> CancelOrderAsync(int orderId);
}
