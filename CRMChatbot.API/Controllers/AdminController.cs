using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CRMChatbot.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
[Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
    private readonly IAdminService _adminService;

    public AdminController(IAdminService adminService)
    {
        _adminService = adminService;
    }

    [HttpGet("bookings")]
    public async Task<IActionResult> GetAllBookings()
    {
        var bookings = await _adminService
            .GetAllBookingsAsync();

        return Ok(bookings);
    }

    [HttpPut("bookings/{id}/status")]
    public async Task<IActionResult> UpdateBookingStatus(
        int id,
        UpdateBookingStatusRequest request)
    {
        var result = await _adminService
            .UpdateBookingStatusAsync(id, request);

        return Ok(result);
    }
}