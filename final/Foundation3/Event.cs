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
        return $"Event: {_eventTitle} \n";
    }
    public string GetDescription() {
        return $"Description: {_description} \n";
    }
    public string GetDate() {
        return $"Date: {_date} \n";
    }
    public string GetTime() {
        return $"Time: {_time} \n";
    }
    public string GetAddress() {
        return _address.GetAddress();
    }

}