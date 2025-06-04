﻿using ECommerce.API.Domain.Entities.OrderManagement;

namespace ECommerce.API.Domain.Entities.UserManagement;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
