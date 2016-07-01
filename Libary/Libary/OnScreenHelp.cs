using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary
{
    class OnScreenHelp
    {
        public void showAddItemsHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("This will allow you to add a item by entering the data and pressing enter.");
        }
       /* public void showViewItemsHelp()
        {
            Console.WriteLine("This is showing you the items that are in the program.");
        }*/
        public void showRemoveItemHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Please enter the data of the item you wish to remove from the program and select enter");
        }
        public void showAddStudentHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Please select the data of the student that you want to add to the program");
        }
        /*public void viewStudentsHelp()
        {
            Console.WriteLine("This is showing you a list of all the students currently in the libary program");
        }*/
        public void showRemoveStudentHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Please enter the student ID of the student you wish to remove and then press enter to remove the student from the libary program");
        }
        public void showSearchForItemHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Please enter the details of the item you wish to search for inside the libary program.");
        }
        public void showSearchForStudentHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Please enter the details of the student you wish to search for inside the libary program.");
        }
        public void showBorrowItemHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Borrowing a item will take one of the available copies");
        }
        public void showReturnItemHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Returning a item will add one to the available copies for the book");
        }
        public void showUpdateItemHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Updating items will save all the items you have added so you can access them the next time you run the program, press any key to continue...");
            Console.ReadKey();
        }
        public void showLoadItemHelp()//this method is called by BookLibrary.cs to show help.
        {
            Console.WriteLine("Loading items will allow you to access any items you have previously updated, and show every item, press any key to continue...");
            Console.ReadKey();
        }
    }
}
