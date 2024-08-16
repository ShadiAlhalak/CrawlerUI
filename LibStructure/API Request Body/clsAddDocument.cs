using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStructure
{
    public class clsAddDocument
    {
        public string description { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public List<string> tags { get; set; } = new List<string>();
        public List<clsAPIFields> fields { get; set; } =  new List<clsAPIFields>();
    }
}
