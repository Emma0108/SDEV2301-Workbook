//prompt and read the user's name
Console.Write("Your Name: ");
string name = Console.ReadLine() ?? "no input";
//print the name using string interpolation
Console.WriteLine($"Hello, {name}!");
