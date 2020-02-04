using System;
using System.Collections.Generic;
using System.Text;

namespace rokomari.com
{
    public class Product:ProductImage
    {
        //Attribute
        public string _name;
        public string _author;
        public string _productType;
        public string _discription;
        public int _price;
        //Default Constructor
        public Product(string name, string author, string productType,string discription,int price)
        {
            _name = name;
            _author = author;
            _productType = productType;
            _discription = discription;
            _price = price;
        }
        //Default Method
        public override string ToString()
        {
            var prints = $"Book Name: {_name}\nAuthor: {_author}\nBook Type: {_productType}\nDiscription: {_discription}\nPrice: {_price}";
            return prints;
        }
    }
}
