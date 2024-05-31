using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibHtmlSplitter
{
    public class clsElement
    {
        public string Guid { get; set; } = string.Empty;
        public string ParentGuid { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Element { get; set; } = string.Empty;
        public string TextContent { get; set; } = string.Empty;
        public int Start { get; set; }
        public int End { get; set; }
        public int Length { get { return End - Start + 1; } }

        //AI
        public bool HasData { get; set; } = false;
        public string FieldName { get; set; } = string.Empty;
    }
}
