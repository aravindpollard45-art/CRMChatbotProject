using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRMChatbot.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChatbotController : ControllerBase
{
    private readonly IChatbotService _chatbotService;

    public ChatbotController(IChatbotService chatbotService)
    {
        _chatbotService = chatbotService;
    }

    [HttpPost("ask")]
    public async Task<IActionResult> Ask(ChatbotRequest request)
    {
        var reply = await _chatbotService.AskQuestionAsync(request);

        return Ok(reply);
    }
}