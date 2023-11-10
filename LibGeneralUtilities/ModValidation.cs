using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneralUtilities
{
    public static class ModValidation
    {
        public static string ValidateURL(string URL)
        {
            string ValidURL = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(URL)) return ValidURL;

                //1-Remove http or https 
                string PureUrl = URL.Replace(ModConstant.cnst_HttpsPrefix, string.Empty).Replace(ModConstant.cnst_HttpPrefix, string.Empty);
                PureUrl = PureUrl.Replace(ModConstant.cnst_HttpSuffix, string.Empty);

                //2-Replace charcters
                PureUrl = PureUrl.Replace("/", string.Empty);
                PureUrl = PureUrl.Replace("\\", string.Empty);

                //3-Replaceword Wide Web
                PureUrl = PureUrl.Replace(ModConstant.cnst_WorldWideWeb, string.Empty);

                //4-Check if .com .net etc is exist
                string DotCom = ModConstant.cnst_comertialSite;
                if (PureUrl?.Substring(PureUrl.Length - 4, 1) == ".")
                {
                    DotCom = PureUrl.Substring(PureUrl.Length - 4, 4);
                    PureUrl = PureUrl.Replace(DotCom, string.Empty);
                }
                else
                {
                    PureUrl = PureUrl.Replace(".", string.Empty);
                }
                //5-Rebuild URl
                if (!string.IsNullOrEmpty(PureUrl))
                {
                    ValidURL = string.Concat(ModConstant.cnst_HttpsPrefix, ModConstant.cnst_HttpSuffix, ModConstant.cnst_WorldWideWeb, PureUrl, DotCom + "/");
                }
            }
            catch (Exception)
            {

            }
            return ValidURL;
        }

        public static string GetSiteName(string URL)
        {
            string SiteName = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(URL)) return SiteName;

                //1-Remove http or https 
                SiteName = URL.Replace(ModConstant.cnst_HttpsPrefix, string.Empty).Replace(ModConstant.cnst_HttpPrefix, string.Empty);
                SiteName = SiteName.Replace(ModConstant.cnst_HttpSuffix, string.Empty);

                //2-Replace charcters
                SiteName = SiteName.Replace("/", string.Empty);
                SiteName = SiteName.Replace("\\", string.Empty);

                //3-Replaceword Wide Web
                SiteName = SiteName.Replace(ModConstant.cnst_WorldWideWeb, string.Empty);

                //4-Check if .com .net etc is exist
                string DotCom = ModConstant.cnst_comertialSite;
                if (SiteName?.Substring(SiteName.Length - 4, 1) == ".")
                {
                    SiteName = SiteName.Replace(DotCom, string.Empty);
                }
                else
                {
                    SiteName = SiteName.Replace(".", string.Empty);
                }
            }
            catch (Exception)
            {
 
            }
            return SiteName;
        }
    }
}
