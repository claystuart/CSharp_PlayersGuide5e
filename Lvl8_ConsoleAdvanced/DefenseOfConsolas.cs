// Description: Demonstrate a number of Advanced Console Methods - page 68
// Consolas is 8x8 grid

Console.Title = "Defense of Consolas";
int row, col;
string input;

Console.Write("Target Row? ");
input = Console.ReadLine()!;
row = Convert.ToInt32(input);

Console.Write("Target Column? ");
input = Console.ReadLine()!;
col = Convert.ToInt32(input);

Console.ForegroundColor = ConsoleColor.Green;
if (OperatingSystem.IsWindows())
    Console.Beep();
Console.WriteLine("Deploy to:");
Console.WriteLine($"({row},{col - 1})");
Console.WriteLine($"({row - 1},{col})");
Console.WriteLine($"({row},{col + 1})");
Console.WriteLine($"({row + 1},{col})");
Console.ForegroundColor = ConsoleColor.White;


