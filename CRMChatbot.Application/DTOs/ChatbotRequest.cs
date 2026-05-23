using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMChatbot.Application.DTOs;

public class ChatbotRequest
{
    public int UserId { get; set; }
    public string Message { get; set; } = string.Empty;
}