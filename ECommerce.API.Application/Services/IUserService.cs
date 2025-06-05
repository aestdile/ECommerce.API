using ECommerce.API.Application.DTOs.UserDTOs;

namespace ECommerce.API.Application.Services;

public interface IUserService
{
    Task<int> CreateUserAsync(CreateUserDto dto);
    Task<UserResponseDto?> GetUserByIdAsync(int id);
    Task<bool> UpdateUserAsync(int id, UpdateUserDto dto);
    Task<UserResponseDto?> LoginAsync(LoginDto dto);
}
