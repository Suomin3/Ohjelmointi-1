
Console.WriteLine("Type a number:");

string Response = Console.ReadLine();

Console.WriteLine("Type a second number:");

string Response2 = Console.ReadLine();

int Value;

int Value2;
{
    Value = Convert.ToInt32(Response);
}
{
    Value2 = Convert.ToInt32(Response2);
}

Console.WriteLine(Value + Value2);

// Toinen vaihtoehto

// Console.WriteLine("Type a number:");

// string Response = Console.ReadLine();

// Console.WriteLine("Type a second number:");

// string Response2 = Console.ReadLine();

// Console.WriteLine(int.Parse(Response) + int.Parse(Response2));