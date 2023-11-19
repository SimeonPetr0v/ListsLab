namespace Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> num = Console.ReadLine ()
            .Split()
                .Select(int.Parse)
                .ToList();
            num.RemoveAll(n => n < 0);
            if(num.Count == 0)
            {
                Console.WriteLine("empty");

            }
            else
            {
                num.Reverse();
                Console.WriteLine(string.Join(" ", num));
            }
        }
    }
}