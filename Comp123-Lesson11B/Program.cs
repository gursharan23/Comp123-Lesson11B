using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name : Gursharan Singh
 * Date : 25 July ,2017
 * Description : This is the demo class for Lesson 11
 * Version : 0.5 Tested HighestCards method from Hand class 
 */
namespace Comp123_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            /*Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            //Console.WriteLine();
            //Console.WriteLine(deck.ToString());*/

            Console.WriteLine("Taking 5 cards from the deck\n");
            Console.WriteLine("==========================\n");
            hand=deck.Deal5();
            Console.WriteLine(hand.ToString());
            hand.HighestCards();
            
        }
    }
}
