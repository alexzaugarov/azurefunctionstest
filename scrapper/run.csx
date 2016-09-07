#r "GoogleScrapper.dll"

using System;
using GoogleScrapper;

public static void Run(Message wordItem, TraceWriter log)
{
    log.Info($"Word to search: {wordItem.Value}");

    var scrapper = new GoogleScrapper.GoogleScrapper() { HtmlContentProvider = new SeleniumHtmlProvider() };

    var scrapResult = scrapper.Search(wordItem.Value);

    Console.WriteLine($"Word to search: {wordItem.Value}");
    Console.WriteLine($"Result title: {scrapResult.Title}");
}

public class Message
{
    public string Id { get; set; }
    public string Value { get; set; }
}