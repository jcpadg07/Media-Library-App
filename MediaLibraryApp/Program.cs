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
            Album album2 = new Album("The Wall", "Pink Floyd");
            Album album3 = new Album("Get Rich or Die Tryin", "50 Cent");

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());

            album.Loan("Joe Smith");
            album2.Loan();

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());

            album.Return();
            album2.Return();

            Console.WriteLine(album.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());

            Console.ReadLine();





            //Book book = new Book("1984", "George Orwell");


            //Console.WriteLine("The book " + book.Title + " was written by " + book.Author + ".");

            //Console.WriteLine("The album " + album.Name + " by " + album.Band + ".");

            //album.Name = "Reflektor";
            //album.Band = "Arcade Fire";

            //Console.WriteLine("The album " + album.Name + " by " + album.Band + ".");

            //Console.ReadLine();

        }
    }
}
