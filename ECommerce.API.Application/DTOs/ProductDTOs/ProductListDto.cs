﻿namespace ECommerce.API.Application.DTOs.ProductDTOs;

public class ProductListDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public string CategoryName { get; set; } = string.Empty;
}
