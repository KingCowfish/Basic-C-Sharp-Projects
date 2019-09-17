using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            _21Game game = new _21Game();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
