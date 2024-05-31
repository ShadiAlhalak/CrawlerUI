using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace LibStructure
{
    public class clsHtmlElem
    {
        public string Key;
        public string Id;
        public string ClassName;
        public string Value;
        public string tagName;
        public string href;
        public string ObjectToString()
        {
            string HtmlElem = string.Empty;
            try
            {
                HtmlElem = $"Id: {this.Id}    , ClassName: {this.ClassName}    , Tag: {this.tagName}     , Value: {this.Value}     , href: {this.href}\n";
            }
            catch (Exception ex)
            { }

            return HtmlElem;
        }

        public static bool SerializeHtmlElementsToFile(List<clsHtmlElem> HtmlElements, string FilePath, ref string ErorMessage)
        {
            bool Done = true;
            try
            {
                var serializer = new XmlSerializer(typeof(List<clsHtmlElem>));
                using (var writer = XmlWriter.Create(FilePath))
                {
                    serializer.Serialize(writer, HtmlElements);
                }
            }
            catch (Exception ex)
            {
                ErorMessage = ex.Message;
                Done = false;
            }
            return Done;
        }

        public static List<clsHtmlElem> LoadHtmlElementsFromFile(string FilePath, ref string ErrorMessage)
        {
            List<clsHtmlElem> lstElements = new List<clsHtmlElem>();
            try
            {
                string SettingsFilePath = FilePath;
                var serializer = new XmlSerializer(typeof(List<clsHtmlElem>));
                using (var reader = XmlReader.Create(SettingsFilePath))
                {
                    lstElements = serializer.Deserialize(reader) as List<clsHtmlElem>;
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
