namespace Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (fDeck.Count > 0 && sDeck.Count > 0)
            {
                PlayRound(fDeck, sDeck);
            }

            if (fDeck.Count > 0)
            {
                PrintResult("First", fDeck);
            }
            else
            {
                PrintResult("Second", sDeck);
            }
        }
        static void PlayRound(List<int> fDeck, List<int> sDeck)
        {
            int fCard = fDeck[0];
            int sCard = sDeck[0];

            if (fCard > sCard)
            {

                fDeck.RemoveAt(0);
                sDeck.RemoveAt(0);
                fDeck.Add(fCard);
                fDeck.Add(sCard);
            }
            else if (sCard > fCard)
            {

                fDeck.RemoveAt(0);
                sDeck.RemoveAt(0);
                sDeck.Add(sCard);
                sDeck.Add(fCard);
            }
            else
            {

                fDeck.RemoveAt(0);
                sDeck.RemoveAt(0);
            }
        }

        static void PrintResult(string winner, List<int> rCards)
        {
            int sum = rCards.Sum();
            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}