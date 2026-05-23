using System.ComponentModel.DataAnnotations;

namespace CRMChatbot.Application.DTOs;

public class ComplaintRequest
{
    [Required]
    public int UserId { get; set; }

    [Required]
    public int BookingId { get; set; }

    [Required]
    public required string Subject { get; set; }

    [Required]
    public required string Description { get; set; }
}