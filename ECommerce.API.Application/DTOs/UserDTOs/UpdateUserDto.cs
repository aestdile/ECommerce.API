namespace ECommerce.API.Application.DTOs.UserDTOs;

public class UpdateUserDto
{
    public int Id { get; set; } // yoki route orqali keladi
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}
