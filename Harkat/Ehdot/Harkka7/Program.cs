
Console.WriteLine("Kirjoita sana:");

string word1 = Console.ReadLine();
int length1 = word1.Length;

Console.WriteLine("Kirjoita toinen sana:");

string word2 = Console.ReadLine();
int length2 = word2.Length;

if(length1 > length2) {
    Console.WriteLine(word1);
}
else if(length1 < length2) {
    Console.WriteLine(word2);
}
else if(length1 == length2) {
    Console.WriteLine(length1 + length2);
}