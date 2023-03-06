
Console.WriteLine("Enter 10 words or type \"stop\" to exit: ");

string[] array = new string[10];

string input;
int count = 0;

for(count = 0; count < array.Length; count++)
{
    input = Console.ReadLine();
    if(input == "stop"){
        break;
    }
    array[count] = input;
}
Console.WriteLine($"You've entered {count} words.");
Console.WriteLine($"First word: {array[0]}");
Console.WriteLine($"Last word: {array[count-1]}");

int shortWord = array[0].Length;
int longWord = array[0].Length;
if(shortWord < array[0].Length){
    
}

Console.WriteLine("Shortest word: ");
Console.WriteLine("Longest word: ");