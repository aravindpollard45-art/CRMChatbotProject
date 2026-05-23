using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using CRMChatbot.Domain.Entities;
using CRMChatbot.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CRMChatbot.Infrastructure.Services;
public class BookingService : IBookingService
{
    private readonly AppDbContext _context;

    public BookingService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<string> CreateBookingAsync(BookingRequest request)
    {
        var booking = new ServiceBooking
        {
            UserId = request.UserId,
            VehicleId = request.VehicleId,
            ServiceType = request.ServiceType,
            BookingDate = request.BookingDate,
            TimeSlot = request.TimeSlot,
            Status = "Pending"
        };

        _context.ServiceBookings.Add(booking);

        await _context.SaveChangesAsync();

        return "Booking created successfully";
    }

    public async Task<List<ServiceBooking>> GetUserBookingsAsync(int userId)
    {
        return await _context.ServiceBookings
            .Where(x => x.UserId == userId)
            .ToListAsync();
    }
}