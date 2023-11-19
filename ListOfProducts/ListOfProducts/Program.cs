namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <string> products = new  List<string>();
            for(int i = 0; i < n; i++)
            {
                string cProduct = Console.ReadLine();
                products.Add(cProduct);
                products.Sort();
                
            }
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}