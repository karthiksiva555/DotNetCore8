namespace CSharpEssentials.AnonymousMethods;

public class YouTubeChannel (string channelName, string channelId)
{
    public string ChannelName { get; set; } = channelName;
    
    public string ChannelId { get; set; } = channelId;
    
    public delegate void VideoPublished(string title, string videoUrl);
    
    public event VideoPublished? NewVideoPublishedEvent;

    public void PublishVideo(string videoName, string videoUrl)
    {
        NewVideoPublishedEvent?.Invoke(videoName, videoUrl);
    }
}