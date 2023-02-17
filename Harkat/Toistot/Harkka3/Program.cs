string[] array = new string[3];

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Kirjoita sana: ");
    array[i] = Console.ReadLine();
}

Console.WriteLine(" ");

for(int i = 2; i < array.Length; i--)
{
    Console.WriteLine(array[i]);
    if(i == 0) {
        break;
    }
}

// for (int i = arr.Length - 1; i >= 0; i--)
//     {
//         string s = arr[i];
//         Console.WriteLine(s);
//     }

// Netistä kopioitu arrayn tulostaminen käänteisessä järjestyksessä.

// Array.Reverse(array); <-- C# funktio toimii myös