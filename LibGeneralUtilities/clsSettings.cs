using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using LibGeneralUtilities;

namespace LibGeneralUtilities
{
    public class clsSettings
    {
        #region Variables
        public string AIServiceUrl { get; set; } = string.Empty;
        public string HomePageUrl { get; set; } = LibGeneralUtilities.ModConstant.HomeUrl;
        public string OutputFolder { get; set; } = string.Empty;
        public string SelectionColor { get; set; } = "BlueViolet";
        #endregion

        #region Methods

        public static clsSettings loadSettings(ref string ErrorMessage)
        {
            clsSettings? Settings = new clsSettings();
            try
            {
                string SettingsFilePath = ModPathes.GetSettingsFilePath();
                if (!File.Exists(SettingsFilePath))
                {
                    ErrorMessage = ModResoucres.cnst_SettingsFileISNotExist;
                    return Settings;
                }
                var serializer = new XmlSerializer(typeof(clsSettings));
                using (var reader = XmlReader.Create(SettingsFilePath))
                {
                    Settings = serializer.Deserialize(reader) as clsSettings;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return Settings;
        }

        public void SaveSettings(ref string ErrorMessage)
        {
            try
            {
                string SettingsFilePath = ModPathes.GetSettingsFilePath();
                var serializer = new XmlSerializer(this.GetType());
                using (var writer = XmlWriter.Create(SettingsFilePath))
                {
                    serializer.Serialize(writer, this);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        #endregion
    }
}