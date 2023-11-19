namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = ReadList();
            List<int> nums = ReadList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(num.Count, nums.Count); i++)
            {
                result.Add(num[i]);
                result.Add(nums[i]);
            }

            if (num.Count > nums.Count)
                result.AddRange(GetRemainingElements(num, nums));
            else if (nums.Count > num.Count)
                result.AddRange(GetRemainingElements(nums, num));

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> ReadList()
        {
            List<int> numbers = new List<int>();
            string[] input = Console.ReadLine().Split();

            foreach (string num in input)
            {
                numbers.Add(int.Parse(num));
            }

            return numbers;
        }

        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }

            return nums;
        }
    }
}