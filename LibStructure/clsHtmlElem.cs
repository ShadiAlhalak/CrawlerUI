using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibStructure
{
    public class clsHtmlElem
    {
        public string Key;
        public string Id;
        public string ClassName;
        public string Value;
        public string tagName;

        public string ObjectToString()
        {
            string HtmlElem = string.Empty;
            try
            {
                HtmlElem = $"Id: {this.Id}    , ClassName: {this.ClassName}    , Tag: {this.tagName}     , Value: {this.Value} \n";
            }
            catch (Exception ex)
            { }

            return HtmlElem;
        }
    }
}
