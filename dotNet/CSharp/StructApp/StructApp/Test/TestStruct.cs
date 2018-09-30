using System;
using System.Collections.Generic;
using System.Text;

namespace StructApp.Test
{
    struct BookStruct
    {
        public string title;
    };

    class BookClass
    {
        public string title;
    }

    class TestStruct
    {
        static void Main(string[] args)
        {
            BookStruct book = new BookStruct();
            book.title = "Chandan";

            BookClass book1 = new BookClass();
            book1.title = "Chandan";

            Console.WriteLine("BeforeChange\nBook Struct: {0}", book.title);
            Console.WriteLine("Book Class: {0}", book1.title);

            changeValue(book,book1);

            Console.WriteLine("AfterChange\nBook Struct: {0}", book.title);
            Console.WriteLine("Book Class: {0}", book1.title);          
        }

        public static void changeValue(BookStruct bookStruct,BookClass bookClass)
        {
            bookStruct.title = "Dharmesh";
            Console.WriteLine(bookStruct.title);
            bookClass.title = "Dharmesh";
        }
    }
}
