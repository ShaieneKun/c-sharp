using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Write to console
        Console.WriteLine ("Hello Mono World");
        // Downloading .html file from website
        string webPageHtml = new System.Net.WebClient().DownloadString("https://www.nuget.org");
        Console.WriteLine(webPageHtml);
    }
}
