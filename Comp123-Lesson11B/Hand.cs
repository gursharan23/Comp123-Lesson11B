using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name : Gursharan Singh
 * Date : 27 July ,2017
 * Description : This is the hand  class 
 * It inherits from abstract card list
 * Version : 0.2 Added HighestCards Method
 */
namespace Comp123_Lesson11B
{
    public class Hand : CardList
    {
        // Private Instance Variables

        // Public Properties
        // Constructors
        protected override void _initialize()
        {
           // STUB
            // This method is empty
        }
        /// <summary>
        /// This methods returns string output of deck class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + " from the deck \n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

      

        public void HighestCards()
        {
            var cards = from card in this
                orderby  card.Face descending,card.Suit 
                select card;

            Console.WriteLine("Sorted cards in the hands ");
            foreach (var element in cards)
            {
                Console.WriteLine("\nThe " + element.Face + " of "+element.Suit+"");
            }
            Console.WriteLine("\nHighest Card");
            Console.WriteLine("============");
            Console.WriteLine("The " + cards.ElementAtOrDefault(0).Face + " of "+cards.ElementAtOrDefault(0).Suit);
        }


    }
}