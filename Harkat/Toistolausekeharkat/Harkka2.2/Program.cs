
double[] nums = { 1.11, 2.22, 3.33 };

int i = 0;
double sum = 0;
while (i < nums.Length)
{
    sum += nums[i];
    i++;
}

Console.WriteLine(sum);