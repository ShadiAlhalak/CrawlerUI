using LibGeneralUtilities;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerUI
{
    public partial class frmSettings : MaterialForm
    {
        #region Variables
        public MaterialMessage Message { get; set; } = new MaterialMessage();
        #endregion

        #region Constractor

        public frmSettings()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        public void LoadSettings()
        {
            try
            {
                foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
                {
                    if (prop.PropertyType.FullName == "System.Drawing.Color")
                    {
                        cmbColor.Items.Add(prop.Name);
                    }
                }

                string ErrorMessage = string.Empty;
                clsSettings Settings = clsSettings.loadSettings(ref ErrorMessage);
                txtAIService.Text = Settings.AIServiceUrl;
                txtHome.Text = Settings.HomePageUrl;
                txtOutput.Text = Settings.OutputFolder;
                cmbColor.SelectedItem = Settings.SelectionColor;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        public void SaveSettings()
        {
            try
            {
                string ErrorMessage = string.Empty;
                clsSettings Settings = new clsSettings();
                Settings.AIServiceUrl = txtAIService.Text;
                Settings.HomePageUrl = txtHome.Text;
                Settings.OutputFolder = txtOutput.Text;
                Settings.SelectionColor = cmbColor.Text;
                //Color color = Color.FromName(cmbColor.Text);

                Settings.SaveSettings(ref ErrorMessage);

                this.Close();
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        #endregion

    }
}
