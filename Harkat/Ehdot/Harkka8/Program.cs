
Console.WriteLine("Valitse joko A tai B");

string input = Console.ReadLine();

if(input == "A") {
    Console.WriteLine("Hieno valinta");
}
else if(input == "B") {
    Console.WriteLine("Loistava valinta");
}
else {
    Console.WriteLine("Vihreellinen syöte!");
}