using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Libary
{
    [Serializable()]
    class BookLibrary
    {
        public List<LibaryItem> ItemList;//this holds the collection of items for the library.
        public List<Student> studentList;//this holds the collection of students for the library.
        public BookLibrary()
        {
            ItemList = new List<LibaryItem>();
            studentList = new List<Student>();
        }

        
        public void AddItem()//this allows the user to add a item to the program.
        {
            Console.WriteLine("Please enter B for books, J for Journals or C for CD. Enter ? for help.");
            string resultString = "This item has not been added successfully";

            char letter = 'X';
            letter = EnterUserCommandChar(ref resultString);//Its the error checking function it works because it has a try catch that makes sure that no invalid format can crash the program.
            
            //reacts to user enter choice.
            if (letter == '?')
            {
                var help = new OnScreenHelp();
                help.showAddItemsHelp();
                Console.WriteLine("Please enter B for books, J for Journals or C for CD.");

                letter = EnterUserCommandChar(ref resultString);
            }
            if (letter == 'B' || letter == 'b')
            {
                Console.WriteLine("Please enter the title");
                string newTitle = Console.ReadLine();
                Console.WriteLine("Please enter the author");
                string newAuthor = Console.ReadLine();
                Console.WriteLine("Please enter the number of copies");
                int newCopies = EnterUserCommandInt(ref resultString);
                if (newCopies != -1)
                {
                    int newAvailCopies = newCopies;
                    ItemList.Add(new Book(newTitle, newAuthor, newCopies, newAvailCopies));
                    resultString = "This item has been added";
                }
            }

            if (letter == 'J' || letter == 'j')
            {
                Console.WriteLine("Please enter the title");
                string newTitle = Console.ReadLine();
                Console.WriteLine("Please enter the publisher");
                string newPublisher = Console.ReadLine();
                Console.WriteLine("Please enter the date");
                int newDate = EnterUserCommandInt(ref resultString);
                Console.WriteLine("Please enter the number of copies");
                int newCopies = EnterUserCommandInt(ref resultString);
                if (newDate != -1 && newCopies != -1)
                {
                    int newAvailCopies = newCopies;
                    ItemList.Add(new Journal(newDate, newPublisher, newTitle, newCopies, newAvailCopies));
                    resultString = "This item has been added";
                }
               
            }

            if (letter == 'C' || letter == 'c')
            {
                Console.WriteLine("Please enter the title");
                string newTitle = Console.ReadLine();
                Console.WriteLine("Please enter the artist");
                string newArtist = Console.ReadLine();
                Console.WriteLine("Please Enter the Playing time");
                int newPlayingtimeinhours = EnterUserCommandInt(ref resultString);
                Console.WriteLine("Please enter the number of tracks");
                int newNumberofTracks = EnterUserCommandInt(ref resultString);
                Console.WriteLine("Please enter the number of copies");
                int newCopies = EnterUserCommandInt(ref resultString);
                if (newPlayingtimeinhours != -1 && newNumberofTracks != -1 && newCopies != -1)
                {
                    int newavialCopies = newCopies;
                    ItemList.Add(new CD(newTitle, newPlayingtimeinhours, newArtist, newNumberofTracks, newavialCopies, newCopies));
                    resultString = "This item has been added";
                }
              
            }
            Console.WriteLine(resultString);
        }

        private static char EnterUserCommandChar(ref string resultString)
        {
            char letter = 'X';
            try
            {
                letter = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception)
            {
                resultString = "That wasn't a valid command.";
            }
            return letter;
        }

        private static int EnterUserCommandInt(ref string resultString)
        {
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                resultString = "That wasn't a valid command.";
                number = -1;
            }
            return number;
        }

        public void SerializeItems(List<LibaryItem> itemList)
        {
            string fileName = "\\data.bin";
            fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, ItemList);
                }
            }
            catch (IOException)
            {
            }

        }
        public void UpdateItem()//this saves the item, so the user can access the item when they turn the program on and off
        {
            var help = new OnScreenHelp();
            help.showUpdateItemHelp();

            SerializeItems(ItemList);
        }
        public void LoadItems()//this loads the items from the data.bin so they can use items they upated befour they closed the program. It calls the DeserialzeItems method to do this.
        {
            var help = new OnScreenHelp();
            help.showLoadItemHelp();

            DesrializeItems();
        }
        public void DesrializeItems()//this is the method that acctualy loads the item.
        {
            string fileName = "\\data.bin";
            fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var itemList = (List<LibaryItem>)bin.Deserialize(stream);
                    for( int  i = 0;i < itemList.Count(); i++)
                    {
                        itemList[i].toString();
                    }
                }
            }
            catch (IOException)
            {
            }
        }
        public void RemoveItem()//this removes a item selected by the user.
        {
            string resultString = "This item was not removed correctly";
            Console.WriteLine("Please enter the title, enter ? for help.");
            string newTitle = Console.ReadLine();
            if (newTitle == "?")
            {
                var help = new OnScreenHelp();
                help.showRemoveItemHelp();
                Console.WriteLine("Please enter the title.");
                newTitle = Console.ReadLine();
            }
            for (int i = 0; i < ItemList.Count(); i++)
            {
                string title = ItemList[i].Title;
                if (title == newTitle)
                {
                    ItemList.RemoveAt(i);
                    resultString = "This item has been successfully deleted";
                }
            }
            Console.WriteLine(resultString);
        }

        public void ViewItem()//this views all items in the program.
        {
            for (int i = 0; i < ItemList.Count(); i++)
            {
                ItemList[i].toString();
            }
        }
        
        public void AddStudents()//this method allows the user to add students to the program.
        {
            string resultString = "This student was not added correctly";
            Console.WriteLine("Please enter the name of the student, press ? for help.");
            string newName = Console.ReadLine();

            if (newName == "?")
            {
                var help = new OnScreenHelp();
                help.showAddItemsHelp();
                Console.WriteLine("Please enter the name of the student.");
                newName = Console.ReadLine();
            }

            Console.WriteLine("Please enter the student id");
            int newID = EnterUserCommandInt(ref resultString);

            Console.WriteLine("Please enter the student age");
            int newAge = EnterUserCommandInt(ref resultString);
            studentList.Add(new Student(newName, newID, newAge));
            resultString = "This student has been successfully added";
            Console.WriteLine(resultString);


        }
      
        public void RemoveStudents()//this is allows the user to remove students from the program.
        {
            string  resultString = "The student was not removed correctly";
            Console.WriteLine("Please enter the student id, enter ? for help.");

            string userInput = Console.ReadLine();
            if (userInput == "?")
            {
                var help = new OnScreenHelp();
                help.showRemoveStudentHelp();
                 Console.WriteLine("Please enter the student id.");
                 userInput = Console.ReadLine();

            }
            int newID = EnterUserCommandInt(ref resultString);
            for (int i = 0; i < studentList.Count(); i++)
            {
                int id = studentList[i].ID;
                if (id == newID)
                {
                    studentList.RemoveAt(i);
                    resultString = "This student has been successfully removed";
                }
            }
            Console.WriteLine(resultString);
        }

        public void ViewStudents()//this method allows the user to view all the students in the program.
        {
            
                        for (int i = 0; i < studentList.Count(); i++)
                        {
                           studentList[i].toString();
                        }
                 
        }
        public void SearchForStudents()//this method allows the user to search for students based on there ID.
        {
            Console.WriteLine("Please enter the student ID, enter ? for help.");
            string resultString = "Item was not searched";

            var userInput = Console.ReadLine();
            if (userInput == "?")
            {
                var help = new OnScreenHelp();
                help.showSearchForStudentHelp();
                Console.WriteLine("Please enter the student ID.");
                userInput = Console.ReadLine();
            }
            int newID = EnterUserCommandInt(ref resultString);
            if (newID != -1)
            {
                int value = 0;
                for (int i = 0; i < studentList.Count(); i++)
                {
                    int id = studentList[i].ID;
                    if (id == newID)
                    {
                        studentList[i].toString();
                        value = 1;
                    }
                }

                if (value == 0)
                {
                    Console.WriteLine("Item not found");
                }
            }
            Console.WriteLine(resultString);
        }

        public void BorrowItem()//this method allows a student to borrow an item, this removes 1 form the available copies.
        {
            Console.WriteLine("Please enter the title, or enter ? for help.");
            string resultString = "Item was not borrowed";
            string newTitle = Console.ReadLine();
            if (newTitle == "?")
            {
                var help = new OnScreenHelp();
                help.showReturnItemHelp();
                Console.WriteLine("Please enter the title.");
                newTitle = Console.ReadLine();
            }

            Console.WriteLine("Please enter the student id");
            int newID = EnterUserCommandInt(ref resultString);
            if (newID != -1)
            {
                for (int j = 0; j < ItemList.Count(); j++)//loops around every item in the library
                {
                    string title = ItemList[j].Title;
                    if (title == newTitle)//when it finds the title required then loops the student list 
                    {
                        for (int i = 0; i < studentList.Count; i++)//loops student list until it finds the required student.
                        {
                            int id = studentList[i].ID;
                            if (id == newID)//when the student is found it will add the item to their borrowing
                            {
                                studentList[i].borrowBook(ItemList[j]);
                                resultString = "Borrow accepted";
                            }
                        }
                    }

                }
            }
            Console.WriteLine(resultString);
        }

        public void SearchForItems()//this methods allows the user to search for items within the program,they search for the item with the title of the item.
        {
            Console.WriteLine("Please enter the title, or enter ? for help.");
            string newTitle = Console.ReadLine();
            if (newTitle == "?")
            {
                var help = new OnScreenHelp();
                help.showSearchForItemHelp();
                Console.WriteLine("Please enter the title.");
                newTitle = Console.ReadLine();
            }
            int value = 0;
            for (int i = 0; i < ItemList.Count(); i++)
            {
                string title = ItemList[i].Title;
                if (title == newTitle)
                {
                    ItemList[i].toString();
                    value = 1;
                }
            }
            if (value == 0)
            {
                Console.WriteLine("Item not found");
            }
        }

        public void returnItem()//this method allows the user to return items in the program.
        {
            string resultString = "The item was not returned correctly";
            Console.WriteLine("Please enter the title, or enter ? for help");//the user has to enter the title of the item the user was borrowing.
            string newTitle = Console.ReadLine();
            if (newTitle == "?")
            {
                var help = new OnScreenHelp();
                help.showReturnItemHelp();
                Console.WriteLine("Please enter the title.");
                newTitle = Console.ReadLine();
                
            }
            Console.WriteLine("Please enter the student id");//the user has to enter the ID of the student who was borrowing it.
            int newID = EnterUserCommandInt(ref resultString);
            if(newID != -1){
                for (int j = 0; j < ItemList.Count(); j++)
                {
                    string title = ItemList[j].Title;
                    if (title == newTitle)
                    {
                        for (int i = 0; i < studentList.Count; i++)
                        {
                            int id = studentList[i].ID;
                            if (id == newID)
                            {
                                studentList[i].returnItem(ItemList[j]);
                                resultString = "You have successfully returned a copy";
                            }
                        }
                    }
                }
            }
            Console.WriteLine(resultString);
        }
    }
}
