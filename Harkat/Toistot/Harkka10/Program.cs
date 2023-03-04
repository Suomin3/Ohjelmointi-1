
Console.WriteLine("Enter 10 words or \"stop\" to exit: ");

string[] array = new string[10];

int i;

for(i = 0; i < array.Length; i++)
{
    string input = Console.ReadLine();
    Console.WriteLine("First word: " + array[0]);
    Console.WriteLine("Last word: " + array[i-1]);
    if(input == "stop"){
        break;
    }
    array[i] = input;
}

Console.WriteLine("First word: " + array[0]);
Console.WriteLine("Last word: " + array[i-1]);