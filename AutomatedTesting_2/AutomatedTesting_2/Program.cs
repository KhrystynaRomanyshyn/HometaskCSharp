using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;

namespace AutomatedTesting_2
{
    class Program
    {
        static void Main()
        {
            string xml = File.ReadAllText("task.xml");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            File.WriteAllText("task.json", jsonText);
            Console.WriteLine(jsonText);

            Console.ReadKey();
        }
    }
}