using System;
public class ReflectingActivity : Activity {
    private List<string> _questions;
    private List<string> _prompts;
    public ReflectingActivity(string name, string description, int duration, List<string> questions, List<string> prompts) : base(name, description, duration){
        _questions = questions;
        _prompts = prompts;
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
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

         Random randomGenerator = new Random();
         int index = randomGenerator.Next(_questions.Count);

         return _questions[index];
    }
}