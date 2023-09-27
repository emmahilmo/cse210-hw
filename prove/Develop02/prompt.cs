public class Prompt
{
    public List<string> _prompt;
    public string GetRandomPrompt()
    {
        _prompt.Add("Who was the most interesting person I interacted with today?");
        _prompt.Add("What was the best part of my day?");
        _prompt.Add("How did I see the hand of the Lord in my life today?");
        _prompt.Add("What was the strongest emotion I felt today?");
        _prompt.Add("If I had one thing I could do over today, what would it be?");

         Random randomGenerator = new Random();
         int index = randomGenerator.Next(_prompt.Count);

         return _prompt[index];
    }
}