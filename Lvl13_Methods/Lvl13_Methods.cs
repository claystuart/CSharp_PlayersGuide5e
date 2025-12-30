// Description: Two Challenges
// 1: Taking a Number (p106) - Implement two (2) methods that display a prompt, read in a number (as string), and return an int
// 2: Countdown (p107) - Use recursion to count down from 10 to 1


TakeNumber();
Countdown();

// Recursive countdown from 10 to 1
int Countdown(int number = 10)
{
    Console.WriteLine(number);

    if (number == 1)
        return 0;
    else
        return Countdown(number - 1);
}

void TakeNumber()
{
    int? age = AskForNumber("What is your age? ");
    if (age is not null)
        Console.WriteLine($"You are {age} years old.");

    int? number = AskForNumberInRange("Pick a number between 1 and 100: ", 1, 100);
    if (number is not null)
        Console.WriteLine($"The number {number} was in the range");
}

// Helper method for TakeNumber() challenge
int? AskForNumberInRange(string prompt, int low, int high)
{
    Console.Write(prompt);
    string input = Console.ReadLine()!;
    bool success = int.TryParse(input, out int number);
    if (success && number >= low && number <= high)
        return number;

    else return null;
}

// Helper method for TakeNumber() challenge
int? AskForNumber(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine()!;
    bool success = int.TryParse(input, out int number);
    if (success)
        return number;
    else
        return null;
}