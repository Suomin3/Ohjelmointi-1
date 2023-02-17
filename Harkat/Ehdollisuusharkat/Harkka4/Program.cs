int value = 50;

if(value < 100) {
    Console.WriteLine("Arvo on aika pieni.");
}
else if(value == 100) {
    Console.WriteLine("Arvo on sata.");
}
else if(value > 100 && value < 200) {
    Console.WriteLine("Alkaa olla aika iso luku.");
}
else if(value > 200) {
    Console.WriteLine("Nyt ollaan isoissa luvuissa.");
}