// Description: Two Challenges
// Challenge 1: The Replicator of D'To (p94) - Create an array_copy method
// Challenge 2: The Laws of Freach (p95) - Rewrite Min() and Average() using a foreach loop

// Replicator();
LawsOfFreach();

// Min and Average program using foreach loop
static void LawsOfFreach()
{
    int[] array = { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
    
    // Min()
    int smallest = array[0];
    foreach (var number in array)
        if (number < smallest)
            smallest = number;
    Console.WriteLine($"Smallest: {smallest}");

    float accumulator = 0;
    int counter = 0;
    foreach(var number in array)
    {
        counter++;
        accumulator += number;
    }
    Console.WriteLine($"Average: {accumulator / counter:F2}");

}

/// Copy Array program
static void Replicator()
{
    Console.Write("Enter 5 numbers: ");
    string input = Console.ReadLine()!;
    string[] str_nums = input.Split(' ');

    const int ARRAY_SIZE = 5;

    int[] array1 = new int[ARRAY_SIZE];

    for (int x = 0; x < array1.Length; x++)
        array1[x] = int.Parse(str_nums[x]);

    int[] array2 = new int[ARRAY_SIZE];
    for (int x = 0; x < array1.Length; x++)
        array2[x] = array1[x];

    Console.Write("Array 1: ");
    foreach (int x in array1)
        Console.Write($"{x} ");

    Console.WriteLine();

    Console.Write("Array 2: ");
    foreach (int x in array2)
        Console.Write($"{x} ");
}