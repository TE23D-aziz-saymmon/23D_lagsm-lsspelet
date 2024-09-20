



Console.WriteLine("Skriv in ditt namn:");

string name = Console.ReadLine();
while (name.Length < 3)
{
    Console.WriteLine("Skriv in ditt namn, sa jag, dumhuvve!");
    name = Console.ReadLine();
}


Console.WriteLine($"Hej {name}");

Console.ReadLine();