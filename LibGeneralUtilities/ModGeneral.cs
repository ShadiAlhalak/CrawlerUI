using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneralUtilities
{
    public static class ModGeneral
    {
        public static string GetTimeDateNow()
        {
            string Date = System.DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            return Date;
        }

    }
}
