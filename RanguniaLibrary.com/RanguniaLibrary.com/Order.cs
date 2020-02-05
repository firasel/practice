using System;
using System.Collections.Generic;
using System.Text;

namespace RanguniaLibrary.com
{
    public class Order:Available
    {
        public string _name;
        public string _id;

        public Order()
        {
            _bookName = "c#";
            _bookNo = 0001;
        }
        public override string ToString()
        {
            return $"Available Books:\n\tBook Name:{_bookName}\n\tBook NO:{_bookNo}";
        }
    }
}
