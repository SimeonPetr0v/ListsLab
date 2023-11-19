namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombN = bomb[0];
            int power = bomb[1];

            DetonateBombs(nums, bombN, power);

            int sum = nums.Sum();
            Console.WriteLine(sum);
        }

        static void DetonateBombs(List<int> nums, int bombN, int power)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bombN)
                {
                    int start = Math.Max(0, i - power);
                    int end = Math.Min(i + power, nums.Count - 1);

                    for (int j = end; j >= start; j--)
                    {
                        nums.RemoveAt(j);
                    }

                    i = start - 1;
                }
            }
        }
    }
}