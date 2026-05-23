using CRMChatbot.Application.DTOs;

namespace CRMChatbot.Application.Interfaces;

public interface IAuthService
{
    Task<string> RegisterAsync(RegisterRequest request);

    Task<string?> LoginAsync(LoginRequest request);
}