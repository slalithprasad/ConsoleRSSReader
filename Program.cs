using System.Xml.Linq;

Dictionary<string, string> RssFeeds = new()
{
    { "World - BBC", "https://feeds.bbci.co.uk/news/world/rss.xml" },
    { "India - The Hindu", "https://www.thehindu.com/news/national/feeder/default.rss" },
    { ".NET - Microsoft Blog", "https://devblogs.microsoft.com/dotnet/feed/" },
    { "Tech - Azure Updates", "https://azure.microsoft.com/en-us/blog/feed/" },
    { "Manchester United", "https://thepeoplesperson.com/feed/" },
    { "Cricket", "https://www.espncricinfo.com/rss/content/story/feeds/0.xml" },
    { "Cricket Live Scores", "https://static.cricinfo.com/rss/livescores.xml" }
};

int maxNumberOfFeeds;

while (true)
{
    Console.Clear();
    Console.WriteLine("📡 Console RSS Reader\n");
    Console.WriteLine("Select a category:\n");

    int index = 1;
    foreach (var feed in RssFeeds)
    {
        Console.WriteLine($"{index}. {feed.Key}");
        index++;
    }

    Console.Write("\nEnter choice (1-" + RssFeeds.Count + ") or 'q' to quit: ");
    string? choice = Console.ReadLine();

    if (choice?.ToLower() == "q") break;

    Console.Write("\nEnter the number of feeds that you want to read: ");
    string? numberOfFeeds  = Console.ReadLine();

    while(!int.TryParse(numberOfFeeds, out maxNumberOfFeeds))
    {
        Console.Write("Enter valid number of feeds that you want to read: ");
        numberOfFeeds  = Console.ReadLine();
    }

    if (int.TryParse(choice, out int selectedIndex) && selectedIndex > 0 && selectedIndex <= RssFeeds.Count)
    {
        string selectedKey = new List<string>(RssFeeds.Keys)[selectedIndex - 1];
        string feedUrl = RssFeeds[selectedKey];

        Console.Clear();
        Console.WriteLine($"Fetching news from: {selectedKey}...\n");

        await FetchAndDisplayRss(feedUrl).ConfigureAwait(false);
    }
    else
    {
        Console.WriteLine("Invalid choice. Press Enter to try again.");
        Console.ReadLine();
    }
}

async Task FetchAndDisplayRss(string url)
{
    using HttpClient client = new();
    try
    {
        string xml = await client.GetStringAsync(url).ConfigureAwait(false);
        XDocument doc = XDocument.Parse(xml);

        var items = doc.Descendants("item");
        int count = 0;

        foreach (var item in items)
        {
            string title = item.Element("title")?.Value ?? "No title";
            string link = item.Element("link")?.Value ?? "No link";
            string description = item.Element("description")?.Value ?? "No description";

            Console.WriteLine($"📰 {title}");
            Console.WriteLine($"🔗 {link}\n");
            Console.WriteLine($"{description}\n");
            Console.WriteLine(new string('-', 50));

            count++;
            if (count >= maxNumberOfFeeds) break;
        }

        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error fetching RSS feed: {ex.Message}");
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}