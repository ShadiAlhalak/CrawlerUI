﻿using System;
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

namespace CrawlerUI
{
    public partial class frmMain : MaterialSkin2DotNet.Controls.MaterialForm
    {

        #region Variables

        public List<clsHtmlElem> Values { get; set; }
        public MaterialMessage Message { get; set; } = new MaterialMessage();
        public bool AddZone { get; set; } = false;
        public bool PreventLinks { get; set; } = false;

        #endregion

        #region Constractor

        public frmMain()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //this.Drawer.Controls.Add(btnHome);
            //this.Drawer.Controls.Add(BtnData);
            //this.Drawer.Controls.Add(btnSettings);
            //this.Drawer.Controls.Add(btnClose);
        }

        #endregion

        #region Events

        #region Brawser events 

        private void btnBrawserHome_Click(object sender, EventArgs e)
        {
            try
            {
                WView.Source = new Uri(LibGeneralUtilities.ModConstant.HomeUrl);
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
                WView.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (WView.CanGoForward)
            {
                WView.GoForward();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
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

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                txtURL.Text = WView.Source.ToString();
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

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rchLog.Clear();
        }

        private void LstToolbox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            try
            {
                switch (selectedItem.Text)
                {
                    case ModConstant.AddValue:

                    case ModConstant.PreventLinks:

                        break;
                    default:
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
                    WView.Reload();
                }
                else
                {
                    AddZone = false;
                    Message.MessageType = ModResoucres.MsgType_Info;
                    Message.Message = ModResoucres.MsgWaitUntilReloadPage + ".\n" + ModResoucres.MsgAddValuesDisabled;
                    Message.ShowMessage();
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

        private void WView_NavigationCompleted_1(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                txtURL.Text = WView.Source.ToString();
                if (PreventLinks)
                {
                    string LinksDisableScr = File.ReadAllText("LinksDisable.js");
                    WView.CoreWebView2.ExecuteScriptAsync(LinksDisableScr);
                }
                if (AddZone)
                {
                    string script = File.ReadAllText("Mouse.js");
                    WView.CoreWebView2.ExecuteScriptAsync(script);
                    //old way 
                    //WView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(script);
                }
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
                clsHtmlElem jsonObject = JsonConvert.DeserializeObject<clsHtmlElem>(e.WebMessageAsJson);
                var elem = await WView.CoreWebView2.ExecuteScriptAsync("document.querySelector(." + jsonObject.ClassName + ");");
                var fullhtml = await WView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
                //var fullhtml2 =await  WView.CoreWebView2.ExecuteScriptAsync("document.documentElement.innerHTML;");
                //var fullhtml3 =await  WView.CoreWebView2.ExecuteScriptAsync("document.getElementsByTagName(\"html\")[0]\r\n.innerHTML;");
                string SiteName = ModValidation.GetSiteName(txtURL.Text);
                if (string.IsNullOrEmpty(SiteName))
                {
                    SiteName += ".html";
                    File.WriteAllText(SiteName, fullhtml);
                }

                //WView.CoreWebView2.ExecuteScriptAsync("window.onload = function() {\r\n    var anchors = document.getElementsByTagName(\"a\");\r\n    for (var i = 0; i < anchors.length; i++) {\r\n        anchors[i].onclick = function() {return false;};\r\n    }\r\n};");

                //Diable all link script
                // WView.CoreWebView2.ExecuteScriptAsync("var anchors = document.getElementsByTagName(\"a\");\r\n    for (var i = 0; i < anchors.length; i++) {\r\n        anchors[i].onclick = function() {return false;};\r\n    }");
                //string script = File.ReadAllText("LinksDisable.js");
                //await WView.CoreWebView2.ExecuteScriptAsync(script);

                rchLog.AppendText(jsonObject.ObjectToString());
                rchLog.ScrollToCaret();
                //rchLog.AppendText(ModResoucres.cnst_FullHtmlSavedDone + "," +ModResoucres.cnst_YouCanFindFullHtmlInRoot+". \n \n");
                switch (jsonObject.Key)
                {
                    case "click":
                        //treeView1.Nodes.Add(jsonObject.Value);
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

        #endregion

        #endregion

        #region Methods

        #endregion


    }
}