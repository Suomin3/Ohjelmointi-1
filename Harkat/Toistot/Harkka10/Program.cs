
Console.WriteLine("Kirjoita sanoja: ");

string[] array = new string[10];

for(int i = 0; i < array.Length; i++)
{
    string input = Console.ReadLine();
    array[i] = input;
    if(input == "lopeta"){
        Console.WriteLine("Tulostit " + i + " sanaa");
        Console.WriteLine("Ensimmäinen sana: " + array[0]);
        Console.WriteLine("Viimeinen sana: " + array[i-1]);
        break;
    }
}
Console.WriteLine("Ensimmäinen sana: " + array[0]);
Console.WriteLine("Ensimmäinen sana: " + array[9]);