
// Console.WriteLine("Enter 10 words or type \"stop\" to exit: ");

// string[] array = new string[10];

// string input;
// int count = 0;

// for(count = 0; count < array.Length; count++)
// {
//     input = Console.ReadLine();
//     if(input == "stop"){
//         break;
//     }
//     array[count] = input;
// }
// Console.WriteLine($"You've entered {count} words.");
// Console.WriteLine($"First word: {array[0]}");
// Console.WriteLine($"Last word: {array[count-1]}");

// string shortWord = array[0];
// string longWord = array[0];

// for (int i = 0; i < count; i++){
//     if (array[i].Length < shortWord.Length){
//         shortWord = array[i];
//     }
//     if (array[i].Length > longWord.Length){
//         longWord = array[i];
//     }
// }

// Console.WriteLine("Shortest word: " + shortWord);
// Console.WriteLine("Longest word: " + longWord);

// Lisätehtävä alla (ilman arrayta)

Console.WriteLine("Enter 10 words or type \"stop\" to exit: ");

string input, firstWord = null, lastWord = null, shortWord = null, longWord = null;
int count = 0;

for(count = 0; count < 10; count++){
    input = Console.ReadLine();
    if(input == "stop"){
        break;
    }
    else if(count == 0){
        input = shortWord;
    }
}

string shortWord = array[0];
string longWord = array[0];

for (int i = 0; i < count; i++){
    if (array[i].Length < shortWord.Length){
        shortWord = array[i];
    }
    if (array[i].Length > longWord.Length){
        longWord = array[i];
    }
}

Console.WriteLine($"You've entered {count} words.");
Console.WriteLine($"First word: {count}");
// Console.WriteLine($"Last word: {array[count-1]}");
// Console.WriteLine("Shortest word: " + shortWord);
// Console.WriteLine("Longest word: " + longWord);