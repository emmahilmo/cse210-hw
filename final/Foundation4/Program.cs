using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("Nov 03 2023", 30, 3);
        activities.Add(running);

        Cycling cycling = new Cycling("Nov 05 2023", 30, 6);
        activities.Add(cycling);

        Swimming swimming = new Swimming("Nov 07 2023", 30, 10);
        activities.Add(swimming);
        

        foreach(Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        
        }
    }
}