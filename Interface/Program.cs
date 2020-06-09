using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = null;

            string option = "0";

            
            Console.WriteLine("1. Read .txt file");
            Console.WriteLine("2. Read .xml file");

            Console.WriteLine("Your option is: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                reader = new TxtCars();
            }
            else if(option == "2")
            {
                reader = new XMLCars();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            reader.Read();

        }
    }
}
