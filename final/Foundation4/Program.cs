using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity activity1 = new Activity(10, 6, "03 Nov 2022", 30, 3);
        // Cycling cycling
        Running running1 = new Running(10, 6, "03 Nov 2022", 30, 3);
        // Console.WriteLine(running1.GetPace());
        // Console.WriteLine(running1.GetSpeed());
        // Console.WriteLine(running1.GetActivityDate());
        // Console.WriteLine(running1.GetDistance());
        // Console.WriteLine(running1.GetMinutes());
        Console.WriteLine(running1.GetSummary());

        Cycling cycling1 = new Cycling(6.9, 9.7, "03 Nov 2022", 30, 4.8);
        Console.WriteLine(cycling1.GetSummary());

        Swimming swimming1 = new Swimming(8, 8, "03 Nov 2022", 30, 5, 20);
        Console.WriteLine(swimming1.GetSummary());





    //    List<Activity> activities = new List<Activity>();

    //    activities.Add(new Running(new DateTime(202, 11, 3), 30,3));
    //    activities.Add(new Cycling(new DateTime(2023, 11, 3), 30, 12));
    //    activities.Add(new Swimming(new DateTime(2023, 11, 3), 30, 50));

    //    foreach (Activity activity in activities)
    //    {
    //     Console.WriteLine(activity.GetSummary());
    //    }
    }
}