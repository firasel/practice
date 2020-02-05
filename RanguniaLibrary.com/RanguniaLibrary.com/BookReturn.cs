using System;
using System.Collections.Generic;
using System.Text;

namespace RanguniaLibrary.com
{
    public class BookReturn
    {
        public string _name;
        public int _id;
        public int _returnDate;
        public string _bookName;
        public string _bookNo;

        public BookReturn(string name,int id,int returnDate,string bookName,string bookNo)
        {
            _name = name;
            _id = id;
            _returnDate = returnDate;
            _bookName = bookName;
            _bookNo = bookNo;
        }
    }
}
