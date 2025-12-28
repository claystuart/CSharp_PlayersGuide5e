// Description: Multiple math challenges - using Main style organized by methods for each challenge

internal class Program
{
    private static void Main(string[] args)
    {
        //TriangleFarmer();
        //Duckbear();
        DominionScore();
    }

    /// <summary>
    /// Score kingdom on number of provinces(6 pts), duchies(3 pts), and estates(1 pt)
    /// </summary>
    private static void DominionScore()
    {
        Console.Write("Enter the number of provinces, duchies, and estates: ");
        string[] parts = Console.ReadLine()!.Split(' ');
        (int provinces, int duchies, int estates) = (int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2])); // Tuple Deconstruction - p141
        int score = provinces * 6 + duchies * 3 + estates;
        Console.WriteLine($"Dominion Score: {score}");
    }

    /// <summary>
    /// Divide eggs between 4 sisters and give any extras (remainder) to duckbear
    /// </summary>
    private static void Duckbear()
    {
        Console.Write("Enter number of eggs: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int eggs))
        {
            int split = eggs / 4;
            int duckbear = eggs % 4;
            Console.WriteLine($"Four Sisters split: {split} and Duckbear: {duckbear}");
        }
        else
            Console.WriteLine("Bad input");
    }

    /// <summary>
    /// Calculate area of triangle: Area = 1/2(base * height)
    /// </summary>
    private static void TriangleFarmer()
    {
        Console.Write("Enter length of base: ");
        string base_input = Console.ReadLine()!;
        Console.Write("Enter length of height: ");
        string height_input = Console.ReadLine()!;
        double b = Convert.ToDouble(base_input);
        double h = Convert.ToDouble(height_input);

        double area = (b * h * .5);
        Console.WriteLine($"The area of a triangle with base {base_input} and height {height_input} = {area}");
    }
}