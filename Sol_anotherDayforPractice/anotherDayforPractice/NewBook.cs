using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anotherDayforPractice
{
    internal class NewBook
    {
        public string title;
        public string author;
        public int pages;

        public NewBook()
        {

        }

        public NewBook(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            Console.WriteLine("{0} {1} {2}", title, author, pages);
        }

        public bool JkRowlling()
        {
            if (author == "Jk Rowling")
            {
                return true;
            }
            return false;
        }
    }
}
