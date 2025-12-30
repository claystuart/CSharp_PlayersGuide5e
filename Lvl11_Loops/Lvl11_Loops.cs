// Description: Implement "The Prototype" (p89): A Hi-Lo game
// Description: Implement "The Magic Cannon" (p89): A Fizz-Buzz variant

//Prototype();
MagicCannon();

// Hi-Lo: 0-100
static void Prototype()
{
    Random rand = new(); //generate random numbers (p248)
    int answer = rand.Next(0, 101);
    Console.WriteLine("Guess the answer between 0 and 100");

    while (true)
    {
        Console.Write("Enter guess: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int guess))
        {
            if (guess == answer)
            {
                Console.WriteLine($"You guessed the number: {answer}");
                break; // break from while loop and end program
            }
            else if (guess > answer)
                Console.WriteLine("Too High");
            else if (guess < answer)
                Console.WriteLine("Too Low");
        }
        else
            Console.WriteLine("Bad guess");
    }
}

// Fizz-Buzz (1-100)
static void MagicCannon()
{
    for (int x = 1; x <= 100; x++)
    {
        Console.ForegroundColor = ConsoleColor.White; // Reset ConsoleColor to White
        if (x % 15 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{x}: Electric and Fire");
        }
        else if (x % 3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{x}: Fire");
        }
        else if (x % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{x}: Electric");
        }
        else
        {
            Console.WriteLine($"{x}: Normal");
        }
    }
}