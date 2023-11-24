using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Book
    {
        private string _title;
        private int _pages;

        public Book() { 
            _title = string.Empty;
            _pages = 0;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == string.Empty)
                {
                    _title = "Unknown";
                }
                else
                {
                    _title = value;
                }
                    ;
            }
        }
        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value < 1)
                {
                    _pages = 1;
                }
                else
                {
                    _pages = value;
                };
            }
        }

        public void Details() {
            Console.WriteLine("Yourr book has a title of " + _title + " and it has " + _pages + " pages");
        }
    }
}
