namespace CRMChatbot.Application.Responses;

public class ApiResponse<T>
{
    public bool Success { get; set; }

    public required string Message { get; set; }

    public T? Data { get; set; }
}