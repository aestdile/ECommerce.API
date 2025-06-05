namespace ECommerce.API.Application.Services;

public interface IInventoryService
{
    Task<bool> ReduceStockAsync(int productId, int quantity);
    Task<bool> IncreaseStockAsync(int productId, int quantity);
    Task<int> GetStockQuantityAsync(int productId);
}
