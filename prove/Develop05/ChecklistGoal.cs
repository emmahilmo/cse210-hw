using System;
public class ChecklistGoal : Goal {
    private int _target;
    private int _bonus;
    private int _amountCompleted = 0;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) {
        _target = target;
        _bonus = bonus;
    }
    public int GetAmountCompleted() {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted) {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget() {
        return _target;
    }
    public void SetTarget(int target) {
        _target = target;
    }
    public int GetBonus() {
        return _bonus;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }
    public override void RecordEvent() {
        _amountCompleted += 1;

        if (IsComplete() == true) {
            
            int bonus = GetPoints() + _bonus;       
        }
    }
     public override bool IsComplete() {
        
        if (_amountCompleted == _target) {
            return true;
        }
        else {return false;}
    }
    public override void SetComplete(bool value) {
        _amountCompleted = 0;
    }
    public override string GetStringDetails() {
        string status = "[ ]";

        if (IsComplete() == true)
        {
            status = "[X]";
        }
        
        return $"{status} {GetName()} ({GetDescription()} -- Currently completed: {GetAmountCompleted()}/{GetTarget()})";
    }
    public override string GetStringRepresentation() {
        return $"ChecklistGoal, {GetName()}, {GetDescription()}, {GetPoints()}, {GetAmountCompleted()}, {GetTarget()}, {GetBonus()}";
    }
}