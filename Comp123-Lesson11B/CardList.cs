using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name : Gursharan Singh
 * Date : 27 July ,2017
 * Description : This is the abstract super class card list
 * Version : 0.1 Created Abstract CardList
 */
namespace Comp123_Lesson11B
{
    public abstract class CardList : List<Card>
    {
        // Private Instance Variables
        //Public Properties
        // Constructors
        public CardList()
        {
            this._initialize();
        }
        // Private Methods
        protected abstract void _initialize();
        
        // Public Methods
    }
}