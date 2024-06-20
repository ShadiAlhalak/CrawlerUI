using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft;
namespace LibStructure
{
    public class clsHtmlElems
    {
        public List<clsHtmlElem> Elements { get; set; } = new List<clsHtmlElem>();

        public static bool SerializeHtmlElementsToFile(clsHtmlElems HtmlElements, string FilePath, ref string ErorMessage)
        {
            bool Done = true;
            try
            {
                string serializer = Newtonsoft.Json.JsonConvert.SerializeObject(HtmlElements, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(FilePath,serializer);
            }
            catch (Exception ex)
            {
                ErorMessage = ex.Message;
                Done = false;
            }
            return Done;
        }
        public static clsHtmlElems LoadHtmlElementsFromFile(string FilePath, ref string ErrorMessage)
        {
            clsHtmlElems lstElements = new clsHtmlElems();
            try
            {
                if (!string.IsNullOrEmpty(FilePath) && File.Exists(FilePath))
                {
                    string JsonString = File.ReadAllText(FilePath);
                    lstElements = Newtonsoft.Json.JsonConvert.DeserializeObject<clsHtmlElems>(JsonString);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return lstElements;
        }
    }
}
