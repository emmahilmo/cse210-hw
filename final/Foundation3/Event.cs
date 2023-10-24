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
    public string GetDate() {
        return _date;
    }
    public string GetDetails() {
        return $"Event: {_eventTitle} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n {_address.GetAddress()}";
    }
    public virtual string GetFullDetails() {
        return "";
    }
    public virtual string ShortDetails() {
        return "";
    }

}