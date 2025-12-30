// Description: Simula's Test (p135) - Simulate an open/closed/locked/unlocked treasure chest using enums to track state.

Chest chest = Chest.Locked;
while (true)
{
    Console.Write($"The chest is {Enum.GetName(chest)!.ToLower()}. What do you want to do? ");
    string input = Console.ReadLine()!.ToLower();

    if (input == "quit" || input == "q")
        break;
    else if (chest == Chest.Unlocked)
        switch (input)
        {
            case "open":
                chest = Chest.Open;
                break;
            case "close":
                Console.WriteLine("It's already Closed");
                break;
            case "unlock":
                Console.WriteLine("It's already Unlocked");
                break;
            case "lock":
                chest = Chest.Locked;
                break;
            default:
                Console.WriteLine("Invalid choice. Your choices are: open, close, lock, unlock, or quit");
                break;

        }
    else if (chest == Chest.Locked)
        switch (input)
        {
            case "open":
                Console.WriteLine("You can't open a Locked chest");
                break;
            case "close":
                Console.WriteLine("It's already Closed");
                break;
            case "unlock":
                chest = Chest.Unlocked;
                break;
            case "lock":
                Console.WriteLine("It's already Locked!");
                break;
            default:
                Console.WriteLine("Invalid choice. Your choices are: open, close, lock, unlock, or quit");
                break;
        }
    else if (chest == Chest.Open)
        switch (input)
        {
            case "open":
                Console.WriteLine("It's already Open");
                break;
            case "close":
                chest = Chest.Closed;
                break;
            case "unlock":
                Console.WriteLine("It's already Unlocked and Open!");
                break;
            case "lock":
                Console.WriteLine("You must Close it first");
                break;
            default:
                Console.WriteLine("Invalid choice. Your choices are: open, close, lock, unlock, or quit");
                break;
        }
    else if (chest == Chest.Closed)
        switch (input)
        {
            case "open":
                chest = Chest.Open;
                break;
            case "close":
                Console.WriteLine("It's already Closed");
                break;
            case "unlock":
                Console.WriteLine("It's already Unlocked!");
                break;
            case "lock":
                chest = Chest.Locked;
                break;
            default:
                Console.WriteLine("Invalid choice. Your choices are: open, close, lock, unlock, or quit");
                break;
        }

}
Console.WriteLine("Goodbye!");


enum Chest
{
    Open,
    Closed,
    Locked,
    Unlocked
}