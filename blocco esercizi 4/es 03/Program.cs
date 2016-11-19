using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

class Test
{
    static void Main()
    {

        StreamReader reader = new StreamReader("..\\..\\XML.xml");
        string response = reader.ReadToEnd();
        XDocument doc = XDocument.Parse(response);

        Console.WriteLine(response);
        
    }
}

/*
       

*/
