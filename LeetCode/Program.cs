namespace Test { 
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int [] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    else
                    {
                        if (nums[i] + nums[j] == target) {
                            result[0] = i;
                            result[1] = j;
                        }
                    }    
                }
            }
        return result;
    }
    
}
    class Programm
    {
        static void Main(string[] args)
        {
            var instance = new Solution();
            Console.WriteLine();
            var result = instance.TwoSum(new int[] { 1, 3, 5, 7, 9 }, 4);
            foreach (int i in result) Console.WriteLine(i);

        }
    }


    
}