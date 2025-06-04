namespace ECommerce.API.Domain.DomainEvents;

public class ProductStockChangedEvent
{
    public int ProductId { get; }
    public int OldQuantity { get; }
    public int NewQuantity { get; }
    public DateTime ChangedAt { get; }

    public ProductStockChangedEvent(int productId, int oldQuantity, int newQuantity, DateTime changedAt)
    {
        ProductId = productId;
        OldQuantity = oldQuantity;
        NewQuantity = newQuantity;
        ChangedAt = changedAt;
    }
}
