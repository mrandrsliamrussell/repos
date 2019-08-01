using System;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace lab67_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n first xml example\n\n");
            var xml01 = new XElement("testdata01",1);
            Console.WriteLine(xml01);


            Console.WriteLine("\n\n add a sub element  \n\n");
            var xml02 = new XElement("testdata01", new XElement("XMLDATA",100));
            Console.WriteLine(xml02);

            Console.WriteLine("\n\n add multiple elements  \n\n");
            var xml03 = new XElement("testdata01" ,
                new XElement("XMLDATA", 100),
                new XElement("XMLDATA", 200),
                new XElement("XMLDATA", 300),
                new XElement("XMLDATA", 400)
                
                );
            Console.WriteLine(xml03);


            //write to xml document
            Console.WriteLine("\n\n save as file\n\n");
            var doc03 = new XDocument(xml03);
            doc03.Save("doc03.xml");

            Console.WriteLine(File.ReadAllText("doc03.xml"));

            
            
            
            //element is the <TAG>
            //attribute is the value inside tag
            //<tax item=500>

            Console.WriteLine("\n\n add attributes  \n\n");
            var xml04 = new XElement("testdata01",
                new XElement("XMLDATA", new XAttribute("height",300) , 100),
                new XElement("XMLDATA", new XAttribute("height", 400), 400),
                new XElement("XMLDATA", new XAttribute("height", 600), 500),
                new XElement("XMLDATA", new XAttribute("height", 700), 700)

                );
            Console.WriteLine(xml04);
            //thin of your data in edatabase table
            //xml root is name of tablr
            //xml attribute is the name of a field with the value
            //xml data is individual entry in the database
        }
    }
}
