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
using LibHtmlSplitter;
using System.Diagnostics;
using LogManagment;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace CrawlerUI
{
    public partial class frmMain : MaterialSkin2DotNet.Controls.MaterialForm
    {

        #region Variables
        public List<clsHtmlElem> Values { get; set; } = new List<clsHtmlElem>();
        public MaterialMessage Message { get; set; } = new MaterialMessage();
        public string? CurrentHtmlText { get; set; } = string.Empty;
        public bool AddZone { get; set; } = false;
        public bool PreventLinks { get; set; } = false;
        public bool MouseHover { get; set; } = false;
        public bool EnableScrolling { get; set; } = false;
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

            materialSkinManager = MaterialSkinManager.Instance;
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
            FillFields();
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

        private async void btnInspect_Click(object sender, EventArgs e)
        {
            try
            {
                string htmlwebv2 = await WView.ExecuteScriptAsync("document.documentElement.outerHTML");
                string? Deshtml = System.Text.Json.JsonSerializer.Deserialize<string>(htmlwebv2);
                CurrentHtmlText = Deshtml; // modHtmlTextProcessing.PreProcessingHtml(Deshtml);
                await Task.Run(() =>
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
                 });
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
                    //Message.MessageType = ModResoucres.MsgType_Info;
                    //Message.Message = ModResoucres.MsgWaitUntilReloadPage + ".\n" + ModResoucres.MsgAddValuesEnabled;
                    //Message.ShowMessage();
                    //progTimer.Enabled = true;
                    //progBar.Value = 0;
                    //WView.Reload();
                }
                else
                {
                    AddZone = false;
                    //Message.MessageType = ModResoucres.MsgType_Info;
                    //Message.Message = ModResoucres.MsgWaitUntilReloadPage + ".\n" + ModResoucres.MsgAddValuesDisabled;
                    //Message.ShowMessage();
                    //progTimer.Enabled = true;
                    //progBar.Value = 0;
                    //WView.Reload();
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
                }
                else
                {
                    PreventLinks = false;
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnHover_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSwitch materialSwitch = (MaterialSwitch)sender;
            if (materialSwitch.Checked)
            {
                MouseHover = true;
            }
            else
            {
                MouseHover = false;
            }
        }

        private void btnSwScrolling_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSwitch materialSwitch = (MaterialSwitch)sender;
            if (materialSwitch.Checked)
            {
                EnableScrolling = true;
            }
            else
            {
                EnableScrolling = false;
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
                //throw;
            }
        }

        private void btnApplyTools_Click(object sender, EventArgs e)
        {
            ExecuteScripts();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LstValues.Count > 0 && Values.Count > 0 && LstValues.SelectedIndex >= 0)
                {
                    Values.RemoveAt(LstValues.SelectedIndex);
                    LstValues.RemoveItemAt(LstValues.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnInitialData_Click(object sender, EventArgs e)
        {
            try
            {
                frmInitialData frmInitialdata = new frmInitialData(Values, clsFields.GetFields());
                frmInitialdata.ShowDialog();
                if (frmInitialdata.RequestedElements.Count > 0)
                {
                    Values = frmInitialdata.RequestedElements;
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
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
                //if (PreventLinks && AddZone)
                //{
                //    string LinksDisScrPath = ModPathes.GetLinksDisableScriptPath();
                //    string LinksDisableScr = File.ReadAllText(LinksDisScrPath);

                //    string MouseScriptPath = ModPathes.GetMouseScriptPath();
                //    string script = File.ReadAllText(MouseScriptPath);

                //    LinksDisableScr += "\n" + script;
                //    await WView.CoreWebView2.ExecuteScriptAsync(LinksDisableScr);
                //}
                //else if (PreventLinks)
                //{
                //    string LinksDisScrPath = ModPathes.GetLinksDisableScriptPath();
                //    string LinksDisableScr = File.ReadAllText(LinksDisScrPath);
                //    await WView.CoreWebView2.ExecuteScriptAsync(LinksDisableScr);
                //}
                //else if (AddZone)
                //{
                //    string MouseScriptPath = ModPathes.GetMouseScriptPath();
                //    string script = File.ReadAllText(MouseScriptPath);
                //    await WView.CoreWebView2.ExecuteScriptAsync(script);
                //}
                ////using (HttpClient client = new HttpClient())// actually only one object should be created by Application
                ////{
                ////    CurrentHtmlText = await client.GetStringAsync(txtURL.Text);
                ////    File.WriteAllText(ModPathes.GetHtmlTextTempFile(), CurrentHtmlText);
                ////}
                //progTimer.Enabled = false;
                //System.Threading.Thread.Sleep(1000);
                progBar.Value = 100;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
                progBar.Value = 100;
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
                        string RealValue = string.Empty;
                        if (jsonObject.Value != string.Empty)
                        {
                            RealValue = "Text: " + jsonObject.Value;
                            RealValue += jsonObject.href != string.Empty ? " || Href: " + jsonObject.href : string.Empty;
                        }
                        else if (jsonObject.src != string.Empty)
                            RealValue = "Src: " + jsonObject.src;
                        else if (jsonObject.href != string.Empty)
                            RealValue = "Href: " + jsonObject.href;

                        LstValues.AddItem(RealValue);
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
                //using (HttpClient client = new HttpClient())// actually only one object should be created by Application
                //{
                //    fullhtml = await client.GetStringAsync(txtURL.Text);
                //}

                //var fullhtml = await WView.CoreWebView2.ExecuteScriptAsync("document.documentElement.textContent");
                string SiteName = ModValidation.GetSiteName(txtURL.Text);
                string FullHtmlFilePath = Path.Combine(TrainingFolder, SiteName.Substring(0, 8) + ModConstant.cnst_html_Extention);
                if (!string.IsNullOrEmpty(SiteName))
                {

                    //string htmlwebv2 = await WView.ExecuteScriptAsync("document.documentElement.outerHTML");
                    string htmlwebv2 = await WView.ExecuteScriptAsync("document.body.outerHTML");
                    string DesHtml = System.Text.Json.JsonSerializer.Deserialize<string>(htmlwebv2);
                    DesHtml = modHtmlTextProcessing.PreProcessingHtml(DesHtml);
                    CoreApplicaion(DesHtml);

                    //Link with mohamad 
                    //using (HttpClient client = new HttpClient())
                    //{
                    //    string url = " http://127.0.0.1:8000/crawler/get_similar";
                    //    getSimilarURL getSimilar = new getSimilarURL();
                    //    getSimilar.url = txtURL.Text;//"https://www.amazon.ae/s?k=s23+ultra&crid=SSNWUPPRNOLA&sprefix=s23+ultr%2Caps%2C548&ref=nb_sb_noss_2";
                    //    //getSimilar.html = DesHtml;
                    //    //getSimilar.wanted_list.Add("Samsung Galaxy S23 Ultra 5G Dual SIM Green 12GB RAM 256GB - Middle East Version");
                    //    foreach (clsHtmlElem val in Values)
                    //    {
                    //        getSimilar.wanted_list.Add(val.Value);
                    //    }

                    //    var json = JsonConvert.SerializeObject(getSimilar);
                    //    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    //    HttpResponseMessage response = await client.PostAsync(url, data);
                    //    response.EnsureSuccessStatusCode();
                    //    string responseBody = await response.Content.ReadAsStringAsync();
                    //    Console.WriteLine(responseBody);
                    //}

                    rchLog.AppendText(ModResoucres.cnst_FullHtmlFileHasBeenWritten);

                    //3-Serialize Values list to file
                    string ResultFilePath = Path.Combine(TrainingFolder, ModConstant.cnst_ValuesFileName + ModConstant.cnst_json_Extention);
                    clsHtmlElem.SerializeHtmlElementsToFile(Values, ResultFilePath, ref ErrorMessage);
                    rchLog.AppendText(ModResoucres.cnst_ValuesFileHasBeenWritten);
                    rchLog.AppendText(ModResoucres.cnst_LookAtTheOutputFolder);
                    rchLog.AppendText(ModResoucres.cnst_ProcessingFinish);
                    rchLog.AppendText(ModResoucres.cnst_LogSeparatour);
                    rchLog.ScrollToCaret();
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

        #endregion

        #region Methods
        //Trying methods
        List<clsElement> GetPathToRoot(clsElement child, List<clsElement> allElements)
        {
            var path = new List<clsElement>();
            var current = child;
            while (current != null)
            {
                path.Add(current);
                current = allElements.FirstOrDefault(e => e.Guid == current.ParentGuid);
            }
            path.Reverse(); // So that the root is the first element
            return path;
        }

        clsElement FindLowestCommonAncestor(List<clsElement> children, List<clsElement> allElements)
        {
            var paths = children.Select(child => GetPathToRoot(child, allElements)).ToList();
            clsElement commonAncestor = null;

            for (int i = 0; i < paths.Min(p => p.Count); i++)
            {
                var firstPathParent = paths.First()[i];
                if (paths.All(p => p[i].Guid == firstPathParent.Guid))
                {
                    commonAncestor = firstPathParent;
                }
                else
                {
                    break;
                }
            }

            return commonAncestor;
        }
        //Recursive
        List<clsElement> GetAllDescendants(clsElement parent, List<clsElement> allElements)
        {
            var descendants = new List<clsElement>();
            var children = allElements.Where(e => e.ParentGuid == parent.Guid).ToList();

            foreach (var child in children)
            {
                descendants.Add(child);
                descendants.AddRange(GetAllDescendants(child, children)); // Recursive call to get all descendants
            }

            return descendants;
        }
        //End Trying
        clsElements CoreApplicaion(string DesHtml)
        {
            clsElements Results = new clsElements();
            try
            {
                clsElements elems = LibHtmlSplitter.ModMain.SplitHtmlToElements(DesHtml, debugvalue: "");
                clsElements result = LibHtmlSplitter.ModMain.CrawlCore(elems, Values);
                List<clsHtmlElem> Parents = Values.Where(o => o.groupParent != -1).ToList();
                int counter = 0;
                foreach (clsHtmlElem Parent in Parents)
                {
                    foreach (clsElement item in result.LstElements)
                    {
                        if (item.ClassName.ToLower() == Parent.ClassName.ToLower() && item.Tag.ToLower() == Parent.tagName.ToLower())
                        {
                            item.GroupParent = counter;
                            counter++;
                        }
                    }
                }
                Pairs pairs = new Pairs();
                counter = 0;
                List<clsField> UserFields = clsFields.GetFields().LstFields;
                foreach (clsElement elem in result?.LstElements?.Where(x => x.GroupParent != -1))
                {
                    var groupedObjects = result.LstElements
                    .GroupBy(obj => obj.Start >= elem.Start && obj.End <= elem.End && obj.Tag.ToLower() != "div")
                    .ToDictionary(group => group.Key, group => group.ToList());
                    foreach (var item in groupedObjects[true])
                    {

                        clsPair pair = new clsPair();
                        pair.group = counter;
                        clsHtmlElem? Rule = Values?.FirstOrDefault(x => x.ClassName == item.ClassName);
                        if (Rule != null)
                        {
                            pair.Key = Rule.FieldName;
                            pair.order = Rule?.order;
                            clsField currentField = UserFields?.FirstOrDefault(x => x.Name == Rule.FieldName);
                            switch (currentField.Type)
                            {
                                case ModEnum.FieldsTypes.Text:
                                    pair.Value = item?.TextContent;
                                    break;
                                case ModEnum.FieldsTypes.Numerical:
                                    pair.Value = LibHtmlSplitter.ModMain.KeepOnlyNumbers(item?.TextContent)?.ToString();
                                    break;
                                case ModEnum.FieldsTypes.Picture:
                                    string? src = LibHtmlSplitter.ModMain.GetSrcValuesFromHtml(item.Element)?.First();
                                    pair.Value = src;
                                    break;
                                default:
                                    break;
                            }
                            pairs.lstPairs.Add(pair);
                        }
                    }
                    counter++;
                }

                var groupedAndSortedUsers = pairs.lstPairs
                    .GroupBy(u => u.group)
                    .Select(group => new
                    {
                        GroupID = group.Key,
                        Field = group.OrderBy(u => u.order).ToList()
                    });

                using (var writer = new StreamWriter("output.csv"))
                {
                    foreach (var group in groupedAndSortedUsers)
                    {
                        var csvLine = string.Join(",", group.Field.Select(user => user.Value));
                        writer.WriteLine(csvLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
            return Results;
        }

        public async void ExecuteScripts()
        {
            try
            {
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

                if (MouseHover)
                {
                    string MouseHoverPath = ModPathes.GetHighlightHoverElementSciptPath();
                    string script = File.ReadAllText(MouseHoverPath);
                    await WView.CoreWebView2.ExecuteScriptAsync(script);
                }

                if (EnableScrolling)
                {
                    string ScrollScriptPath = ModPathes.GetScrollSciptPath();
                    string script = File.ReadAllText(ScrollScriptPath);
                    await WView.CoreWebView2.ExecuteScriptAsync(script);
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

        #region Fields

        private void btnAddField_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddField AddFieldForm = new frmAddField();
                if (AddFieldForm.ShowDialog() == DialogResult.OK)
                {
                    FillFields();
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstFields.SelectedItem.Tag != null)
                {
                    clsField deletedField = (clsField)lstFields.SelectedItem.Tag;
                    clsFields Fields = clsFields.GetFields();
                    Fields.LstFields.Remove(Fields.LstFields.FirstOrDefault(item => item.Id == deletedField.Id));
                    Fields.SetFields();
                    lstFields.RemoveItemAt(lstFields.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            try
            {
                clsFields Fields = new clsFields();
                Fields.SetFields();
                lstFields.Clear();
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnEditField_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstFields?.SelectedItem?.Tag != null)
                {
                    clsField EditedField = (clsField)lstFields.SelectedItem.Tag;
                    frmAddField AddFieldForm = new frmAddField(EditedField.Id);
                    if (AddFieldForm.ShowDialog() == DialogResult.OK)
                    {
                        FillFields();
                    }
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void FillFields()
        {
            try
            {
                lstFields.Items.Clear();
                foreach (clsField field in clsFields.GetFields().LstFields)
                {
                    //lstFields.AddItem(item.Name);   
                    MaterialListBoxItem item = new MaterialListBoxItem(field.Name, field.Description, field);
                    lstFields.AddItem(item);
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

    }
}
