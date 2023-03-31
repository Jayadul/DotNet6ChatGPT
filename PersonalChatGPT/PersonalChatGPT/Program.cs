using PersonalChatGPT;

Console.WriteLine("Provide a text question:");
var question = Console.ReadLine();

// Call Open AI
OpenAI openAI = new();
var answer = openAI.Call(250, question, "text-davinci-002", 0.7, 1, 0, 0);
Console.WriteLine(answer);