using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CRMChatbot.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ComplaintController : ControllerBase
{
    private readonly IComplaintService _complaintService;

    public ComplaintController(IComplaintService complaintService)
    {
        _complaintService = complaintService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateComplaint(
        ComplaintRequest request)
    {
        var result = await _complaintService
            .CreateComplaintAsync(request);

        return Ok(result);
    }
}