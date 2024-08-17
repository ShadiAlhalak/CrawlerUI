using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStructure.API_Request_Body
{
    public class clsSaveDataES
    {
        public string title { get; set; } = string.Empty;
        public List<Pairs> results { get; set; } = new List<Pairs>();
    }
}
