using System;
using System.Collections.Generic;
using System.Text;

namespace RanguniaLibrary.com
{
    public class BookIssue
    {
        public string _name;
        public int _id;
        public int _date;
        public int _issueDate;
        public int _lastDate;
        public string _bookName;
        public int _bookNo;
        string msg;
        public BookIssue(string name,int id,int date,int issueDate,int lastDate,string bookName,int bookNo)
        {
            _name = name;
            _id = id;
            _date = date;
            _issueDate = issueDate;
            _lastDate = lastDate;
            _bookName = bookName;
            _bookNo = bookNo;
        }

        public override string ToString()
        {
            if (_lastDate < _issueDate)
            {
                msg = $"you are almoste late.your book return last date{_lastDate} but you return it {_issueDate}";
            }
            return msg;
        }

    }
}
