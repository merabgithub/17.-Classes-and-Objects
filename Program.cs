using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); // create a new book objectc, at this point Book is now a data type in c#

            //Creation of first book, you can now create thousands of different books e.g for a library app!
            book1.title = "Harry Potter";
            book1.author = "Jk Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book2.pages);
            //freeze console
            Console.ReadLine();

        }
    }
}
