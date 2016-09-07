using System;
using System.Net.Http;

public static void Run(TimerInfo myTimer, out Message outputQueueItem)
{
    using (var httpClient = new HttpClient())
    {
        outputQueueItem = new Message
        {
            Id = Guid.NewGuid().ToString(),
            Value = httpClient.GetStringAsync("http://www.setgetgo.com/randomword/get.php").Result
        };

        Console.WriteLine($"Generated key word: {outputQueueItem.Value}");
    }
}

public class Message
{
    public string Id { get; set; }
    public string Value { get; set; }
}