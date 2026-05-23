using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRMChatbot.Domain.Entities;

public class Vehicle
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string VehicleType { get; set; } = string.Empty;

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string VehicleNumber { get; set; } = string.Empty;
}