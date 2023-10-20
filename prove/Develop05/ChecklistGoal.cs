using System;
public class ChecklistGoal : Goal {
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
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
        
    }
     public override bool IsComplete() {
        return false;
    }
    public override void SetComplete(bool value) {
        
    }
    // public override string GetDetailsString() {
        
    // }
    public override string GetStringRepresentation() {
        return $"ChecklistGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {GetAmountCompleted()}, {GetTarget()}, {GetBonus()}";
    }
}