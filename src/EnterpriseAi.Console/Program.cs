using Microsoft.Extensions.AI;
using OllamaSharp;

Console.WriteLine("Enterprise AI .NET Lab");
Console.WriteLine("----------------------");

IChatClient chatClient = new OllamaApiClient(
    new Uri("http://localhost:11434"),
    "qwen3:1.7b"
);

Console.WriteLine("Sending request to local AI model...");
Console.WriteLine();

try
{
    ChatResponse response = await chatClient.GetResponseAsync(
        "Explain dependency injection in .NET in two simple sentences."
    );

    Console.WriteLine("AI Response:");
    Console.WriteLine(response.Text);
}
catch (Exception ex)
{
    Console.Error.WriteLine(
        $"AI request failed: {ex.Message}"
    );

    Environment.ExitCode = 1;
}
