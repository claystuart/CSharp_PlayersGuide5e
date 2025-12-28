// Description: Read a noun and an adjective and Output it. Also, employ Comments and a Bug Fix - page 31

Console.WriteLine("What kind of thing are we talking about?");
string item = Console.ReadLine()!; // '!' suppresses null warning
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string description = Console.ReadLine()!; // '!' suppresses null warning
string adj1 = "of doom";
string adj2 = "3000";
Console.WriteLine($"The {description} {item} {adj1} {adj2}!"); /* bug is extra "of" in string */