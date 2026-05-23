using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using CRMChatbot.Domain.Entities;
using CRMChatbot.Infrastructure.Persistence;

namespace CRMChatbot.Infrastructure.Services;
public class ComplaintService : IComplaintService
{
    private readonly AppDbContext _context;

    public ComplaintService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<string> CreateComplaintAsync(ComplaintRequest request)
    {
        var complaint = new Complaint
        {
            UserId = request.UserId,
            BookingId = request.BookingId,
            Subject = request.Subject,
            Description = request.Description,
            Status = "Pending"
        };

        _context.Complaints.Add(complaint);

        await _context.SaveChangesAsync();

        return "Complaint created successfully";
    }
}