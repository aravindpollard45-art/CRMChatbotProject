using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRMChatbot.Application.DTOs;

namespace CRMChatbot.Application.Interfaces;

public interface IComplaintService
{
    Task<string> CreateComplaintAsync(ComplaintRequest request);
}