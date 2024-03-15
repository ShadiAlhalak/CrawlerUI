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

        public static string GetAllElemScriptPath()
        {
            return ModConstant.cnst_GetAllElem_ScriptFileName + ModConstant.cnst_js_Extention;
        }

        public static string GetAppDataPath()
        {
            string AppData = string.Empty;
            try
            {
                AppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), VersionInfo.ProdactName);
                if (!Directory.Exists(AppData))
                {
                    Directory.CreateDirectory(AppData);
                }
            }
            catch (Exception)
            {
                //Must add log
            }
            return AppData;
        }

        public static string GetSettingsFolderPath()
        {
            string SettingsFolder = string.Empty;
            try
            {
                SettingsFolder = Path.Combine(GetAppDataPath(), ModConstant.cnst_SettingsFolder);
                if (!Directory.Exists(SettingsFolder))
                {
                    Directory.CreateDirectory(SettingsFolder);
                }
            }
            catch (Exception ex)
            {
                //Must add log
            }
            return SettingsFolder;
        }

        public static string GetTempFolderPath()
        {
            string TempFolder = string.Empty;
            try
            {
                TempFolder = Path.Combine(GetAppDataPath(), ModConstant.cnst_TempFolder);
                if (!Directory.Exists(TempFolder))
                {
                    Directory.CreateDirectory(TempFolder);
                }
            }
            catch (Exception ex)
            {
                //Must add log
            }
            return TempFolder;
        }

        public static string GetSettingsFilePath()
        {
            return Path.Combine(GetSettingsFolderPath(), ModConstant.cnst_SettingsFolder + ModConstant.cnst_xml_Extention);
        }

        public static string GetHtmlTextTempFile()
        {
            string HtmlTextTempFile = string.Empty;
            try
            {
                string TempFolder = GetTempFolderPath();
                if (!string.IsNullOrEmpty(TempFolder))
                {
                    HtmlTextTempFile = Path.Combine(TempFolder, ModConstant.cnst_HtmlTextFile + ModConstant.cnst_html_Extention);
                }
            }
            catch (Exception)
            {
                //Must add log
                HtmlTextTempFile = string.Empty;
            }
            return HtmlTextTempFile;
        }

        public static string GetGeneralOutputFolder(ref string ErrorMessage)
        {
            string outputFolder = string.Empty;
            try
            {
                clsSettings settings = clsSettings.loadSettings(ref ErrorMessage);
                if (settings is null || string.IsNullOrEmpty(settings.OutputFolder))
                {
                    outputFolder = Path.Combine(GetAppDataPath(), ModConstant.cnst_OutputFolder);
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }
                    settings.OutputFolder = outputFolder;
                    ErrorMessage = string.Empty;
                    settings.SaveSettings(ref ErrorMessage);
                }
                else
                {
                    outputFolder = settings.OutputFolder;
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);

                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return outputFolder;
        }

        public static string GetSessionOutPutFolder(ref string ErrorMessage)
        {
            string SessionFolder = string.Empty;
            try
            {
                SessionFolder = Path.Combine(GetGeneralOutputFolder(ref ErrorMessage), ModGeneral.GetTimeDateNow());
                if (!Directory.Exists(SessionFolder))
                {
                    Directory.CreateDirectory(SessionFolder);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return SessionFolder;
        }

        public static string GetSessionTrainingFolder(ref string ErrorMessage)
        {
            string TrainingFolder = string.Empty;
            try
            {
                TrainingFolder = Path.Combine(GetSessionOutPutFolder(ref ErrorMessage), ModConstant.cnst_TrainingFilesFolder);
                if (!Directory.Exists(TrainingFolder))
                {
                    Directory.CreateDirectory(TrainingFolder);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return TrainingFolder;
        }

        public static string GetSessionResultFolder(ref string ErrorMessage)
        {
            string ResultFolder = string.Empty;
            try
            {
                ResultFolder = Path.Combine(GetSessionOutPutFolder(ref ErrorMessage), ModConstant.cnst_ResultFolder);
                if (!Directory.Exists(ResultFolder))
                {
                    Directory.CreateDirectory(ResultFolder);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return ResultFolder;
        }
    }
}
