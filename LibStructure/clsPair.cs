using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStructure
{
    public class clsPair
    {
        [JsonIgnore]
        public int? group { get; set; } = -1;
        public string? Key { get; set; } = string.Empty;
        public string? Value { get; set; } = string.Empty;
        [JsonIgnore]
        public int? order { get; set; } = -1;
        [JsonIgnore]
        public string Page { get; set; } = string.Empty;
    }
}
