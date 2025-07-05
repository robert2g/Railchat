
namespace API.DTOs;

public class UserDTO
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string DisplayName { get; set; }
    public string? ImageUrl { get; set; }
    public required string Token { get; set; }
}
