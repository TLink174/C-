namespace LAB4.EX2;

public class SumInOrder
{
    private SumInOrder() {}
    
    public static int sumInOrder(List<int> nums)
    {
        int sum = 0;
        int firstIndex = 0;
        int lastIndex = nums.Count - 1;

        while (firstIndex <= lastIndex)
        {
            sum += nums[firstIndex];
            if (firstIndex != lastIndex)
            {
                sum += nums[lastIndex];
            }
            firstIndex++;
            lastIndex--;
        }

        return sum;
    }
}