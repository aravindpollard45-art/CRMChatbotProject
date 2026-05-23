using System.ComponentModel.DataAnnotations;

namespace CRMChatbot.Application.DTOs;

public class RegisterRequest
{
    [Required]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MinLength(6)]
    public required string Password { get; set; }

    [Required]
    public required string Phone { get; set; }

    [Required]
    public required string Role { get; set; }
}