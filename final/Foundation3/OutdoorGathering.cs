using System;
public class OutdoorGathering : Event {
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address) {
        _weather = weather;
    }
    public string GetWeather() {
        return _weather;
    }
}