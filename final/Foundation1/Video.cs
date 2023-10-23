using System;
public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comments>_comments = new List<Comments>();
    
    public void Display() {
        Console.WriteLine($"{_title} - {_author} - {_length} seconds");
        Console.WriteLine($"Comment Section: {_comments}");

        foreach(Comments comments in _comments) {
            comments.Display();
        }
    }
}