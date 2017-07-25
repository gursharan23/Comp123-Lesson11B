using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name : Gursharan Singh
 * Date : 25 July ,2017
 * Description : This is the card class 
 * Version : 0.2 Implemented Icloneable interface
 */
namespace Comp123_Lesson11B
{
    public class Card
    {
        //Private instance variables
        private Face __face;
        private Suit _suit;
        //Public properties
        public Face Face { get { return this.__face; } set { this.__face = value; } }
        public Suit Suit { get { return this._suit; } set { this._suit = value; } }

        //Constructor
        /// <summary>
        /// This is the main constructor of Card class having two parameters - face(Face), suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
