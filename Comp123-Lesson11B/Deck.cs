using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name : Gursharan Singh
 * Date : 25 July ,2017
 * Description : This is the deck class
 * It inherits from the generic list and uses Card as its type 
 * Version : 0.1 Created card class
 */
namespace Comp123_Lesson11B
{
    public class Deck:List<Card>
    {
        //Private instance variables
        //Public properties
        //Constructor
        public Deck()
        {
            this._initialize();
        }

        private void _initialize()
        {
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)(face), (Suit)(suit)));
                }
            }
           
        }
        //Private Methods
        //Public Methods
        /// <summary>
        /// This methods returns string output of deck class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
    }
}