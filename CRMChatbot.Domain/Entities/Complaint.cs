using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRMChatbot.Domain.Entities;

public class Complaint
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int BookingId { get; set; }

    public string Subject { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
}