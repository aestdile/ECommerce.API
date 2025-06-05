namespace ECommerce.API.Application.DTOs.OrderDTOs;

public class CreateOrderDto
{
    public int UserId { get; set; }
    public string ShippingAddress { get; set; } 
    public List<OrderItemDto> OrderItems { get; set; } = new();
}
