
Console.WriteLine("Vaihtoehdot:");
Console.WriteLine("0: Maito, 1: Vesi, 2: Kahvi, 3: Tee, 4: Limsa");

string[] juomalista = { "Maito", "Vesi", "Kahvi", "Tee", "Limsa" };

Console.Write("Valintasi [0-4]: ");
string vastaus = Console.ReadLine();

int valinta = int.Parse(vastaus);

if(valinta > juomalista.Length - 1) {
    Console.WriteLine("Viallinen vaihtoehto!");
}
else
{
    Console.WriteLine(juomalista[valinta] + "! Hyvä valinta");
}