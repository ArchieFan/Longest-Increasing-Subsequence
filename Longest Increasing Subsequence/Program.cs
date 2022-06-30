using System.Diagnostics;

static int LengthOfLIS(int[] nums)
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

static int FindNumberOfLIS(int[] nums)
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

//int[] nums = { -1, 3,4,5,2,2,2,2,2,2};
//int[] nums = {0,3,1,6,2,2,7 };
//int[] nums = {10,9,2,5,3,7,101,18 };
//int[] nums = {0,1,0,3,2,3 };
//int[] nums = {7,7,7,7,7,7,7 };
int[] nums = { 10, 22, 9, 33, 21, 50, 41, 60 };
//int[] nums = { 1, 3, 5, 4, 7 };
//int[] nums = { 2,2,2,2,2 };


Stopwatch timer1 = new Stopwatch();
timer1.Start();
int x = LengthOfLIS(nums);
timer1.Stop();
Console.WriteLine(" {0}", x);
Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", timer1.Elapsed);

Stopwatch timer2 = new Stopwatch();
timer2.Start();
int y = FindNumberOfLIS(nums);
timer2.Stop();
Console.WriteLine(" {0}", y);
Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", timer2.Elapsed);