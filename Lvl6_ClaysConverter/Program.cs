// Description: Read age and convert string->int  // pages 47-48
// Demonstrate different string->int conversion methods
// Program won't convert sring->int if given a float value

Console.Write("Enter age: ");
string input = Console.ReadLine()!;

/** Multiple Conversion methods **/
//int age = Convert.ToInt32(input);
//int age = int.Parse(input);
bool success = int.TryParse(input, out int age); // TryParse described on page 275 (my preferred method)

if (success)
    Console.WriteLine($"Next year, you will be {++age} years old");
else
    Console.WriteLine("Error on input");
