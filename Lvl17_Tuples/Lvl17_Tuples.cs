// Description: Simula's Soup - Create three (3) Enums and let user combine together into a tuple.

string dish = "Pizza", ingredient = "Pepperoni", seasoning = "Cheesy";

// Dish input
Console.Write("Available Dishes: ");
foreach (var item in Enum.GetValues<Dish>())
    Console.Write($"{item.ToString()} ");
Console.Write("\nWhat dish would you like? ");
string input = Console.ReadLine()!;

foreach (var item in Enum.GetValues<Dish>())
{
    if (item.ToString().ToLower() == input.ToLower())
        dish = input;
}

Console.WriteLine($"You ordered {seasoning} {ingredient} {dish}.");

enum Dish
{
    Soup,
    Stew,
    Gumbo
};

enum Ingredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
};

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
};
