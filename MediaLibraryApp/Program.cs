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
            Album album = new Album("Z", "My Morning Jacket");

            Book book = new Book("1984", "George Orwell");
           

            Console.WriteLine("The book " + book.Title + " was written by " + book.Author + ".");

            Console.WriteLine("The album " + album.Name + " by " + album.Band + ".");

            album.Name = "Reflektor";
            album.Band = "Arcade Fire";

            Console.WriteLine("The album " + album.Name + " by " + album.Band + ".");

            Console.ReadLine();

        }
    }
}
