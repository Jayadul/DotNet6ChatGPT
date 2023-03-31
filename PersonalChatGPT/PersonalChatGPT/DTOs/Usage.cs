namespace PersonalChatGPT.DTOs;

// API Token usage
public class Usage
{
    // Difficulty of input
    public int prompt_tokens { get; set; }
    // Difficulty of output
    public int completion_tokens { get; set; }
    public int total_tokens { get; set; }
}
