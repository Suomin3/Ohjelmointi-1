
// int[] array = new int[100];

// Console.Write("Anna ensimmäinen kokonaisluku: ");
// array[0] = int.Parse(Console.ReadLine());
// Console.Write("Anna toinen kokonaisluku: ");
// array[1] = int.Parse(Console.ReadLine());
// Console.Write("Anna kolmas kokonaisluku: ");
// array[2] = int.Parse(Console.ReadLine());

// Console.Write("Suoritetaanko luvuille kertolasku (*), summaus (+) vai vähennys (-)?: ");
// string laskutapa = Console.ReadLine();

// if(laskutapa == "+") {
//     int sum = array[0] + array[1] + array[2];
//     Console.WriteLine(array[0] + " + " + array[1] + " + " + array[2] + " = " + sum);
// }
// else if(laskutapa == "*") {
//     int sum2 = array[0] * array[1] * array[2];
//     Console.WriteLine(array[0] + " x " + array[1] + " x " + array[2] + " = " + sum2);
// }
// else if(laskutapa == "-") {
//     int sum3 = array[0] - array[1] - array[2];
//     Console.WriteLine(array[0] + " - " + array[1] + " - " + array[2] + " = " + sum3);
// }

////////// Lisähaaste alla, ylempi systeemi toimii //////////

// int[] array = new int[50];

Console.Write("Anna kolme kokonaislukua (pilkulla erotettuna): ");
string[] input = Console.ReadLine().Split(',');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);

Console.Write("Suoritetaanko luvuille kertolasku (x), summaus (+) vai vähennys (-)? : ");
string laskutapa = Console.ReadLine();

if(laskutapa == "+") {
    int sum = a + b + c;
    Console.WriteLine(input[0] + " + " + input[1] + " + " + input[2] + " = " + sum);
}
else if(laskutapa == "x") {
    int sum2 = a * b * c;
    Console.WriteLine(input[0] + " x " + input[1] + " x " + input[2] + " = " + sum2);
}
else if(laskutapa == "-") {
    int sum3 = a - b - c;
    Console.WriteLine(input[0] + " - " + input[1] + " - " + input[2] + " = " + sum3);
}