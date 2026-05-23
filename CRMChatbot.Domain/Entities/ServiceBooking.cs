using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMChatbot.Domain.Entities;

public class ServiceBooking
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int VehicleId { get; set; }

    public string ServiceType { get; set; } = string.Empty;

    public DateTime BookingDate { get; set; }

    public string TimeSlot { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
}