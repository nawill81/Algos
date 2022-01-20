using Xunit;

namespace Algos
{
    public class Search
    {
        [Theory]
        [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [InlineData(null, 0, -1)]
        [InlineData(new int[] { }, 0, -1)]
        public void BinarySearch(int[] nums, int target, int expectedIndex)
        {
            Assert.Equal(expectedIndex, Search());

            int Search()
            {
                if (nums is null || nums.Length == 0)
                {
                    return -1;
                }

                int left = 0;
                int right = nums.Length - 1;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (nums[middle] == target)
                        return middle;

                    if (target < nums[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                return -1;
            }
        }
    }
}