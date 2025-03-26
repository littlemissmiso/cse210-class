using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> _allVideos = new List<Video>();

        //Video 1
        Video v1 = new Video();
        v1._author = "Sass A. Frass";
        v1._title = "The Startling Art of Wildflowers";
        v1._videoLength = 17;
        
        Comment c1 = new Comment();
        c1._commenterName = "@Hoping4Heaven123";
        c1._commentText = "Beautiful! Makes me want to frolic.";

        Comment c2 = new Comment();
        c2._commenterName = "@open_to_suggestions";
        c2._commentText = "Eh, I could do better.";

        Comment c3 = new Comment();
        c3._commenterName = "@FleurEnthusiast";
        c3._commentText = "@SassA.Frass Love the tribute to the unique beauty that is wildflowers!";

        v1._comments.Add(c1);
        v1._comments.Add(c2);
        v1._comments.Add(c3);

        _allVideos.Add(v1);

        //Video 2
        Video v2 = new Video();
        v2._author = "Al E. Bama";
        v2._title = "Banjo Ballads for the Modern Country Man";
        v2._videoLength = 48;
        
        Comment c4 = new Comment();
        c4._commenterName = "@I_love_my_cows";
        c4._commentText = "Mooove over country music stars, there's a new album about to make platinum!";

        Comment c5 = new Comment();
        c5._commenterName = "@WideOpenSpaces";
        c5._commentText = "Hit this old guy right in the feels. Beautifully haunting.";

        Comment c6 = new Comment();
        c6._commenterName = "@cowgirl4LIFE9845354";
        c6._commentText = "What a man. These songs were sure heartfelt.";

        v2._comments.Add(c4);
        v2._comments.Add(c5);
        v2._comments.Add(c6);

        _allVideos.Add(v2);

        //Video 3
        Video v3 = new Video();
        v3._author = "Catastrophe_Catsup";
        v3._title = "Watch me drink TEN GALLONS of ketchup in 30 MINUTES";
        v3._videoLength = 40;
        
        Comment c7 = new Comment();
        c7._commenterName = "@groovy-foodie";
        c7._commentText = "Dude.... u crazy bro.";

        Comment c8 = new Comment();
        c8._commenterName = "@HeinzCompany";
        c8._commentText = "We do not endorse or sponser this kind of reckless behavior. Consume our delicious products responsibly.";

        Comment c9 = new Comment();
        c9._commenterName = "@NopeRopes";
        c9._commentText = "Grossssss. But I can't look away....";

        Comment c10 = new Comment();
        c10._commenterName = "@NeverSatisfied79";
        c10._commentText = "Bet you can't do 15 gallons. 10 is way too easy.";

        v3._comments.Add(c7);
        v3._comments.Add(c8);
        v3._comments.Add(c9);
        v3._comments.Add(c10);

        _allVideos.Add(v3);

        foreach (var entry in _allVideos)
        {
            entry.DisplayVideo();
        }

        
    }
}