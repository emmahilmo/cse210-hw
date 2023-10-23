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

    }
}