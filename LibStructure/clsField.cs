using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStructure
{
    public class clsField
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ModEnum.FieldsTypes Type { get; set; } = ModEnum.FieldsTypes.Text;
        public string Description { get; set; } = string.Empty;
    }
}
