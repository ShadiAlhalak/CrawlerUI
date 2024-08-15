using LibGeneralUtilities;
using LibHtmlSplitter;
using LibStructure;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System.Data;
using System.Text;

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
        public bool pageLoaded { get; set; } = false;
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
                GoToUrl();
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
                pageLoaded = true;
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
            try
            {
                //LoopThroughUrlsAsync();
                LaunchProcess();
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

        async void GoToUrl(string url = "")
        {
            try
            {
                if (!string.IsNullOrEmpty(url))
                {
                    txtURL.Text = url;
                }

                progBar.Value = 0;
                progTimer.Enabled = true;
                string ValidUrl = ModValidation.ValidateURL(txtURL.Text);
                txtURL.Text = ValidUrl;
                WView.Source = new Uri(ValidUrl);



                //var tcs = new TaskCompletionSource<bool>();
                //EventHandler<CoreWebView2NavigationCompletedEventArgs> handler = null;
                //handler = (s, e) =>
                //{
                //    WView.CoreWebView2.NavigationCompleted -= handler;
                //    tcs.SetResult(true);
                //};
                //WView.CoreWebView2.NavigationCompleted += handler;

                //WView.CoreWebView2.Navigate(url);
                //await tcs.Task;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        async public void LaunchProcess()
        {
            string ErrorMessage = string.Empty;
            try
            {
                //1-Check if user add values and fields 
                if (Values.Count == 0 || clsFields.GetFields().LstFields.Count == 0)
                {
                    Message.Message = ModResoucres.MsgCannotLaunchBeforeAddFieldsAndValues;
                    Message.MessageType = ModResoucres.MsgType_Error;
                    Message.ShowMessage();
                    return;
                }
                //2-Initial data set info
                frmNewDS newds = new frmNewDS();
                if (newds.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                //3-Initial ds with API
                //Link with mohamad 
                //using (HttpClient client = new HttpClient())
                //{
                //    string? url =$"{clsSettings.loadSettings(ref ErrorMessage)?.AIServiceUrl}/{ModConstant.cnstAPICreateDS}";
                //    clsCreateDS Info = new clsCreateDS();
                //    Info.Title = newds.txtName.Text;
                //    Info.Description = newds.txtDescription.Text;
                //    Info.Fields = clsFields.GetFields()?.LstFields;


                //    var json = JsonConvert.SerializeObject(Info);
                //    var data = new StringContent(json, Encoding.UTF8, "application/json");

                //    HttpResponseMessage response = await client.PostAsync(url, data);
                //    response.EnsureSuccessStatusCode();
                //    string responseBody = await response.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseBody);
                //}

                rchLog.AppendText(ModResoucres.cnst_LogSeparatour);
                rchLog.ScrollToCaret();

                rchLog.SelectionColor = System.Drawing.Color.Blue;
                rchLog.AppendText(ModResoucres.cnst_StartProcessing);
                rchLog.SelectionColor = rchLog.ForeColor;

                //
                string ResultFodler;
                if (!string.IsNullOrEmpty(newds.txtName.Text))
                {
                    ResultFodler = ModPathes.GetSessionOutPutFolder(newds.txtName.Text, ref ErrorMessage);
                    //1-Get Pages
                    List<Pairs> FullResult = new List<Pairs>();
                    var Pages = Values.Where(item => item.IsPage == true).Select(x => x.href);
                    foreach (var page in Pages)
                    {
                        //2-Load page
                        //pageLoaded = false;
                        if (string.IsNullOrEmpty(page)) continue;

                        var tcs = new TaskCompletionSource<bool>();
                        EventHandler<CoreWebView2NavigationCompletedEventArgs> handler = null;
                        handler = (s, e) =>
                        {
                            WView.CoreWebView2.NavigationCompleted -= handler;
                            tcs.SetResult(true);
                        };
                        WView.CoreWebView2.NavigationCompleted += handler;

                        WView.CoreWebView2.Navigate(page);
                        await tcs.Task;

                        //string htmlwebv2 = await WView.ExecuteScriptAsync("document.documentElement.outerHTML");
                        string htmlwebv2 = await WView.ExecuteScriptAsync("document.body.outerHTML");
                        string DesHtml = System.Text.Json.JsonSerializer.Deserialize<string>(htmlwebv2);
                        DesHtml = modHtmlTextProcessing.PreProcessingHtml(DesHtml);
                        List<Pairs> PageResult = await CoreApplicaion(DesHtml, page);
                        FullResult.AddRange(PageResult);
                        //// Perform your actions on the loaded page
                    }
                    string csvResultFile = Path.Combine(ResultFodler, ModConstant.cnst_OutputFolder + ModConstant.cnst_csv_Extention);
                    WriteFullResult(FullResult, csvResultFile);

                    if (!string.IsNullOrEmpty(ErrorMessage))
                    {
                        rchLog.SelectionColor = System.Drawing.Color.Red;
                        rchLog.AppendText(ModResoucres.cnst_ProcessingFaild);
                        rchLog.AppendText($"{ModResoucres.cnst_Error} : {ErrorMessage}");
                        rchLog.SelectionColor = rchLog.ForeColor;
                    }
                    else
                    {
                        //3-Serialize Values list to file
                        string ResultFilePath = Path.Combine(ResultFodler, ModConstant.cnst_Rules + ModConstant.cnst_json_Extention);
                        clsHtmlElems elems = new clsHtmlElems();
                        elems.Elements = Values;
                        clsHtmlElems.SerializeHtmlElementsToFile(elems, ResultFilePath, ref ErrorMessage);
                        rchLog.AppendText(ModResoucres.cnst_ResultFileHasBeenWritten);
                        rchLog.AppendText(ModResoucres.cnst_LookAtTheOutputFolder);
                        rchLog.AppendText(ResultFodler);
                        rchLog.SelectionColor = System.Drawing.Color.Green;
                        rchLog.AppendText("\n" + ModResoucres.cnst_ProcessingFinish);
                        rchLog.SelectionColor = rchLog.ForeColor;
                        rchLog.AppendText(ModResoucres.cnst_LogSeparatour);
                        rchLog.ScrollToCaret();
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
        public void WriteFullResult(List<Pairs> Lines, string ResultCsvPath)
        {
            try
            {
                //Create result file as csv now 
                if (!File.Exists(ResultCsvPath))
                {
                    using (var writer = new StreamWriter(ResultCsvPath, false, Encoding.UTF8))
                    {
                        foreach (Pairs Line in Lines)
                        {
                            var csvLine = string.Join(";", Line.lstPairs.Select(Val => Val.Value)); ;
                            writer.WriteLine(csvLine);
                        }
                    }
                }
                else
                {
                    List<string> NewLines = new List<string>();
                    foreach (Pairs Line in Lines)
                    {
                        var csvLine = string.Join(";", Line.lstPairs.Select(Val => Val.Value));
                        NewLines.Add(csvLine);
                    }
                    File.AppendAllLines(ResultCsvPath, NewLines, Encoding.UTF8);
                }
                string jsonResutlPath = Path.ChangeExtension(ResultCsvPath, ModConstant.cnst_json_Extention);
                string serializer = Newtonsoft.Json.JsonConvert.SerializeObject(Lines, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonResutlPath, serializer);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //clsElements CoreApplicaion(string DesHtml, string ResultCsvPath, string ErrorMessage)
        //{
        //    clsElements Results = new clsElements();
        //    try
        //    {
        //        //1-Get Pages
        //        var Pages = Values.Where(item => item.IsPage == true).Select(x => x.href);
        //        foreach (var page in Pages)
        //        {
        //            //2-Load page
        //            pageLoaded = false;
        //            if (string.IsNullOrEmpty(page)) continue;
        //            txtURL.Text = page;
        //            this.Invoke(GoToUrl);
        //            int timeout = 30;
        //            int timer = 0;
        //            Stopwatch stopwatch = new Stopwatch();
        //            stopwatch.Start();
        //            while (!pageLoaded)
        //            {
        //                //if (timer < timeout)
        //                //{
        //                //    System.Threading.Thread.Sleep(1000);
        //                //    timer++;
        //                //}
        //                //else
        //                //{
        //                //    ErrorMessage = ModResoucres.MsgTimeIsOut + ModResoucres.MsgPleaseCheckIntenetConnection;
        //                //    return Results;
        //                //}
        //                if (stopwatch.ElapsedMilliseconds >= timeout * 1000)
        //                {
        //                    ErrorMessage = ModResoucres.MsgTimeIsOut + ModResoucres.MsgPleaseCheckIntenetConnection;
        //                    return Results;
        //                }
        //            }

        //            //Start processing
        //            //4-Split html code to list of elments 
        //            clsElements elems = LibHtmlSplitter.ModMain.SplitHtmlToElements(DesHtml, debugvalue: "");
        //            //ModMain.InitialForAI(elems,Values);

        //            //5-Find requested elments 
        //            clsElements result = LibHtmlSplitter.ModMain.CrawlCore(elems, Values);

        //            //6-Find parents if exits
        //            List<clsHtmlElem> Parents = Values.Where(o => o.groupParent != -1).ToList();
        //            int counter = 0;
        //            foreach (clsHtmlElem Parent in Parents)
        //            {
        //                foreach (clsElement item in result.LstElements)
        //                {
        //                    if (item.ClassName.ToLower() == Parent.ClassName.ToLower() && item.Tag.ToLower() == Parent.tagName.ToLower())
        //                    {
        //                        item.GroupParent = counter;
        //                        counter++;
        //                    }
        //                }
        //            }
        //            Pairs pairs = new Pairs();
        //            counter = 0;
        //            List<clsField> UserFields = clsFields.GetFields().LstFields;
        //            foreach (clsElement elem in result?.LstElements?.Where(x => x.GroupParent != -1))
        //            {
        //                var groupedObjects = result.LstElements
        //                .GroupBy(obj => obj.Start >= elem.Start && obj.End <= elem.End && obj.Tag.ToLower() != "div")//
        //                .ToDictionary(group => group.Key, group => group.ToList());
        //                foreach (var item in groupedObjects[true])
        //                {

        //                    clsPair pair = new clsPair();
        //                    pair.group = counter;
        //                    clsHtmlElem? Rule = Values?.FirstOrDefault(x => x.ClassName == item.ClassName);
        //                    if (Rule != null)
        //                    {
        //                        pair.Key = Rule.FieldName;
        //                        pair.order = Rule?.order;
        //                        clsField currentField = UserFields?.FirstOrDefault(x => x.Name == Rule.FieldName);
        //                        if (currentField != null)
        //                        {

        //                            switch (currentField.Type)
        //                            {
        //                                case ModEnum.FieldsTypes.Text:
        //                                    pair.Value = item?.TextContent;
        //                                    break;
        //                                case ModEnum.FieldsTypes.Numerical:
        //                                    pair.Value = LibHtmlSplitter.ModMain.KeepOnlyNumbers(item?.TextContent)?.ToString();
        //                                    break;
        //                                case ModEnum.FieldsTypes.Picture:
        //                                    string? src = LibHtmlSplitter.ModMain.GetSrcValuesFromHtml(item.Element)?.First();
        //                                    pair.Value = src;
        //                                    break;
        //                                default:
        //                                    break;
        //                            }
        //                        }
        //                        pairs.lstPairs.Add(pair);
        //                    }
        //                }
        //                counter++;
        //            }

        //            var groupedAndSortedUsers = pairs.lstPairs
        //                .GroupBy(u => u.group)
        //                .Select(group => new
        //                {
        //                    GroupID = group.Key,
        //                    Field = group.OrderBy(u => u.order).ToList()
        //                });

        //            //Create result file as csv now 
        //            if (!File.Exists(ResultCsvPath))
        //            {
        //                using (var writer = new StreamWriter(ResultCsvPath))
        //                {
        //                    foreach (var group in groupedAndSortedUsers)
        //                    {
        //                        var csvLine = string.Join(",", group.Field.Select(user => user.Value));
        //                        writer.WriteLine(csvLine);
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                List<string> NewLines = new List<string>();
        //                foreach (var group in groupedAndSortedUsers)
        //                {
        //                    var csvLine = string.Join(",", group.Field.Select(user => user.Value));
        //                    NewLines.Add(csvLine);
        //                }
        //                File.AppendAllLines(ResultCsvPath, NewLines);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorMessage = ex.Message;
        //        //Message.Message = ex.Message;
        //        //Message.MessageType = ModResoucres.MsgType_Error;
        //        //Message.ShowMessage();
        //    }
        //    return Results;
        //}

        async Task<List<Pairs>> CoreApplicaion(string DesHtml, string Page)
        {
            List<Pairs> Lines = new List<Pairs>();
            string ErrorMessage = string.Empty;
            clsElements Results = new clsElements();
            try
            {
                //Start processing
                //4-Split html code to list of elments 
                clsElements elems = LibHtmlSplitter.ModMain.SplitHtmlToElements(DesHtml, debugvalue: "");
                string savepath = "C:\\Users\\shadi\\Desktop\\مجلد جديد\\Final Try\\data\\gsm.csv";
                elems.SaveAsCSV(savepath);
                //ModMain.InitialForAI(elems,Values);

                //5-Find requested elments 
                clsElements result = LibHtmlSplitter.ModMain.CrawlCore(elems, Values);

                //6-Find parents if exits
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
                    .GroupBy(obj => obj.Start >= elem.Start && obj.End <= elem.End && obj.GroupParent == -1)//obj.Tag.ToLower() != "div"
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
                            if (currentField != null)
                            {

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

                //Create result file as csv now 
                //    if (!File.Exists(ResultCsvPath))
                //    {
                //        using (var writer = new StreamWriter(ResultCsvPath))
                //        {
                //            foreach (var group in groupedAndSortedUsers)
                //            {
                //                var csvLine = string.Join(",", group.Field.Select(user => user.Value));
                //                writer.WriteLine(csvLine);
                //            }
                //        }
                //    }
                //    else
                //    {
                //        List<string> NewLines = new List<string>();
                //        foreach (var group in groupedAndSortedUsers)
                //        {

                //            var csvLine = string.Join(",", group.Field.Select(user => user.Value));
                //            NewLines.Add(csvLine);
                //        }
                //        File.AppendAllLines(ResultCsvPath, NewLines);
                //    }

                //Initial result
                foreach (var group in groupedAndSortedUsers)
                {
                    Pairs Line = new Pairs();
                    foreach (var item in group.Field)
                    {
                        clsPair pair = new clsPair();
                        pair.Key = item.Key;
                        pair.Value = item.Value;
                        pair.order = item.order;
                        pair.group = item.group;
                        pair.Page = Page;
                        Line.lstPairs.Add(pair);
                    }
                    Lines.Add(Line);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                //Message.Message = ex.Message;
                //Message.MessageType = ModResoucres.MsgType_Error;
                //Message.ShowMessage();
            }
            return Lines;
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


        private async Task LoopThroughUrlsAsync()
        {
            //1-Get Pages
            var Pages = Values.Where(item => item.IsPage == true).Select(x => x.href);
            foreach (var page in Pages)
            {
                //2-Load page
                //pageLoaded = false;
                if (string.IsNullOrEmpty(page)) continue;

                var tcs = new TaskCompletionSource<bool>();
                EventHandler<CoreWebView2NavigationCompletedEventArgs> handler = null;
                handler = (s, e) =>
                {
                    WView.CoreWebView2.NavigationCompleted -= handler;
                    tcs.SetResult(true);
                };
                WView.CoreWebView2.NavigationCompleted += handler;

                WView.CoreWebView2.Navigate(page);
                await tcs.Task;

                // Perform your actions on the loaded page
                //await CoreApplicaion();
            }

            //string[] urls = { "https://www.google.com", "https://www.facebook.com", "https://www.amazon.ae" };
            //foreach (var url in urls)
            //{
            //    var tcs = new TaskCompletionSource<bool>();
            //    EventHandler<CoreWebView2NavigationCompletedEventArgs> handler = null;
            //    handler = (s, e) =>
            //    {
            //        WView.CoreWebView2.NavigationCompleted -= handler;
            //        tcs.SetResult(true);
            //    };
            //    WView.CoreWebView2.NavigationCompleted += handler;

            //    WView.CoreWebView2.Navigate(url);
            //    await tcs.Task;

            //    // Perform your actions on the loaded page
            //    await PerformActionsOnPageAsync();
            //}
        }

        private async Task PerformActionsOnPageAsync()
        {
            // Example: Execute JavaScript on the loaded page
            string script = "document.body.style.backgroundColor = 'lightblue';";
            await WView.CoreWebView2.ExecuteScriptAsync(script);
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
