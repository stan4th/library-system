using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary
{
    class Program
    {
        static int Menu() //display the main menu and input the choice.
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Add items");
            Console.WriteLine("2. View items");
            Console.WriteLine("3. Remove item");
            Console.WriteLine("4. Add Students");
            Console.WriteLine("5. View Students");
            Console.WriteLine("6. Remove Students");
            Console.WriteLine("7. Search for item");
            Console.WriteLine("8. Search for student");
            Console.WriteLine("9. Borrow Item");
            Console.WriteLine("10.Return Item");
            Console.WriteLine("11.Update Item");
            Console.WriteLine("12. Load Item");
            Console.WriteLine("13. Exit");

            int choice = -1;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) {
                Console.WriteLine("Please enter a number between 1 and 12, but you had error {0}",e.Message);
                return choice;
            }
            return choice;
        }
        static void Main(string[] args)
        {
           BookLibrary lib = new BookLibrary();
           lib.ItemList.Add(new Book("Oliver Twist", "Charles Dickens", 2, 2)); 
            int menuChoice = 0;
            while( true)
            {
            menuChoice = Menu(); //this is the main menu, where the user enters where they want to go within the program.
                if ( menuChoice == 1)
                {
                    lib.AddItem();
                }
                if (menuChoice == 2)
                {
                    lib.ViewItem();
                }
                if (menuChoice == 3)
                {
                    lib.RemoveItem();
                }
                if (menuChoice == 4)
                {
                    lib.AddStudents();
                }
                if (menuChoice == 5)
                {
                    lib.ViewStudents();
                }
                if (menuChoice == 6)
                {
                    lib.RemoveStudents();
                }
                if (menuChoice == 7)
                {
                    lib.SearchForItems();
                }
                if (menuChoice == 8)
                {
                    lib.SearchForStudents();
                }
                if (menuChoice == 9)
                {
                    lib.BorrowItem();
                } 
                if (menuChoice == 10)
                {
                    lib.returnItem();
                }
                if (menuChoice == 11)
                {
                    lib.UpdateItem();
                }
                if (menuChoice == 12)
                {
                    lib.LoadItems();
                }
                if (menuChoice == 13)
                {
                    break;
                }
                if (menuChoice < 1 || menuChoice > 13)
                {
                    Console.WriteLine("Invalid choice, please select a number between 1 and 12, 13 to exit.");
                }
            }
        }
    }
}
        
       
        /*{
            Book myBook = new Book("The Iliad", "Homer", 0, 0);
            Console.WriteLine(myBook.Title);
            Console.WriteLine(myBook.Author);
            Console.WriteLine(myBook.Copies);
            Console.WriteLine(myBook.AvailCopies);
            myBook.borrowCopy();

            Book secondBook = new Book("nineteen eighty-four", "George Orwell", 10, 10);
            Console.WriteLine(secondBook.Title);
            Console.WriteLine(secondBook.Author);
            Console.WriteLine(secondBook.Copies);
            Console.WriteLine(secondBook.AvailCopies);
            secondBook.borrowCopy();

            Console.WriteLine(secondBook.AvailCopies);
            secondBook.returnCopy();
            Console.WriteLine(secondBook.AvailCopies);

            CD firstCD = new CD("Smooth Crimnal", 10, "Micheal Jackson", 1, 5, 10);
            Console.WriteLine("CD detais {0}, {1}, {2}, {3}, {4}, {5}", firstCD.Artist, firstCD.AvailCopies, firstCD.Copies, firstCD.Numberoftracks, firstCD.Playingtimeinhours, firstCD.Title);
            firstCD.borrowCopy();
            firstCD.borrowCopy();
            Console.WriteLine(firstCD.AvailCopies);
            firstCD.returnCopy();
            Console.WriteLine(firstCD.AvailCopies);

            Book stuff = new Book("Oliver Twist","Ben Stimson", 4, 2);
            stuff.borrowCopy();
            Console.WriteLine(stuff.AvailCopies);
            LibaryItem[] itemArray = new LibaryItem[3];
            itemArray[0] = new Book("Othello","Oliver Rose", 3, 0);
            itemArray[1] = new Book("Julius Ceaser", "William Shakespeare", 6, 3);

            Student Ben = new Student("Ben Stiller", 19, 16);
            Ben.borrowBook(secondBook);

            Console.WriteLine(secondBook.AvailCopies);


            BookLibrary lib = new BookLibrary();
            lib.ItemList.Add(new Book("Hard Times", "Charles Dickens", 4, 2));
            lib.ItemList.Add(new Book("Tom Sawyer", "Mark Twain", 3, 1));
            lib.ItemList.Add(new Book("Hucklebery Finn", "Mark Twain", 4, 2));
            lib.ItemList.Add(new Book("Treasure Island", "Louis Stevenson", 5, 3));
            for (int i = 0; i < lib.ItemList.Count(); i++)
            {
                Console.WriteLine("{0}", lib.ItemList[i].Title);
            }
            

        }
    }
}
*/