
Console.WriteLine("Kirjoita sanoja: ");

string[] array = new string[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
    if(array[i] == "lopeta")
        break;
}
Console.WriteLine("Tulostit " + array.Length + " sanaa");
Console.WriteLine("Ensimmäinen sana: " + array[0]);