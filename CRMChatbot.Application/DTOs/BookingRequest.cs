using System.ComponentModel.DataAnnotations;

namespace CRMChatbot.Application.DTOs;

public class BookingRequest
{
    [Required]
    public int UserId { get; set; }

    [Required]
    public int VehicleId { get; set; }

    [Required]
    public required string ServiceType { get; set; }

    [Required]
    public DateTime BookingDate { get; set; }

    [Required]
    public required string TimeSlot { get; set; }
}