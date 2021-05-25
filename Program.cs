using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Pg375_SortCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> Cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
                Cards.Add(card);
            }

            Console.WriteLine("Five random cards:");
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }

            CardComparer_byValue cardComparer = new CardComparer_byValue();
            Cards.Sort(cardComparer);

            Console.WriteLine("\nThose same cards, sorted:");
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }

            Console.ReadKey();
        }
    }
}
