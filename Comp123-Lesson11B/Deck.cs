using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name : Gursharan Singh
 * Date : 25 July ,2017
 * Description : This is the deck class
 * It inherits from the generic list and uses Card as its type 
 * Version : 0.5 Added Deal1 method
 */
namespace Comp123_Lesson11B
{
    public class Deck:CardList
    {
        //Private instance variables
        private Random _random;
        //Public properties
        //Constructor
        public Deck()
        {
            this._initialize();
        }

        protected override void _initialize()
        {

            // initialize the psuedo random number generator
            this._random = new Random();
            //This builds a deck
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
            outputString+="Deck Contains : " + this.Count+"\n";
            outputString += "================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void Shuffle()
        {
            int firstCard;int secondCard;Card tempCard;
            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this._random.Next(0, this.Count);
                secondCard = this._random.Next(0,this.Count);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[secondCard].Suit = tempCard.Suit;
            }
        }
        /// <summary>
        /// This method returns the top card of the list
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0);
            return topCard; 
        }
    }
}