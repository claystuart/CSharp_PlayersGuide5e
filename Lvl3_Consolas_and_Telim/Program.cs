// Description: Get user's name and give them bread

Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");
string name = Console.ReadLine()!; //"!" suppresses null warning
Console.WriteLine($"Noted: {name} got bread");
