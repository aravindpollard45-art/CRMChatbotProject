using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using CRMChatbot.Domain.Entities;
using CRMChatbot.Infrastructure.Persistence;

namespace CRMChatbot.Infrastructure.Services;
public class ChatbotService : IChatbotService
{
    private readonly AppDbContext _context;

    public ChatbotService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<string> AskQuestionAsync(ChatbotRequest request)
    {
        string reply = "Sorry, I don't understand.";

        if (request.Message.ToLower().Contains("service"))
        {
            reply = "We provide oil change, washing, and repair services.";
        }

        var chat = new ChatMessage
        {
            UserId = request.UserId,
            Message = request.Message,
            Reply = reply,
            CreatedAt = DateTime.Now
        };

        _context.ChatMessages.Add(chat);

        await _context.SaveChangesAsync();

        return reply;
    }
}