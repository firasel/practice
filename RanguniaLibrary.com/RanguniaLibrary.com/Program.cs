using System;

namespace RanguniaLibrary.com
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account
            Account account = new Account("md rasel", 1, "ctg,rangunia", "mdrasel@gmail.com", 01800001111);
            //Print
            Console.WriteLine(account.ToString());

            //Book
            Book book = new Book("c# beginners", "john", "programming", "it is programming language book", 0001, "c/new folder/image.jpeg");
            //Print
            Console.WriteLine(book.ToString());

            //Book Order
            Order order = new Order();
            Console.WriteLine(order.ToString());

            //Book Issue
            BookIssue bookIssue = new BookIssue("sahed",1,1,20,15,"js",0001);
            Console.WriteLine(bookIssue.ToString());

            //Libraryian
            Libraryian libraryian = new Libraryian("jabed","ctg,rangunai","jabed@gmail.com",01400001111);
            //Print
            Console.WriteLine(libraryian.ToString());
        }
    }
}
