using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin2DotNet;
using LibGeneralUtilities;
using LibStructure;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin2DotNet.Controls;
using Microsoft.VisualBasic;
using System.Dynamic;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace CrawlerUI
{
    public partial class frmMain : MaterialSkin2DotNet.Controls.MaterialForm
    {

        #region Variables
        public List<clsHtmlElem> Values { get; set; } = new List<clsHtmlElem>();
        public MaterialMessage Message { get; set; } = new MaterialMessage();
        public string CurrentHtmlText { get; set; } = string.Empty;
        public bool AddZone { get; set; } = false;
        public bool PreventLinks { get; set; } = false;
        public bool IsSideBarOpen { get; set; } = false;
        public bool DarkMode { get; set; } = true;
        public MaterialSkinManager materialSkinManager { get; set; }
        #endregion

        #region Constractor

        public frmMain()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialSkinManager = materialSkinManager = MaterialSkinManager.Instance;
            //Light Mode
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);

            //DarkMode
            PicDarkMode.BackgroundImage = Properties.Resources.moon_39_512;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Refresh();
        }

        #endregion

        #region Events

        #region Brawser events 

        private void btnBrawserHome_Click(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            try
            {
                progBar.Value = 0;
                progTimer.Enabled = true;
                clsSettings settings = clsSettings.loadSettings(ref ErrorMessage);
                if (settings != null && !string.IsNullOrEmpty(settings.HomePageUrl))
                {
                    txtURL.Text = settings.HomePageUrl;
                    WView.Source = new Uri(settings.HomePageUrl);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (WView.CanGoBack)
            {
                progBar.Value = 0;
                progTimer.Enabled = true;
                WView.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (WView.CanGoForward)
            {
                progBar.Value = 0;
                progTimer.Enabled = true;
                WView.GoForward();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                progBar.Value = 0;
                progTimer.Enabled = true;
                WView.Reload();
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                progBar.Value = 0;
                progTimer.Enabled = true;
                string ValidUrl = ModValidation.ValidateURL(txtURL.Text);
                txtURL.Text = ValidUrl;
                WView.Source = new Uri(ValidUrl);
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {
            try
            {
                htmlEditor Editor = null;
                if (string.IsNullOrEmpty(CurrentHtmlText))
                {
                    FileInfo Fileinf = new FileInfo(ModPathes.GetHtmlTextTempFile());
                    if (Fileinf.Exists)
                    {
                        Editor = new htmlEditor(Fileinf);
                    }
                }
                else
                {
                    Editor = new htmlEditor(CurrentHtmlText);
                }
                if (Editor is null)
                {
                    Message.Message = ModResoucres.cnst_InspectThisUrlIsNotPossibleNowTryReloadPage;
                    Message.MessageType = ModResoucres.MsgType_Error;
                    Message.ShowMessage();
                }
                else
                {
                    Editor.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            try
            {
                progBar.Value = 0;
                progTimer.Enabled = true;
                clsSettings settings = clsSettings.loadSettings(ref ErrorMessage);
                if (settings != null && !string.IsNullOrEmpty(settings.HomePageUrl))
                {
                    txtURL.Text = settings.HomePageUrl;
                    WView.Source = new Uri(settings.HomePageUrl);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnExpotLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    string LogFilePath = SaveDialog.FileName;
                    File.AppendAllText(LogFilePath, rchLog.Text);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rchLog.Clear();
        }

        private void LstToolbox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnSwAddValue_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                MaterialSwitch materialSwitch = (MaterialSwitch)sender;
                if (materialSwitch.Checked)
                {
                    AddZone = true;
                    Message.MessageType = ModResoucres.MsgType_Info;
                    Message.Message = ModResoucres.MsgWaitUntilReloadPage + ".\n" + ModResoucres.MsgAddValuesEnabled;
                    Message.ShowMessage();
                    progTimer.Enabled = true;
                    progBar.Value = 0;
                    WView.Reload();
                }
                else
                {
                    AddZone = false;
                    Message.MessageType = ModResoucres.MsgType_Info;
                    Message.Message = ModResoucres.MsgWaitUntilReloadPage + ".\n" + ModResoucres.MsgAddValuesDisabled;
                    Message.ShowMessage();
                    progTimer.Enabled = true;
                    progBar.Value = 0;
                    WView.Reload();
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnSwPrevLinks_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MaterialSwitch materialSwitch = (MaterialSwitch)sender;
                if (materialSwitch.Checked)
                {
                    PreventLinks = true;
                    Message = new MaterialMessage(ModResoucres.MsgPreventLinksEnabled + ".\n" + ModResoucres.MsgWaitUntilReloadPage, ModResoucres.MsgType_Info);
                    Message.ShowMessage();
                }
                else
                {
                    PreventLinks = false;
                    Message = new MaterialMessage(ModResoucres.MsgPreventLinksDisabled + ".\n" + ModResoucres.MsgWaitUntilReloadPage, ModResoucres.MsgType_Info);
                    Message.ShowMessage();
                }
                progTimer.Enabled = true;
                progBar.Value = 0;
                WView.Reload();
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnClearValues_Click(object sender, EventArgs e)
        {
            try
            {
                LstValues.Items.Clear();
                Values.Clear();
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            try
            {
                DarkMode = !DarkMode;
                if (DarkMode)
                {
                    PicDarkMode.BackgroundImage = Properties.Resources.moon_39_512;
                    materialSkinManager.AddFormToManage(this);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    this.Refresh();
                }
                else
                {
                    PicDarkMode.BackgroundImage = Properties.Resources.sun_53_512;
                    materialSkinManager.AddFormToManage(this);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                    this.Refresh();
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void picSettings_Click_1(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.ShowDialog();
        }

        private void pivAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Core

        private void WView_CoreWebView2InitializationCompleted_1(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                //string script = File.ReadAllText("Mouse.js");
                //await WView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(script);
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private async void WView_NavigationCompleted_1(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                txtURL.Text = WView.Source.ToString();
                if (PreventLinks)
                {
                    string LinksDisScrPath = ModPathes.GetLinksDisableScriptPath();
                    string LinksDisableScr = File.ReadAllText(LinksDisScrPath);
                    await WView.CoreWebView2.ExecuteScriptAsync(LinksDisableScr);
                }
                if (AddZone)
                {
                    string MouseScriptPath = ModPathes.GetMouseScriptPath();
                    string script = File.ReadAllText(MouseScriptPath);
                    await WView.CoreWebView2.ExecuteScriptAsync(script);
                }
                //using (HttpClient client = new HttpClient())// actually only one object should be created by Application
                //{
                //    CurrentHtmlText = await client.GetStringAsync(txtURL.Text);
                //    File.WriteAllText(ModPathes.GetHtmlTextTempFile(), CurrentHtmlText);
                //}
                progTimer.Enabled = false;
                progBar.Value = 100;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private async void WView_WebMessageReceived_1(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                clsHtmlElem? jsonObject = JsonConvert.DeserializeObject<clsHtmlElem>(e.WebMessageAsJson);
                if (jsonObject is null) return;

                rchLog.AppendText(jsonObject?.ObjectToString());
                rchLog.ScrollToCaret();
                switch (jsonObject?.Key)
                {
                    case "click":
                        LstValues.AddItem(jsonObject?.Value);
                        Values.Add(jsonObject);
                        break;
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            try
            {
                rchLog.AppendText(ModResoucres.cnst_LogSeparatour);
                rchLog.ScrollToCaret();
                rchLog.AppendText(ModResoucres.cnst_StartProcessing);
                //1-Get Training output folder path
                string TrainingFolder = ModPathes.GetSessionTrainingFolder(ref ErrorMessage);

                //2-Full html file
                string fullhtml;
                ////* Try somthing
                using (HttpClient client = new HttpClient())// actually only one object should be created by Application
                {
                    fullhtml = await client.GetStringAsync(txtURL.Text);
                }

                //string fullhtml;
                //// obtain some arbitrary html....
                //using (var client = new WebClient())
                //{
                //    fullhtml = client.DownloadString(txtURL.Text);
                //}
                //// use the html agility pack: http://www.codeplex.com/htmlagilitypack
                //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                //doc.LoadHtml(html);
                //StringBuilder sb = new StringBuilder();
                //foreach (HtmlTextNode node in doc.DocumentNode.SelectNodes("//text()"))
                //{
                //    sb.AppendLine(node.Text);
                //}
                //string final = sb.ToString();

                //*
                //string GetAllElemPath = ModPathes.GetAllElemScriptPath();
                //string GetAllElemScr = File.ReadAllText(GetAllElemPath);
                //var fullhtml = await WView.CoreWebView2.ExecuteScriptAsync("document.documentElement.textContent");
                //var fullhtml = await WView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
                string SiteName = ModValidation.GetSiteName(txtURL.Text);
                string FullHtmlFilePath = Path.Combine(TrainingFolder, SiteName + ModConstant.cnst_html_Extention);
                if (!string.IsNullOrEmpty(SiteName))
                {
                    File.WriteAllText(FullHtmlFilePath, fullhtml);
                    //htmlSplitter.SplitHtml(fullhtml);
                }
                rchLog.AppendText(ModResoucres.cnst_FullHtmlFileHasBeenWritten);

                //3-Serialize Values list to file
                string ResultFilePath = Path.Combine(TrainingFolder, ModConstant.cnst_ValuesFileName + ModConstant.cnst_xml_Extention);
                clsHtmlElem.SerializeHtmlElementsToFile(Values, ResultFilePath, ref ErrorMessage);
                rchLog.AppendText(ModResoucres.cnst_ValuesFileHasBeenWritten);
                rchLog.AppendText(ModResoucres.cnst_LookAtTheOutputFolder);
                rchLog.AppendText(ModResoucres.cnst_ProcessingFinish);
                rchLog.AppendText(ModResoucres.cnst_LogSeparatour);
                rchLog.ScrollToCaret();
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }


        #endregion

        #endregion

        #region Methods

        #endregion

        private void progTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (progBar.Value < 90)
                {
                    progBar.Value += progBar.Step;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
