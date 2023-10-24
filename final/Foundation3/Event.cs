using System;
public class Event {
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    Address _address;
    public Event(string title, string description, string date, string time, Address address) {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetTitle() {
        return _eventTitle;
    }
    public string GetDescription() {
        return _description;
    }
    public string GetDate() {
        return _date;
    }
    public string GetTime() {
        return _time;
    }
    public string GetAddress() {
        return _address.GetAddress();
    }

}