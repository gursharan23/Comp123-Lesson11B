using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name : Gursharan Singh
 * Date : 27 July ,2017
 * Description : This is the hand  class 
 * It inherits from abstract card list
 * Version : 0.1 Created Abstract CardList
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
            outputString += "Hand Contains : " + this.Count + "\n";
            outputString += "================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

    }
}