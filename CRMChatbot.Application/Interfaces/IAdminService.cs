using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMChatbot.Application.DTOs;
using CRMChatbot.Domain.Entities;

namespace CRMChatbot.Application.Interfaces;

public interface IAdminService
{
    Task<List<ServiceBooking>> GetAllBookingsAsync();

    Task<string> UpdateBookingStatusAsync(
        int bookingId,
        UpdateBookingStatusRequest request);
}