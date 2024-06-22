using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace LibHtmlSplitter
{
    public class clsElements
    {
        public List<clsElement> LstElements { get; set; } = new List<clsElement>();

        public static string ElementsFilePath()
        {
            string filepath = "Elements.xml";
            return filepath;
        }

        public void SaveElements()
        {
            string filePath = ElementsFilePath();
            XmlSerializer serializer = new XmlSerializer(typeof(clsElements));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static clsElements? GetElements()
        {
            string filePath = ElementsFilePath();
            XmlSerializer serializer = new XmlSerializer(typeof(clsElements));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return serializer.Deserialize(reader) as clsElements;
            }
        }

        public void SaveAsCSV(string csvPath)
        {
            using (StreamWriter writer = new StreamWriter(csvPath))
            {
                // Write header row with property names
                string header = string.Join(",", typeof(clsAIElem).GetProperties().Select(p => p.Name));
                writer.WriteLine(header);

                foreach (clsElement element in this.LstElements)
                {
                    element.Element = element.Element.Replace("\n", "###").Replace("\r\n", "###");
                    element.TextContent = element.TextContent.Replace("\n", "###").Replace("\r\n", "###");
                }

                List<clsAIElem> AIElems = new List<clsAIElem>();
                foreach (clsElement item in this.LstElements)
                {
                    clsAIElem aIElem = new clsAIElem();
                    aIElem.Guid = item.Guid;
                    aIElem.ParentGuid = item.ParentGuid;
                    aIElem.Tag = item.Tag;
                    aIElem.Id = item.Id;
                    aIElem.ClassName = item.ClassName;
                    aIElem.Start = item.Start;
                    aIElem.End = item.End;
                    aIElem.TextContent = item.TextContent;
                    aIElem.FieldName = item.FieldName;
                    AIElems.Add(aIElem);
                }
                //// Write object data, properly handling potential commas within values
                //foreach (clsElement element in this.LstElements)
                //{
                //    string line = string.Join(",", typeof(clsElement).GetProperties()
                //                                        .Select(p => p.GetValue(element).ToString().Contains(",")
                //                                                  ? string.Format("\"{0}\"", p.GetValue(element))  // Enclose in quotes if comma exists
                //                                                  : p.GetValue(element).ToString()));
                //    writer.WriteLine(line);
                //}

                // Write object data, properly handling potential commas within values
                foreach (clsAIElem element in AIElems)
                {
                    string line = string.Join(",", typeof(clsAIElem).GetProperties()
                                                        .Select(p => p.GetValue(element).ToString().Contains(",")
                                                                  ? string.Format("\"{0}\"", p.GetValue(element))  // Enclose in quotes if comma exists
                                                                  : p.GetValue(element).ToString()));
                    writer.WriteLine(line);
                }

            }
        }
    }
}
