using System;
public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(int score) {
        _score = score;
    }
    public int GetScore() {
        return _score;
    }
    public void SetScore(int score) {
        _score += score;
    }
    public List<Goal> GetList() {
        return _goals;
    }
    public void SetList(Goal goal) {
        _goals.Add(goal);
    }
    // public void start() {

    // }
    // public void DisplayPlayerInfo() {

    // }
    // public void ListGoalNames() {

        // foreach(Goal goal in _goals) {
            // Console.WriteLine($"{_goals.IndexOf(goal)}. {goal.GetName()}");
    // }
    public void ListGoalDetails() {
        Console.WriteLine($"Your goals are: ");

        foreach(Goal goal in _goals) {
            Console.WriteLine($"{_goals.IndexOf(goal)}. {goal.GetDescription()}");
        }
    }
    public void CreateGoal() {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int selection = int.Parse(Console.ReadLine());
        switch(selection) {
            case 1: {
                Console.WriteLine("You have selected a Simple Goal.");
                Console.Write("What would you like to name your goal? ");
                string name = Console.ReadLine();
                Console.Write("Please write a short description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("How many points would you like to give this goal? ");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                SetList(simpleGoal);
                break;
            }
            case 2: {
                Console.WriteLine("You have selected an Eternal Goal.");
                Console.Write("What would you like to name your goal? ");
                string name = Console.ReadLine();
                Console.Write("Please write a short description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("How many points would you like to give this goal? ");
                int points = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                SetList(eternalGoal);
                break;
            }
            case 3: {
                Console.WriteLine("You have selected a Checklist Goal.");
                Console.Write("What would you like to name your goal? ");
                string name = Console.ReadLine();
                Console.Write("Please write a short description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("How many points would you like to give this goal? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("What bonus would you like to add? ");
                int bonus = int.Parse(Console.ReadLine());
                Console.Write("How many time would you like to complete this goal? ");
                int target = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, target);
                SetList(checklistGoal);
                break;
            }
        }
    }
    public void RecordEvent() {
        Console.WriteLine("The goals are: ");

        foreach(Goal goal in _goals) {
            Console.WriteLine($"{_goals.IndexOf(goal)}. {goal.GetName()}");
        }
        Console.WriteLine("Which goal did you complete? ");
        int selection = int.Parse(Console.ReadLine());
    }
    public void SaveGoals(string file) {
        Console.WriteLine("What is the name of the file?");
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetScore());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals() {
        _goals.Clear();
        string filename = file;
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        foreach(string line in lines.Skip(1)) {
            string[] parts = line.Split(",");
            
            switch(parts[0]) {
                case "SimpleGoal": {

                    break;
                }
                case "EternalGoal": {

                    break;
                }
                case "ChecklistGoal": {

                    break;
                }
            }
        }   
    }
}   