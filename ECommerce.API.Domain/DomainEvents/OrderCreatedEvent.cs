namespace ECommerce.API.Domain.DomainEvents;

public class OrderCreatedEvent
{
    public int OrderId { get; }
    public DateTime CreatedAt { get; }

    public OrderCreatedEvent(int orderId, DateTime createdAt)
    {
        OrderId = orderId;
        CreatedAt = createdAt;
    }
}
