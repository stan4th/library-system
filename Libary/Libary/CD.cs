using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libary
{
    [Serializable()]
    class CD : LibaryItem
    {
        private double playingtimeinhours;
        private string artist;
        private double numberOfTracks;

        public CD(string newTitle, double newPlayingtimeinhours, string newArtist, int newNumberofTracks, int newavilCopies, int newCopies):
            base(newTitle, newCopies, newavilCopies)
        {
            playingtimeinhours = newPlayingtimeinhours;
            artist = newArtist;
            numberOfTracks = newNumberofTracks;
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
                Console.WriteLine("No CDs available");
            }
        }
       
        public double Playingtimeinhours
        {
            get
            {
                return playingtimeinhours;
            }
            set
            {
                playingtimeinhours = value;
            }
        }
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }
        public double Numberoftracks
        {
            get
            {
                return numberOfTracks;
            }
            set
            {
                numberOfTracks = value;
            }
        }
        public override void toString()
        {
            Console.WriteLine("ID:{0}\nTitle: {1}\nArtist: {2}\nNumber Of Tracks: {3}\nPlay Time: {4}\nTitle Copies: {5}\nAvailble Copies: {6}\n", 0, Title, Artist, Numberoftracks, Playingtimeinhours, Copies, AvailCopies);
        }
    }
}