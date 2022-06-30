using System.Diagnostics;

public class LIS {
    public int LengthOfLIS(int[] nums)
    {

        if (nums == null || nums.Length == 0)
            return 0;
        else if (nums.Length == 1)
            return 1;

        int currentLength = 1;
        int[] continousLength = new int[nums.Length];

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            continousLength[i] = 1;
            //Console.Write($" {nums[i]} => ");
            for (int j = 0; j < i; j++)
            {

                if (nums[j] < nums[i])
                {
                    //Console.Write($" [{nums[j] <= nums[i] }]");
                    continousLength[i] = Math.Max(continousLength[j] + 1, continousLength[i]);
                }

            }
            //Console.WriteLine();
            currentLength = Math.Max(continousLength[i], currentLength);
        }

        return currentLength;
    }

    public int FindNumberOfLIS(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        else if (nums.Length == 1)
            return 1;

        int currentLength = 1;
        int[] continousLength = new int[nums.Length];      //Length of the Longest Increasing Subsequence which ends with nums[i].
        int[] numberOfLisAtIndex = new int[nums.Length];   //Number of the Longest Increasing Subsequence which ends with nums[i].

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            continousLength[i] = 1;
            numberOfLisAtIndex[i] = 1;

            for (int j = 0; j < i; j++)
            {

                if (nums[j] < nums[i])
                {


                    if (continousLength[j] + 1 > continousLength[i])
                    {
                        continousLength[i] = Math.Max(continousLength[j] + 1, continousLength[i]);
                        numberOfLisAtIndex[i] = numberOfLisAtIndex[j];
                    }
                    else if (continousLength[j] + 1 == continousLength[i])
                    {
                        numberOfLisAtIndex[i] += numberOfLisAtIndex[j];
                    }
                }

            }
            currentLength = Math.Max(continousLength[i], currentLength);
        }

        int maxlen = continousLength.Max();
        int ans = 0;
        for (int i = 0; i < continousLength.Length; i++)
            if (continousLength[i] == maxlen)
                ans += numberOfLisAtIndex[i];

        return ans;
    }
}
