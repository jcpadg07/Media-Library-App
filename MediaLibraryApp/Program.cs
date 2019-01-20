using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album("Z", "My Morning Jacket", "Religious experience/Expand-your-mind rock");

            Book book = new Book("1984", "Orson Wells", "Winston");
           

            Console.WriteLine("The book " + book.title + " was written by " + book.author + ".");

            Console.WriteLine("The album " + album.name + " by " + album.band + ".");

            Console.ReadLine();

        }
    }
}
