using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneralUtilities
{
    public static class ModPathes
    {
        public static string GetMouseScriptPath()
        {
            return ModConstant.cnst_Mouse_ScriptFileName + ModConstant.cnst_js_Extention;
        }

        public static string GetLinksDisableScriptPath()
        {
            return ModConstant.cnst_LinksDisable_ScriptFileName + ModConstant.cnst_js_Extention;
        }
    }
}
