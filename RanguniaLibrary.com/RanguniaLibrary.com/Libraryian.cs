using System;
using System.Collections.Generic;
using System.Text;

namespace RanguniaLibrary.com
{
    public class Libraryian
    {
        string _libraryianName;
        string _addres;
        string _email;
        int _number;
        public Libraryian(string libraryianName, string addres, string email, int number)
        {
            _libraryianName = libraryianName;
            _addres = addres;
            _email = email;
            _number = number;
        }
        public override string ToString()
        {
            return $"Libraryian Name:{_libraryianName}\nAddres:{_addres}\nEmail:{_email}\nNumber:{_number}";
        }
    }
}
