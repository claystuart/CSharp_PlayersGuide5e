// Description: Two Challenges
// 1. "Buying Inventory" Display menu of inventory and print price of chose item
// 2. "Discounted Inventory" - Modify "Buying Inventory" to ask username for possible discount

string[] items = ["Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies"];

Console.WriteLine("The following items are available:");
for (int x = 0; x < items.Length; x++)
    Console.WriteLine($"{x + 1} - {items[x]}");
Console.Write("What number do you want to see the price of? ");

string input = Console.ReadLine()!;
bool goodInput = int.TryParse(input, out int choice);
if (goodInput == false || choice < 1 || choice > 7)
{
    Console.WriteLine("That's not a valid choice.");
    Environment.Exit(1);
}

int price_listing = choice switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

// Challenge 2: Discount
Console.Write("Enter name: ");
input = Console.ReadLine()!;
if (input.ToLower() == "gandolf")
    price_listing = Math.Clamp((price_listing / 2), 1, 200);

Console.WriteLine($"{items[choice - 1]} cost(s) {price_listing} gold.");




