namespace ECommerce.API.Domain.DomainEvents;

public class PaymentProcessedEvent
{
    public int PaymentId { get; }
    public bool IsSuccessful { get; }
    public DateTime ProcessedAt { get; }

    public PaymentProcessedEvent(int paymentId, bool isSuccessful, DateTime processedAt)
    {
        PaymentId = paymentId;
        IsSuccessful = isSuccessful;
        ProcessedAt = processedAt;
    }
}
