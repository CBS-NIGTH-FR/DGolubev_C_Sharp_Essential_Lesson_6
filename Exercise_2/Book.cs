using System;
using System.IO;

namespace Exercise_2
{
     class Book
    {
        public StreamReader Text { get; set; }
        
        public Book(string path)
        {
            Text = new StreamReader(path);
        }
    }
}
