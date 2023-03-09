
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

string[] array1 = { "Cats and ratsasdfasdf", "just rats and the just catest", "rats" };
var shortString = array1[0];
var longString = array1[0];

foreach (var t in array1)
{
    if (shortString.Length > t.Length)
        shortString = t;
    if (longString.Length < t.Length)
        longString = t;
}
Console.WriteLine("shortest string is:" + shortString);
Console.WriteLine("Longest string is:" + longString);
Console.Read();