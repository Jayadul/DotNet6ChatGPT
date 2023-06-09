
# ChatGPT Integration in .NET Applications

This repository contains an example of how to integrate ChatGPT, a powerful conversational AI tool based on the GPT-3.5 architecture, into your .NET application.



## Prerequisites

- NET Core 3.1 or higher
- An OpenAI API key


## Usage

In your .NET application, create an instance of the OpenAI class and call the Complete method, passing in the desired parameters. The Complete method returns a string containing the generated text.
```bash
var openAI = new OpenAI();
var response = openAI.Complete("Hello, ChatGPT!", "davinci", 0.7, 50, 0, 0);
Console.WriteLine(response);
```
    
## Contributing

Contributions to this project are welcome. Feel free to submit a pull request or open an issue if you find a bug or have a suggestion for improvement.

