﻿
{
    int a;
    int b;
    int c;

    a = 12;
    b = (a * 4);
    a = 25;
    c = (a + b / a);

Console.WriteLine(c); //Tulos ei ole oikein, koska jakojäännös (.92) ei tulostu
}