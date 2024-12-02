using System;

public class Video
{
    public string _videoTitle = "";
    public string _videoCreator = "";
    public int _videoLength = 0;

    public List<Comment> _commentInfo = new List<Comment>();

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Creator: {_videoCreator}");
        Console.WriteLine($"VideoLength: {_videoLength}seconds");
        Console.WriteLine($"Comments: ");

        foreach (Comment comment in _commentInfo)
        {
            comment.DisplayComment();
        }
    }
}
