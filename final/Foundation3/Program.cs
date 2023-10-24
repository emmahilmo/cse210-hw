using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Address address1 = new Address("4123 W 1700 N", "Salem", "Oregon", "US");
        Lecture lecture = new Lecture("Gloria's Lecture on Technology", "Gloria will be presenting her findings on how technology effects our brains and the benefits.", "10/28/2023", "3:00pm", address1, "Gloria", 120);
        events.Add(lecture);
        
        Address address2 = new Address("91 E 300 S", "Helena", "Montana","US");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Mike's Barbeque", "Come and have fun at the ward barbeque!", "11/13/2023", "5:00pm", address2, "Clear");
        events.Add(outdoorGathering);

        Address address3 = new Address ("800 W 415 S", "Salt Lake City", "Utah", "US");
        Reception reception = new Reception("Fanny and Cole's Wedding Reception", "Franny and Cole hope you join us for their wedding celebration and reception.", "12/20/2023", "12:00pm", address3, "800-777-7721");
        events.Add(reception);

        foreach(Event item in events) {
            Console.WriteLine(item.GetDetails() + "\n");
            Console.WriteLine(item.GetFullDetails() + "\n");
            Console.WriteLine(item.ShortDetails() + "\n");
        }
        
    }
}