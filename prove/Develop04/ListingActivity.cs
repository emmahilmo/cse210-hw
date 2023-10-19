using System;
public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description) {
    }
    private void GetRandomPrompt() {
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(_prompts.Count);
        string prompt = _prompts[randomPrompt];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine($"You may begin in: ");
        ShowCountDown(5);

    }
    public void SetPrompts() {
        string prompt1 = "Who are people that you appreciate?";
        string prompt2 = "What are personal strengths of yours?";
        string prompt3 = "Who are people that you have helped this week?";
        string prompt4 = "When have you felt the Holy Ghost this month?";
        string prompt5 = "Who are some of your personal heroes?";

        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);
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
        SetPrompts();
        GetRandomPrompt();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You have listed {_count} items!");
        Pause();
        DisplayEndingMessage();
    }
}