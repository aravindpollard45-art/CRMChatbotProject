using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMChatbot.Application.DTOs;

public class UpdateBookingStatusRequest
{
    public string Status { get; set; } = string.Empty;
}