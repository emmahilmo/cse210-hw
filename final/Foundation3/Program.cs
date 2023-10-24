using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events1 = new List<Event>();
        Address address1 = new Address("4123 W 1700 N", "Salem", "Oregan", "US");
        Lecture lecture1 = new Lecture("Gloria's Lecture on Technology", "Gloria will be presenting her findings on how technology effects our brains and the benefits.", "10/28/2023", "3:00pm", address1, "Gloria", 120);
        events1.Add(lecture1);

        List<Event> events2 = new List<Event>();
        Address address2 = new Address("91 E 300 S", "Helena", "Montana","US");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Mike's Barbaque", "Come and have fun at the ward barbaque!", "11/13/2023", "5:00pm", address2, "Clear");
        events2.Add(outdoorGathering1);

        List<Event> events3 = new List<Event>();
        Address address3 = new Address ("800 W 415 S", "Salt Lake City", "Utah", "US");
        Reception reception1 = new Reception("Fanny and Cole's Wedding Reception", "Franny and Cole hope you join us for their wedding celebration and reception.", "12/20/2023", "12:00pm", address3, "800-777-7721");
        events3.Add(reception1);
    }
    static private string StandardDetails(List<Event> events) {
        string text = "";
        for (int i = 0; i < events.Count; i++)
        {
            text += events[i].GetTitle() + events[i].GetDescription() + events[i].GetDate() + events[i].GetTime() + events[i].GetAddress();
        }
        return text;
    }
    static private string FullDetails(List<Event> events) {
        string text = "";
        for (int i = 0; i < events.Count; i++)
        {
            text += events[i].GetTitle() + events[i].GetDescription() + events[i].GetDate() + events[i].GetTime() + events[i].GetAddress();
        }
        return text;
    }
}