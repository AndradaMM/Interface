using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interface
{
    class TxtCars : IReader
    {
        public void Read()
        {
            string content = File.ReadAllText("TxtCars.txt", Encoding.UTF8);
            Console.WriteLine(content);
        }
        
    }
}
