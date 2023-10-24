public class Swimming : Activity {
    private float _numOfLaps;
    public Swimming(string date, float length, float laps) : base(date, length) {
        _numOfLaps = laps;
    }
    public override float GetDistance() {
        return _numOfLaps*50/1000;
    }
    public override float GetPace() {
        return _length/(_numOfLaps*50/1000);
    }
    public override float GetSpeed() {
        return _numOfLaps*50/1000/_length*60;
    }
    public override string GetSummary() {
        return $"{GetDate()} Swimming ({GetLength()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}