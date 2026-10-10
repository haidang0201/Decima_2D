public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };

        return new int[0];
    }

    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expected = n * (n + 1) / 2;

        int actual = 0;
        foreach (int x in nums)
            actual += x;

        return expected - actual;
    }
}