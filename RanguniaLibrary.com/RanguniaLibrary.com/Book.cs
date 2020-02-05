using System;
using System.Collections.Generic;
using System.Text;

namespace RanguniaLibrary.com
{
    public class Book:BookImage
    {
        public string _bookName;
        public string _author;
        public string _bookType;
        public string _bookDetails;
        public int _bookNo;

        public Book(string bookName,string author,string bookType,string bookDetails,int bookNo,string url)
        {
            _bookName = bookName;
            _author = author;
            _bookType = bookType;
            _bookDetails = bookDetails;
            _bookNo = bookNo;
            _url = url;
        }
        public override string ToString()
        {
            return $"Book Name:{_bookName}\nAuthor:{_author}\nBook Type:{_bookType}\nBook Details:{_bookDetails}\nBook No:{_bookNo}\nImage Url:{_url}";
        }
    }
}
