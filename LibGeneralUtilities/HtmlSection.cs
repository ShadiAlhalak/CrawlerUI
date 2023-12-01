using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneralUtilities
{
    public class HtmlSection
    {
        public int Start { get; set; }
        public int End { get; set; }

        public HtmlSection()
        {
        }

        public HtmlSection(int Start, int End)
        {
            this.Start = Start;
            this.End = End;
        }
    }
}
