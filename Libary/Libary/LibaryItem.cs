using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary
{
    [Serializable()]
    public abstract class LibaryItem
    {
        private string title;
        private int copies;
        private int availCopies;

        public LibaryItem(string newTitle, int newCopies, int newAvailCopies)//this is the constructor, it initialises the object.
        {
            title = newTitle;
            copies = newCopies;
            availCopies = newAvailCopies;
        }

        public string Title
        {
            get
            { return title; }
            set
            {
                title = value;
            }
        }
        public int Copies
        {
            get
            {
                return copies;
            }
            set
            {
                copies = value;
            }
        }

        public int AvailCopies
        {
            get
            {
                return availCopies;
            }
            set
            {
                availCopies = value;
            }
        }

        public abstract void borrowCopy();
    
        public void returnCopy()//this method is used to add a copy to the available copies when an Item is returned.
        {
            availCopies = availCopies + 1;
        }
        public abstract void toString();
    }
}