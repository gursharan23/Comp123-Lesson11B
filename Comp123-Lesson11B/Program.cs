using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name : Gursharan Singh
 * Date : 25 July ,2017
 * Description : This is the demo class for Lesson 11
 * Version : 0.2 test shuffle method of the deck class
 */
namespace Comp123_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Original Deck: " + deck.Count);
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            Console.WriteLine("Shuffle Deck: " + deck.Count);
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
        }
    }
}
