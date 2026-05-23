using System.ComponentModel.DataAnnotations;

namespace CRMChatbot.Application.DTOs;

public class LoginRequest
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MinLength(5)]
    public required string Password { get; set; }
}