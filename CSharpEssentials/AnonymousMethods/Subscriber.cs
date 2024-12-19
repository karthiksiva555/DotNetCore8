namespace CSharpEssentials.AnonymousMethods;

public class Subscriber(string name)
{
    public string Name { get; set; } = name;

    public void NewVideoPublished(string title, string videoUrl)
    {
        Console.WriteLine($"Subscriber received the new video {title} at {videoUrl}");
    }
}