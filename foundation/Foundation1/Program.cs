using System;

class Program
{
    static void Main(string[] args)
    {
        Comment _commentInfo = new Comment();
        Video _videoInfo = new Video();

        _videoInfo._videoTitle = "Short reels to kill time";
        _videoInfo._videoCreator = "MrBeast";
        _videoInfo._videoLength = 50;
        _videoInfo._commentInfo.Add(_commentInfo);

        _commentInfo._commenter = "Jon McCall";
        _commentInfo._comment = "I love to look at reels";

        Comment _commentInfo2 = new Comment();

        _commentInfo2._commenter = "Bad_BoyZ";
        _commentInfo2._comment = "This is a bad video!! :(";

        _videoInfo._commentInfo.Add(_commentInfo2);
        _videoInfo.DisplayVideo();

        Video _videoInfo2 = new Video();
        Comment _commentInfo3 = new Comment();

        _videoInfo2._videoTitle = "Learn CSS";
        _videoInfo2._videoCreator = "Simplified";
        _videoInfo2._videoLength = 350;
        _videoInfo2._commentInfo.Add(_commentInfo3);
        _videoInfo2.DisplayVideo();

        _commentInfo3._commenter = "Bad_BoyZ";
        _commentInfo3._comment = "This is a bad video!! :(";

        Comment _commentInfo4 = new Comment();
        _commentInfo4._commenter = "Bad_BoyZ";
        _commentInfo4._comment = "This is a bad video!! :(";

        Comment _commentInfo5 = new Comment();
        Video _videoInfo3 = new Video();

        _videoInfo3._videoTitle = "Short reels to kill time";
        _videoInfo3._videoCreator = "MrBeast";
        _videoInfo3._videoLength = 50;
        _videoInfo3._commentInfo.Add(_commentInfo5);

        _commentInfo5._commenter = "Jon McCall";
        _commentInfo5._comment = "I love to look at reels";

        Comment _commentInfo6 = new Comment();

        _commentInfo6._commenter = "Bad_BoyZ";
        _commentInfo6._comment = "This is a bad video!! :(";

        _videoInfo3._commentInfo.Add(_commentInfo6);
        _videoInfo3.DisplayVideo();

        Comment _commentInfo7 = new Comment();
        Video _videoInfo4 = new Video();

        _videoInfo4._videoTitle = "Short reels to kill time";
        _videoInfo4._videoCreator = "MrBeast";
        _videoInfo4._videoLength = 50;
        _videoInfo4._commentInfo.Add(_commentInfo7);

        _commentInfo7._commenter = "Jon McCall";
        _commentInfo7._comment = "I love to look at reels";

        Comment _commentInfo8 = new Comment();

        _commentInfo8._commenter = "Bad_BoyZ";
        _commentInfo8._comment = "This is a bad video!! :(";

        _videoInfo4._commentInfo.Add(_commentInfo8);
        _videoInfo4.DisplayVideo();
    }
}
