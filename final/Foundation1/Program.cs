using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _video = new List<Video>();

        foreach(Video video in _video) {

            video.Display();
        }

        Comments comments1 = new Comments();
        comments1._name = "John12";
        comments1._text = "I love your videos";

        Comments comments2 = new Comments();
        comments2._name = "Fredrickson37";
        comments2. _text = "Please make more!!";

        Comments comments3 = new Comments();
        comments3._name = "Level29000";
        comments3._text = "Keep making videos! We love them!";

        Video video1 = new Video();
        video1._title = "How to make a bird in oragami";
        video1._author = "OragamiTutorials";
        video1._length = 290;

        video1._comments.Add(comments1);
        video1._comments.Add(comments2);
        video1._comments.Add(comments3);
        _video.Add(video1);

        Comments comments4 = new Comments();
        comments4._name = "HorseLover12";
        comments4._text = "Thank you!";

        Comments comments5 = new Comments();
        comments5._name = "Hope13";
        comments5._text = "I needed this tutorial";

        Comments comments6 = new Comments();
        comments6._name = "friendship24";
        comments6._text = "10/10 art";

        Comments comments7 = new Comments();
        comments7._name = "Caleb";
        comments7._text = "<3";

        Video video2 = new Video();
        video2._title = "How to Draw a Dog";
        video2._author = "DrawingTutorials";
        video2._length = 150;

        video2._comments.Add(comments4);
        video2._comments.Add(comments5);
        video2._comments.Add(comments6);
        video2._comments.Add(comments7);
        _video.Add(video2);

        Comments comments8 = new Comments();
        comments8._name = "Pandagirll14";
        comments8._text = "Your house is sooooo cooool! Thank you for sharing!";

        Comments comments9 = new Comments();
        comments9._name = "francisandfriends";
        comments9._text = "Keep making videos I want to see more!";

        Comments comments10 = new Comments();
        comments10._name = "JeanGray1234";
        comments10._text = "Nice.";

        Video video3 = new Video();
        video3._title = "House Tour!";
        video3._author = "VloggerFamily";
        video3._length = 945;

        video3._comments.Add(comments8);
        video3._comments.Add(comments9);
        video3._comments.Add(comments10);
        _video.Add(video3);
        
        video1.Display();
        video2.Display();
        video3.Display();
    }
}