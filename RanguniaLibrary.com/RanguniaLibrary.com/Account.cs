using System;
using System.Collections.Generic;
using System.Text;

namespace RanguniaLibrary.com
{
    public class Account
    {
        public string _name;
        public int _id;
        public string _addres;
        public string _email;
        public int _number;

        public Account(string name,int id,string addres,string emial,int number)
        {
            _name = name;
            _id = id;
            _addres = addres;
            _email = emial;
            _number = number;
        }
        public override string ToString()
        {
            return $"Name:{_name}\nAddres:{_addres}\nEmail:{_email}\nNumber:{_number}";
        }
    }
}
