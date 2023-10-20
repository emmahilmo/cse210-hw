using System;
public class EternalGoal : Goal {
    public EternalGoal(string name, string description, int points) : base(name, description, points) {
    }
    public override void RecordEvent() {
        
    }
     public override bool IsComplete()
    {
        return false;
    }
    public override void SetComplete(bool value) {
        
    }
    public override string GetStringRepresentation() {
        return $"EternalGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
    }
}