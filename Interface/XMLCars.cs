using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Interface
{
    class XMLCars :IReader
    {
        public void Read()
        {
            using (XmlReader reader = XmlReader.Create("XMLCars.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "marca":
                                Console.Write("Marca:" + reader.ReadString() + " ");
                                break;
                            case "model":
                                Console.WriteLine("Model:" + reader.ReadString() + " ");
                                break;
                        }
                    }


                }
            }
        }


    }     
}
