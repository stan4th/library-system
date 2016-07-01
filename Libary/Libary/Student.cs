using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary
{
    [Serializable()]
    class Student
    {
        private string name;
        private int id;
        private int age;
        public List<LibaryItem> borrowedItems;//this holds the collection of the student's borrowed items.

        public Student(string newName, int newID, int newAge)
        {
            name = newName;
            id = newID;
            age = newAge;

            borrowedItems = new List<LibaryItem>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public LibaryItem borrows
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void borrowBook(LibaryItem objItem)
        {
            objItem.borrowCopy();
            borrowedItems.Add(objItem);
        }
        public void returnItem(LibaryItem objItem)
        {
            for (int i = 0; i < borrowedItems.Count(); i++)
            {
                if(borrowedItems[i] == objItem)
                {
                    borrowedItems.Remove(objItem);
                    objItem.returnCopy();
                }
            }
        }
        public void toString()
        {
            Console.WriteLine("The name of the student is " + Name + " id of the student is " + ID + " the age of the student is " + Age);
        }
    }
  }

