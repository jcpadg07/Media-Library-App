using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    class Book : MediaType
    {
        
        public string Author;
        //private string protagonist;

        public Book(string title, string author) : base(title)
        {
            
            Author = author;
            //Protagonist = protagonist;

        }

        public string GetDisplayText()
        {
            return "The book " + Title + " was written by " + Author + ".";
        }

    }
}
