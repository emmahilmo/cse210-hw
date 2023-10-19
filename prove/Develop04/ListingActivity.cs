using System;
public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration) {
        _count = count;
        _prompts = prompts;
    }
    private string GetRandomPrompt() {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

         Random randomGenerator = new Random();
         int index = randomGenerator.Next(_prompts.Count);

         return _prompts[index];
    }
    private List<string> GetListFromUser() {
        List<string> userList = new List<string>();
        int seconds = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);  
        while(DateTime.Now < futureTime) {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }
        return userList;
    }
    public void Run() {
        DisplayStartingMessage();
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        Pause();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine($"You may begin in: ");
        ShowCountDown(5);
        _count = GetListFromUser().Count;
        Console.WriteLine($"You have listed {_count} items!");
        Pause();
        DisplayEndingMessage();
    }
}