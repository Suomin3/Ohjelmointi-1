
string[] words = new string[3];

int i = 0;

while (i < words.Length)
{
    Console.WriteLine("Kirjoita sana: ");
    string input = Console.ReadLine();
    words[i] = input;
    i++;
}

Array.Reverse(words);

int j = 0;

while (j < 3)
{
    Console.WriteLine(words[j]);
    j++;
}