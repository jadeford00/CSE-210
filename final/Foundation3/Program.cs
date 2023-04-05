using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St.", "Rexburg", "ID", "83440");
        Address address2 = new Address("456 1st St.", "Idaho Falls", "ID", "83401");
        Address address3 = new Address("789 1St Ave.", "Sugar City", "ID", "83448");

        Event event1 = new Lecture("Programming with Classes", "Leaning the basics of Abstraction.",new DateTime(2023, 4, 3), "1:00pm", address1, "Brother Manly", "45");
        Event event2 = new Reception("Mr. and Mrs.'s Wedding", "Join us oon this joyous day!", new DateTime(2023, 1, 8), "7:00pm", address2, "RSVP@byui.edu");
        Event event3 = new Outdoorgathering("Picnic", "Enjoy some food in the park!", new DateTime(2023, 7, 4), "2:00pm", address3, "Sunshine all day long");

        Console.WriteLine("Event 1 - Lecture");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Event 2 - Reception");
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine(event2.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Event 3 - OutdoorGathering");
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine(event3.GetShortDescription());
        Console.WriteLine();
    }
}