using System;
public class ReflectingActivity : Activity {
    private List<string> _questions;
    private List<string> _prompts;
    public ReflectingActivity(string name, string description, int duration, List<string> questions, List<string> prompts) : base(name, description, duration){
        _questions = questions;
        _prompts = prompts;
    }

}