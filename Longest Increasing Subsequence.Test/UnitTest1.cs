using System.Diagnostics;

namespace Longest_Increasing_Subsequence.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { -1, 3, 4, 5, 2, 2, 2, 2, 2, 2 }, 4)]
        [InlineData(new int[] { 0, 3, 1, 6, 2, 2, 7 }, 4)]
        [InlineData(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
        [InlineData(new int[] { 0, 1, 0, 3, 2, 3 }, 4)]
        [InlineData(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 1)]
        [InlineData(new int[] { 10, 22, 9, 33, 21, 50, 41, 60 }, 5)]
        [InlineData(new int[] { 1, 3, 5, 4, 7 }, 4)]
        [InlineData(new int[] { 2, 2, 2, 2, 2 }, 1)]
        public void XUnitTest(int[] inputarr, int expected)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LIS lis = new LIS();
            int x = lis.LengthOfLIS(inputarr);
            timer.Stop();
            Console.WriteLine(" {0}", x);
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", timer.Elapsed);
            Assert.Equal(expected, x);
        }

        [Theory]
        [InlineData(new int[] { -1, 3, 4, 5, 2, 2, 2, 2, 2, 2 }, 1)]
        [InlineData(new int[] { 0, 3, 1, 6, 2, 2, 7 }, 4)]
        [InlineData(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
        [InlineData(new int[] { 0, 1, 0, 3, 2, 3 }, 1)]
        [InlineData(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 7)]
        [InlineData(new int[] { 10, 22, 9, 33, 21, 50, 41, 60 }, 2)]
        [InlineData(new int[] { 1, 3, 5, 4, 7 }, 2)]
        [InlineData(new int[] { 2, 2, 2, 2, 2 }, 5)]
        public void XUnitTest2(int[] inputarr, int expected)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LIS lis = new LIS();
            int x = lis.FindNumberOfLIS(inputarr);
            timer.Stop();
            Console.WriteLine(" {0}", x);
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", timer.Elapsed);
            Assert.Equal(expected, x);
        }
    }
}