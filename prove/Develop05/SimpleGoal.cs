using System;
public class SimpleGoal : Goal {
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points) {
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return IsComplete();
    }
    public override void SetComplete(bool value) {
        _isComplete = value;
    }
    public override string GetStringRepresentation() {
        return $"Simple Goal, {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
    }
}