﻿namespace ECommerce.API.Domain.Entities.ProductManagement;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
