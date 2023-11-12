using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter a message to translate:");
        string userInput = Console.ReadLine();

        await TranslateAndDisplay(userInput);

        Console.ReadLine(); // Keep console open
    }

    static async Task TranslateAndDisplay(string text)
    {
        var client = new HttpClient();

        
        var apiKey = "a5c80f2834mshf39eb4d14e60d61p1d5810jsn1937d59003c1";

        // List of target language codes
        string[] targetLanguages = { "es", "fr", "de", "ja", "ko", "zh-CN", "nl" };

        // Randomly select a target language
        Random random = new Random();
        string targetLanguage = targetLanguages[random.Next(targetLanguages.Length)];

        var requestUri = $"https://nlp-translation.p.rapidapi.com/v1/translate?text={Uri.EscapeDataString(text)}&to={targetLanguage}&from=en";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(requestUri),
            Headers =
            {
                { "X-RapidAPI-Key", apiKey },
                { "X-RapidAPI-Host", "nlp-translation.p.rapidapi.com" },
            },
        };

        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Translated Message (Target Language: {targetLanguage}):");
            Console.WriteLine(responseBody);
        }
    }
}
