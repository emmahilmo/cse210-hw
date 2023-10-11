using System;
public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }
    public Activity(string name, string description, int duration) {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public int GetDuration() {
        return _duration;
    }
    public void SetDuration(int seconds) {
        _duration = seconds;
    }
    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"How long (in seconds) would you like your session to be?");
    }
    public void DisplayEndingMessage() {
        Console.WriteLine($"Well done!");
        Pause();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds) {
        while (seconds != 0) {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            seconds -= -1;
        }
    }
    public void ShowCountDown(int seconds) {
        while(seconds != 0) {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            seconds -= -1;
        }
    }
    public void Pause() {
        ShowSpinner(5);
    }
}