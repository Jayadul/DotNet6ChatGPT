namespace PersonalChatGPT.DTOs;

// Text response
public class Choice
{
    // Text response
    public string? text { get; set; }
    public int index { get; set; }
    public object? logprobs { get; set; }
    // Why generation ended
    public string? finish_reason { get; set; }
}
