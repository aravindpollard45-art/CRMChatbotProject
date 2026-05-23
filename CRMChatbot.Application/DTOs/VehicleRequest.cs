using System.ComponentModel.DataAnnotations;

namespace CRMChatbot.Application.DTOs;

public class VehicleRequest
{
    [Required]
    public int UserId { get; set; }

    [Required]
    public required string VehicleType { get; set; }

    [Required]
    public required string Brand { get; set; }

    [Required]
    public required string Model { get; set; }

    [Required]
    public required string VehicleNumber { get; set; }
}