using System;
public class Reception : Event {
    public string _RSVP;
    public Reception(string title, string description, string date, string time, Address address, string RSVP) : base(title, description, date, time, address) {
        _RSVP = RSVP;
    }
    public string GetRSVP() {
        return $"RSVP at this number: {_RSVP}";
    }
}