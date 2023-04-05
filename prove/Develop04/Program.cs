using System;
using System.Threading;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the meditation program! ");
//         Console.WriteLine("How many miinutes would you like to meditate for? ");
//         int minutes = int.Parse(Console.ReadLine());

//         int milliseconds = minutes * 60 * 1000;
//         DateTime end =  DateTime.Now + new TimeSpan(0, 0, 0, 0, milliseconds);

//         MeditationProgram meditationProgram = new MeditationProgram();

//         while (DateTime.Now < end)
//         {
//             Console.Clear();
//             Console.WriteLine("Choose an activity: ");
//             Console.WriteLine("1. Breathing Activity");
//             Console.WriteLine("3 Listing Activity");
//             Console.WriteLine("4. Quit");

//             int activity = int.Parse(Console.ReadLine());

//             switch (activity)
//             {
//                 case 1: 
//                     meditationProgram.Breathe();
//                     break;
//                 case 2: 
//                     Console.WriteLine("Think of a time when you were successful or demonstrated strength.");
//                     Thread.Sleep(5000);
//                     Console.WriteLine("How are you different because of that experience? ");
//                     Thread.Sleep(5000);
//                     Console.WriteLine("What can you do to have more of those experiences? ");
//                     Thread.Sleep(5000);
//                     break;
//                 case 3:
//                     Console.WriteLine("List as many things as you can in a certain area of strength or positivity.");
//                     Thread.Sleep(8000);
//                     Console.WriteLine("List as many things as yoou can in a certain area of strength or positvity. ");
//                     Thread.Sleep(8000);
//                     Console.WriteLine("List as many things as you can on what you are doing that you should stop doing.");
//                     Thread.Sleep(8000);
//                     break;
//                 case 4:
//                     Console.WriteLine("Thank you for meditating with us!");
//                     Console.ReadKey();
//                     return;
//                 default:
//                     Console.WriteLine("Invalid option selected. Please choose again.");
//                     break;
//             }

//             meditationProgram.Quote();
//             Console.WriteLine("Press any key to continue...");
//             Console.ReadKey();
//         }

//         Console.WriteLine("Meditation program ended. Press any key to exit.");
//         Console.ReadKey();
//     }

// }

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the meditation program!");
        Console.WriteLine("How many minutes would you like to meditate for?");
        int minutes = int.Parse(Console.ReadLine());

        int milliseconds = minutes * 60 * 1000;
        DateTime end = DateTime.Now + new TimeSpan(0, 0, 0, 0, milliseconds);

        Breathe meditationProgram = new Breathe();

        while (DateTime.Now < end)
        {
            meditationProgram.Breathe();
            meditationProgram.Quote();
            Thread.Sleep(1000);
        }

        Console.WriteLine("Meditation program ended. Press any key to exit...");
        Console.ReadKey();
    }
}