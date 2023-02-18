
string[] array = { "ei", "terve", "halojaa", "vittu", "ei", "saatana", "jumalauta", "samk", "automaatio", "tarkov", "huomenta" };

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length > 2)
    {
        Console.WriteLine(array[i]);
    }
}