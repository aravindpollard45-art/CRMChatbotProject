using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using CRMChatbot.Domain.Entities;
using CRMChatbot.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CRMChatbot.Infrastructure.Services;
public class AdminService : IAdminService
{
    private readonly AppDbContext _context;

    public AdminService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ServiceBooking>> GetAllBookingsAsync()
    {
        return await _context.ServiceBookings.ToListAsync();
    }

    public async Task<string> UpdateBookingStatusAsync(
        int bookingId,
        UpdateBookingStatusRequest request)
    {
        var booking = await _context.ServiceBookings
            .FirstOrDefaultAsync(x => x.Id == bookingId);

        if (booking == null)
        {
            return "Booking not found";
        }

        booking.Status = request.Status;

        await _context.SaveChangesAsync();

        return "Booking status updated";
    }
}