// Description: Hunting the Manticore pp(124-125) upgraded with "The Robot Pilot" expansion challenge on (p249).

// Initialize
Console.Title = "Hunting the Manticore";
Console.Clear();
int city_hp = 15;
Manticore manticore = new();

Console.WriteLine($"Cheat: Manticore at distance {manticore.Range}");

// Update
for (int round = 1; manticore.HP > 0; round++)
{
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} City: {city_hp}/15  Manticore: {manticore.HP}/10");
    Console.WriteLine($"The cannon is expected to deal {cannon_damage(round)} this round.");
    Console.Write("Enter desired cannon range: ");
    string input = Console.ReadLine()!;
    bool valid_input = int.TryParse(input, out int shot_range);
    if (valid_input)
    {
        bool manticore_hit = check_shot(shot_range, manticore.Range);
        if (manticore_hit)
            manticore.HP -= cannon_damage(round);
    }

    // If manticore is still alive, reduce city HP by 1
    if (manticore.HP > 0)
        city_hp--;

    if (city_hp <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The City has been destroyed!");
        Console.WriteLine("Game Over!");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }    
    if (manticore.HP <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        Console.WriteLine("Game Over!");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }    
}

// Check shot to see if it hit manticore - returns answer in Hi-Lo format
bool check_shot(int shot_range, int manticore_range)
{
    if (shot_range > manticore_range)
    {
        Console.WriteLine("That round OVERSHOT the target");
        return false;
    }
    else if (shot_range < manticore_range)
    {
        Console.WriteLine("That round FELL SHORT of the target");
        return false;
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        return true;
    }
}

// Calculate damage done to manticore based on round - calculates in modified Fizz-Buzz format
int cannon_damage(int round)
{
    if (round % 15 == 0)
        return 10;
    else if (round % 5 == 0 || round % 3 == 0)
        return 3;
    else
        return 1;
}



/// <summary>
/// Manticore enemy class
/// </summary>
class Manticore
{
    public int HP { get; set; } = 10;
    public int Range { get; set; }

    public Manticore()
    {
        Random rand = new();
        Range = rand.Next(15, 31); // Manticore starts 15-30 steps away from city
    }
}

