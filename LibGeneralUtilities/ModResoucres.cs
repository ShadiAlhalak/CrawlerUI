using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneralUtilities
{
    public static class ModResoucres
    {
        #region Messages
        public const string MsgWaitUntilReloadPage = "Wait until reload page";
        public const string MsgPreventLinksEnabled = "Prevent Links Enabled";
        public const string MsgPreventLinksDisabled = "Prevent Links Disabled";
        public const string MsgAddValuesEnabled = "Add Values Enabled";
        public const string MsgAddValuesDisabled = "Add Values Disabled";
        public const string cnst_FullHtmlSavedDone = "Fullhtml saved done";
        public const string cnst_SettingsFileISNotExist = "Settings file is not exist.";

        #endregion

        #region Log
        public const string cnst_LogSeparatour = "------------\n";
        public const string cnst_StartProcessing = "Start processing...\n";
        public const string cnst_FullHtmlFileHasBeenWritten = "Full html file has been written\n";
        public const string cnst_ValuesFileHasBeenWritten = "Values file has been written\n";
        public const string cnst_LookAtTheOutputFolder = "Lookup at output folder\n";
        public const string cnst_ProcessingFinish = "Processing finish.\n";
        #endregion

        #region MessageTypes
        public const string MsgType_Error = "Error Message";
        public const string MsgType_Info = "Information Message";
        #endregion

    }
}