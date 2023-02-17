
Console.WriteLine("Kirjoita kolme sanaa: ");

string[] words = new string[3];

int i = 0;

while (i < words.Length)
{
    words[i] = Console.ReadLine();
    i++;
}

Array.Reverse(words);

int j = 0;

while (j < words.Length)
{
    Console.WriteLine(words[j]);
    j++;
}