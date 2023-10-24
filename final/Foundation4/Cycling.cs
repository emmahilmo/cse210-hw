public class Cycling : Activity {
    private float _speed;
    public Cycling(string date, float length, float speed) : base(date, length) {
        _speed = speed;
    }
    public override float GetDistance() {
        return _speed*_length;
    }
    public override float GetPace() {
        return 60/_speed;
    }
    public override float GetSpeed() {
        return _speed;
    }
    public override string GetSummary() {
        return $"{GetDate()} Cycling ({GetLength()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}