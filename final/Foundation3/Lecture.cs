using System;
public class Lecture : Event {
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
        _capacity = capacity;
        _speaker = speaker;
    }
    public int GetCapacity() {
        return _capacity;
    }
    public string GetSpeaker() {
        return $"Speaker: {_speaker}";
    }
}