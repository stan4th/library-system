using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary

{
    [Serializable()]
    public class Journal : LibaryItem
    {
        private int date;
        private string publisher;
    
        public Journal(int date, string publisher, string newTitle, int newCopies, int newAvailCopies):base(newTitle,newCopies,newAvailCopies)
        {
            this.date = date;
            this.publisher = publisher;
        }

        public int Date 
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
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
                Console.WriteLine("No Journals available");
            }
        }
        public override void toString()
        {
            throw new NotImplementedException();
        }
    }
}
