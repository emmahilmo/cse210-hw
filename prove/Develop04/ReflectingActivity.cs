using System;
public class ReflectingActivity : Activity {
    private List<string> _questions;
    private List<string> _prompts;
    public ReflectingActivity(string name, string description, int duration, string questions, string prompts) : base(name, description, duration){
    }

}