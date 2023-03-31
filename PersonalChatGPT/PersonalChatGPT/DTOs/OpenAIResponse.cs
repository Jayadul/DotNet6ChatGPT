namespace PersonalChatGPT.DTOs;

// Main Open AI response object
public class OpenAIResponse
{
    // Auto-generated
    public string? id { get; set; }

    // Target job
    public string? @object { get; set; }
    public int created { get; set; }

    // Engine used
    public string? model { get; set; }

    // API response
    public List<Choice>? choices { get; set; }

    // Tokens used
    public Usage? usage { get; set; }
}
