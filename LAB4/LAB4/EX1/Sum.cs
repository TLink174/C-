namespace LAB4.EX1;

public class Sum
{
    private Sum() {}

    public static void sum(List<double> nums)
    {
        for (int i = 0; i < nums.Count - 1;)
        {
            if (nums[i] == nums[i + 1])
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);
            }
            else
            {
                i++;
            }
        }
    }
}