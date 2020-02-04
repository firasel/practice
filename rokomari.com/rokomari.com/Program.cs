using System;

namespace rokomari.com
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account
            Account account = new Account();
            account.Name = "Md Rasel";
            account.Number = 01800001111;
            account.Addres = "ctg,rangunia";
            account.EmailAddres ="mdrasel@gmail.com";
            //Account Print
            Console.WriteLine($"{account.Name},{account.Number},{account.Addres},{account.EmailAddres}");


            //Product
            Product product = new Product("js", "john", "programming", "it is programming language book.", 1000);
            //Product Image
            product._url = "c/newfolder/image.jpeg";
            //Product Print
            Console.WriteLine(product.ToString());


            //Order
            Order order = new Order("js book",5,1000,80);
            Console.WriteLine(order.ToString());
        }
    }
}
