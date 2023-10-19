using System;
public class ReflectingActivity : Activity {
    private List<string> _questions;
    private List<string> _prompts;
    public ReflectingActivity(string name, string description) : base(name, description) {
    }
    private string GetRandomPrompt() {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

         Random randomGenerator = new Random();
         int index = randomGenerator.Next(_prompts.Count);

         return _prompts[index];
    }
    private string GetRandomQuestions() {
        _questions.Add("> Why was this experience meaningful to you?");
        _questions.Add("> Have you ever done anything like this before?");
        _questions.Add("> How did you get started?");
        _questions.Add("> How did you feel when it was complete?");
        _questions.Add("> What made this time different than other times when you were not as successful?");
        _questions.Add("> What is your favorite thing about this experience?");
        _questions.Add("> What could you learn from this experience that applies to other situations?");
        _questions.Add("> What did you learn about yourself through this experience?");
        _questions.Add("> How can you keep this experience in mind in the future?");

         Random randomGenerator = new Random();
         int index = randomGenerator.Next(_questions.Count);

         return _questions[index];
    }
    public void DisplayPrompt() {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }
    public void DisplayQuestion() {
        Console.Clear();

        int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while(DateTime.Now < futureTime) {
            GetRandomQuestions();
            Pause();
        }
    }
    public void Run() {
        DisplayStartingMessage();
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine($"Get Ready...");
        Pause();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        if (Console.ReadKey().Key == ConsoleKey.Enter) {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine($"You may begin in: ");
            ShowCountDown(5);
            DisplayQuestion();
        }
        DisplayEndingMessage();
    }
}