
{
    Console.WriteLine("Kirjoita sana: ");
}
string Response = Console.ReadLine();
{
    Console.WriteLine("Kirjoita toinen sana: ");
}
string Response2 = Console.ReadLine();

int Length = Response.Length;
int Length2 = Response2.Length;

if(Length > Length2) {
    Console.WriteLine(Response);
}
else if (Length < Length2) {
    Console.WriteLine(Response2);
}
else
{
    Console.WriteLine(Length + Length2);
}