using PersonalChatGPT.DTOs;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace PersonalChatGPT;

public class OpenAI
{
    /// <summary>
    /// Based on https://beta.openai.com/playground
    /// Method used to query Open AI API, check your Parameters to specify what the response should be
    /// </summary>
    /// <param name="tokens">Maximum amount of tokens the API can use</param>
    /// <param name="input">The question sent to Open AI</param>
    /// <param name="engine">Which AI engine to use to process the requests</param>
    /// <param name="temperature">Controls randomness: Result close to 0, more predictable response.</param>
    /// <param name="topP">Controls diversity of options, default 1</param>
    /// <param name="frequencyPenalty">Higher number = less repetitive response </param>
    /// <param name="presencePenalty">Higher number = more likely to start talking about a different topic</param>
    /// <returns>Response from Open AI</returns>
    public string Call(int tokens, string input, string engine, double temperature, int topP, int frequencyPenalty, int presencePenalty)
    {
        var openAiKey = "your_api_key";
        var apiCall = $"https://api.openai.com/v1/engines/{engine}/completions";

        using (var httpClient = new HttpClient())
        {
            var request = new HttpRequestMessage(HttpMethod.Post, apiCall);
            request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {openAiKey}");
            request.Content = new StringContent($@"{{
            ""prompt"": ""{input}"",
            ""temperature"": {temperature.ToString(CultureInfo.InvariantCulture)},
            ""max_tokens"": {tokens},
            ""top_p"": {topP},
            ""frequency_penalty"": {frequencyPenalty},
            ""presence_penalty"": {presencePenalty}
        }}", Encoding.UTF8, "application/json");

            var response = httpClient.Send(request);
            response.EnsureSuccessStatusCode();

            var json = response.Content.ReadAsStringAsync().Result;
            var myDeserializedClass = JsonSerializer.Deserialize<OpenAIResponse>(json);

            return myDeserializedClass.choices[0].text;
        }
    }
}
