
double[] numbers = { 1.11, 2.22, 3.33 };
double sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);