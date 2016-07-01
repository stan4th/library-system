using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary
{
    [Serializable()]
    class Book : LibaryItem
    {
     
        private string author;


        public Book(string newTitle, string newAuthor, int newCopies, int newavilCopies)
            : base(newTitle, newCopies, newavilCopies)
        {
            author = newAuthor;
        }
        public override void borrowCopy()
        {
            if (AvailCopies > 0)
            {
                AvailCopies--;
                Console.WriteLine("You have taken a copy of " + Title);
            }
            else
            {
                Console.WriteLine("No Books available");
            }
        }

        public override void toString()
        {
            Console.WriteLine("The title is; " + Title + ". The author is " + Author + ". The number of copies is:" + Copies + ". The number of available copies are: " + AvailCopies);
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
    }
}
