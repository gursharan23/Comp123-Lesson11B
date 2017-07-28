using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name : Gursharan Singh
 * Date : 25 July ,2017
 * Description : This is the deck class
 * It inherits from the generic list and uses Card as its type 
 * Version : 0.6 Added the Deal5 method
 */
namespace Comp123_Lesson11B
{
    public class Deck:CardList
    {
        //Private instance variables
        private Random _random;
        //Public properties
        //Constructor
      

        protected override void _initialize()
        {
            // initialize the pseudo-random number generator
            this._random = new Random();

            // This builds the deck - fills it with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
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

            outputString += "Deck Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

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
        /// This method returns the top card of the deck
        /// </summary>
       public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); // this removes the top card from the deck

            // for testing / debugging only
            Console.WriteLine("Dealt 1 card - Size of Deck: " + this.Count + "\n");

            return topCard;
        }

        /// <summary>
        /// This is the public method that
        /// takes five cards from the deck
        /// </summary>
        /// <returns></returns>
         public Hand Deal5()
         {
             Hand fiveCards = new Hand();
             for (int i = 0; i <= 4; i++)
             {
                 fiveCards.Add(Deal1());
             }
             return fiveCards;
         }

    }
}