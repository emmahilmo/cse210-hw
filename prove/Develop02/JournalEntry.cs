public class Journal
{
   public string _date;
   public string _promptText;
   public string _entryText;
   public void Display()
   {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
   }
   
}