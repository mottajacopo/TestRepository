using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace es_03
{
    public class Parser
    {
        public string Xml(string path)
        {
            StringBuilder output = new StringBuilder();

            StreamReader xmlFile = new StreamReader(path);
            string input = xmlFile.ReadToEnd();
            XDocument doc = XDocument.Parse(input);
            

            using (XmlReader reader = XmlReader.Create(new StringReader(input)))
            {
                XmlWriterSettings ws = new XmlWriterSettings();
                ws.Indent = true;
                using (XmlWriter writer = XmlWriter.Create(output, ws))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Text:
                                output.Append(reader.Value + "\n");
                                break;
                        }
                    }
                }
            }

            return output.ToString();
        }

        static void Main()
        {
        }
    }
}
