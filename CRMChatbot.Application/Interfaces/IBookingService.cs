using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRMChatbot.Application.DTOs;
using CRMChatbot.Domain.Entities;

namespace CRMChatbot.Application.Interfaces;

public interface IBookingService
{
    Task<string> CreateBookingAsync(BookingRequest request);

    Task<List<ServiceBooking>> GetUserBookingsAsync(int userId);
}