using System;

class Program
{
static void Main(string[] args)
{   // This sections is for parts 1 and 2 of the assignment. 

    // Console.Write("What is the magic number? ");
    // string number = Console.ReadLine();
    // int answerOne = int.Parse(number);

    // Console.Write("What is your guess? ");
    // string guess = Console.ReadLine();
    // int answerTwo = int.Parse(guess);


    Random randomGenerator = new Random();
    int answerOne = randomGenerator.Next(1, 101);

    int guess = -1;

    while (guess != answerOne);

        if (answerOne > guess)
        {
            Console.WriteLine("Lower");
        }
        else if (answerOne < guess)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        // Console.WriteLine($"{guess}");

    }
}