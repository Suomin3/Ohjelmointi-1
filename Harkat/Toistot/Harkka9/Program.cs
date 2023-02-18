
int[] nums = new int[10];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = i;
}
for (int i = 0; i < nums.Length; i += 2)
{
    Console.WriteLine(nums[i] + " " + nums[i+1]);
}