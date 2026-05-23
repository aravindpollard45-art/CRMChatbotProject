using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using CRMChatbot.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CRMChatbot.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var result = await _authService.RegisterAsync(request);

        if (result == "Email already exists")
        {
            return BadRequest(new ApiResponse<string>
            {
                Success = false,
                Message = result,
                Data = null
            });
        }

        return Ok(new ApiResponse<string>
        {
            Success = true,
            Message = result,
            Data = null
        });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var token = await _authService.LoginAsync(request);

        if (token == null)
        {
            return Unauthorized(new ApiResponse<string>
            {
                Success = false,
                Message = "Invalid email or password",
                Data = null
            });
        }

        return Ok(new ApiResponse<string>
        {
            Success = true,
            Message = "Login successful",
            Data = token
        });
    }
}