// Description: Implement both Clocktower (p75) and Watchtower (p78) challenges from Chapter 9

//Clocktower();
Watchtower();

void Watchtower()
{
    Console.Write("Enter enemy x and y (e.g. 3,4) coordinates: ");
    string input = Console.ReadLine()!;
    string[] coordinates = input.Split(',');
    
    // Check X input
    bool valid_x = int.TryParse(coordinates[0], out int x);
    if (!valid_x)
    {
        Console.WriteLine("Bad X input");
        System.Environment.Exit(1);
    }

    // Check Y input
    bool valid_y = int.TryParse(coordinates[1], out int y);
    if (!valid_y)
    {
        Console.WriteLine("Bad Y input");
        System.Environment.Exit(2);
    }

    string msg = "";

    // Top Row
    if (x < 0 && y > 0)
        msg = "to the northwest";
    else if (x == 0 && y > 0)
        msg = "to the north";
    else if (x > 0 && y > 0)
        msg = "to the northeast";
    // Middle Row
    else if (x < 0 && y == 0)
        msg = "to the west";
    else if (x == 0 && y == 0)
        msg = "here";
    else if (x > 0 && y == 0)
        msg = "to the east";
    // Bottom Row
    else if (x < 0 && y < 0)
        msg = "to the northwest";
    else if (x == 0 && y < 0)
        msg = "south";
    else if (x > 0 && y < 0)
        msg = "to the southeast";

    Console.WriteLine($"The enemy is {msg}");

}

static void Clocktower()
{
    Console.Write("Enter integer: ");
    string input = Console.ReadLine()!;
    bool valid_input = int.TryParse(input, out int number);
    if (valid_input)
        if (number % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    else
        Console.WriteLine("Invalid input");
}