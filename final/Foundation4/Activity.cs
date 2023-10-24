using System;
public class Activity {
    public string _date;
    public float _length;
    public Activity(string date, float length) {
        _date = date;
        _length = length;
    }
    public string GetDate() {
        return _date;
    }
    public float GetLength() {
        return _length;
    }
    public virtual float GetDistance() {
        return 0;
    }
    public virtual float GetPace() {
        return 0;
    }
    public virtual float GetSpeed() {
        return 0;
    }
    public virtual string GetSummary() {
        return $"{GetDate()} {GetLength()} - {GetDistance()}, {GetSpeed()}, {GetPace()}";
    }
}