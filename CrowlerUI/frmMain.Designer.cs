﻿namespace CrawlerUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin2DotNet.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin2DotNet.MaterialListBoxItem();
            MaterialSkin2DotNet.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin2DotNet.MaterialListBoxItem();
            MaterialSkin2DotNet.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin2DotNet.MaterialListBoxItem();
            this.btnHome = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.BtnData = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnSettings = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnClose = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.MainSp = new System.Windows.Forms.SplitContainer();
            this.ToolsSP = new System.Windows.Forms.SplitContainer();
            this.tblToolbox = new System.Windows.Forms.TableLayoutPanel();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.tblInToolBox = new System.Windows.Forms.TableLayoutPanel();
            this.LstToolbox = new MaterialSkin2DotNet.Controls.MaterialListBox();
            this.btnSwAddValue = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.btnSwPrevLinks = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.btnSwScrolling = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.ExtendSP = new System.Windows.Forms.SplitContainer();
            this.WView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grbValues = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LstValues = new MaterialSkin2DotNet.Controls.MaterialListBox();
            this.btnClearValues = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.TPLLog = new System.Windows.Forms.TableLayoutPanel();
            this.btnExpotLog = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnClearLog = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.rchLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnForward = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnBack = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnBrawserHome = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnGo = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.txtURL = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSp)).BeginInit();
            this.MainSp.Panel1.SuspendLayout();
            this.MainSp.Panel2.SuspendLayout();
            this.MainSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsSP)).BeginInit();
            this.ToolsSP.Panel1.SuspendLayout();
            this.ToolsSP.Panel2.SuspendLayout();
            this.ToolsSP.SuspendLayout();
            this.tblToolbox.SuspendLayout();
            this.grpTools.SuspendLayout();
            this.tblInToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendSP)).BeginInit();
            this.ExtendSP.Panel1.SuspendLayout();
            this.ExtendSP.Panel2.SuspendLayout();
            this.ExtendSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbValues.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.TPLLog.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = false;
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHome.Depth = 0;
            this.btnHome.HighEmphasis = true;
            this.btnHome.Icon = global::CrawlerUI.Properties.Resources.nuget_icon;
            this.btnHome.Location = new System.Drawing.Point(7, 71);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHome.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnHome.Name = "btnHome";
            this.btnHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHome.Size = new System.Drawing.Size(146, 36);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnHome.UseAccentColor = false;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // BtnData
            // 
            this.BtnData.AutoSize = false;
            this.BtnData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnData.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnData.Depth = 0;
            this.BtnData.HighEmphasis = true;
            this.BtnData.Icon = global::CrawlerUI.Properties.Resources.nuget_icon;
            this.BtnData.Location = new System.Drawing.Point(7, 110);
            this.BtnData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnData.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.BtnData.Name = "BtnData";
            this.BtnData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnData.Size = new System.Drawing.Size(146, 36);
            this.BtnData.TabIndex = 2;
            this.BtnData.Text = "Data";
            this.BtnData.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Text;
            this.BtnData.UseAccentColor = false;
            this.BtnData.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = false;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettings.Depth = 0;
            this.btnSettings.HighEmphasis = true;
            this.btnSettings.Icon = global::CrawlerUI.Properties.Resources.nuget_icon;
            this.btnSettings.Location = new System.Drawing.Point(7, 148);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettings.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettings.Size = new System.Drawing.Size(146, 36);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSettings.UseAccentColor = false;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = global::CrawlerUI.Properties.Resources.nuget_icon;
            this.btnClose.Location = new System.Drawing.Point(7, 186);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(146, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.MainSp, 1, 1);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 64);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(950, 564);
            this.tblMain.TabIndex = 5;
            // 
            // MainSp
            // 
            this.MainSp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSp.Location = new System.Drawing.Point(3, 54);
            this.MainSp.Name = "MainSp";
            this.MainSp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSp.Panel1
            // 
            this.MainSp.Panel1.Controls.Add(this.ToolsSP);
            // 
            // MainSp.Panel2
            // 
            this.MainSp.Panel2.Controls.Add(this.grpLog);
            this.MainSp.Size = new System.Drawing.Size(944, 507);
            this.MainSp.SplitterDistance = 379;
            this.MainSp.TabIndex = 1;
            // 
            // ToolsSP
            // 
            this.ToolsSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsSP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ToolsSP.Location = new System.Drawing.Point(0, 0);
            this.ToolsSP.Name = "ToolsSP";
            // 
            // ToolsSP.Panel1
            // 
            this.ToolsSP.Panel1.Controls.Add(this.tblToolbox);
            // 
            // ToolsSP.Panel2
            // 
            this.ToolsSP.Panel2.Controls.Add(this.ExtendSP);
            this.ToolsSP.Size = new System.Drawing.Size(944, 379);
            this.ToolsSP.SplitterDistance = 206;
            this.ToolsSP.TabIndex = 0;
            // 
            // tblToolbox
            // 
            this.tblToolbox.ColumnCount = 1;
            this.tblToolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblToolbox.Controls.Add(this.grpTools, 0, 0);
            this.tblToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblToolbox.Location = new System.Drawing.Point(0, 0);
            this.tblToolbox.Name = "tblToolbox";
            this.tblToolbox.RowCount = 1;
            this.tblToolbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblToolbox.Size = new System.Drawing.Size(206, 379);
            this.tblToolbox.TabIndex = 0;
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.tblInToolBox);
            this.grpTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTools.Location = new System.Drawing.Point(3, 3);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(200, 373);
            this.grpTools.TabIndex = 0;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Toolbox";
            // 
            // tblInToolBox
            // 
            this.tblInToolBox.ColumnCount = 1;
            this.tblInToolBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInToolBox.Controls.Add(this.LstToolbox, 0, 3);
            this.tblInToolBox.Controls.Add(this.btnSwAddValue, 0, 0);
            this.tblInToolBox.Controls.Add(this.btnSwPrevLinks, 0, 1);
            this.tblInToolBox.Controls.Add(this.btnSwScrolling, 0, 2);
            this.tblInToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInToolBox.Location = new System.Drawing.Point(3, 23);
            this.tblInToolBox.Name = "tblInToolBox";
            this.tblInToolBox.RowCount = 4;
            this.tblInToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblInToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInToolBox.Size = new System.Drawing.Size(194, 347);
            this.tblInToolBox.TabIndex = 0;
            // 
            // LstToolbox
            // 
            this.LstToolbox.BackColor = System.Drawing.Color.White;
            this.LstToolbox.BorderColor = System.Drawing.Color.LightGray;
            this.LstToolbox.Depth = 0;
            this.LstToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstToolbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "Add Value";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Prevent Links";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Scrolling tool";
            this.LstToolbox.Items.Add(materialListBoxItem1);
            this.LstToolbox.Items.Add(materialListBoxItem2);
            this.LstToolbox.Items.Add(materialListBoxItem3);
            this.LstToolbox.Location = new System.Drawing.Point(3, 123);
            this.LstToolbox.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.LstToolbox.Name = "LstToolbox";
            this.LstToolbox.SelectedIndex = -1;
            this.LstToolbox.SelectedItem = null;
            this.LstToolbox.Size = new System.Drawing.Size(188, 221);
            this.LstToolbox.TabIndex = 0;
            this.LstToolbox.Visible = false;
            this.LstToolbox.SelectedIndexChanged += new MaterialSkin2DotNet.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.LstToolbox_SelectedIndexChanged);
            // 
            // btnSwAddValue
            // 
            this.btnSwAddValue.AutoSize = true;
            this.btnSwAddValue.Depth = 0;
            this.btnSwAddValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwAddValue.Location = new System.Drawing.Point(0, 0);
            this.btnSwAddValue.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwAddValue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnSwAddValue.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnSwAddValue.Name = "btnSwAddValue";
            this.btnSwAddValue.Ripple = true;
            this.btnSwAddValue.Size = new System.Drawing.Size(194, 40);
            this.btnSwAddValue.TabIndex = 0;
            this.btnSwAddValue.Text = "Add Values";
            this.btnSwAddValue.UseVisualStyleBackColor = true;
            this.btnSwAddValue.CheckedChanged += new System.EventHandler(this.btnSwAddValue_CheckedChanged);
            // 
            // btnSwPrevLinks
            // 
            this.btnSwPrevLinks.AutoSize = true;
            this.btnSwPrevLinks.Depth = 0;
            this.btnSwPrevLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwPrevLinks.Location = new System.Drawing.Point(0, 40);
            this.btnSwPrevLinks.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwPrevLinks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnSwPrevLinks.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnSwPrevLinks.Name = "btnSwPrevLinks";
            this.btnSwPrevLinks.Ripple = true;
            this.btnSwPrevLinks.Size = new System.Drawing.Size(194, 40);
            this.btnSwPrevLinks.TabIndex = 1;
            this.btnSwPrevLinks.Text = "Prevent Links";
            this.btnSwPrevLinks.UseVisualStyleBackColor = true;
            this.btnSwPrevLinks.CheckedChanged += new System.EventHandler(this.btnSwPrevLinks_CheckedChanged);
            // 
            // btnSwScrolling
            // 
            this.btnSwScrolling.AutoSize = true;
            this.btnSwScrolling.Depth = 0;
            this.btnSwScrolling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwScrolling.Location = new System.Drawing.Point(0, 80);
            this.btnSwScrolling.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwScrolling.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnSwScrolling.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnSwScrolling.Name = "btnSwScrolling";
            this.btnSwScrolling.Ripple = true;
            this.btnSwScrolling.Size = new System.Drawing.Size(194, 40);
            this.btnSwScrolling.TabIndex = 2;
            this.btnSwScrolling.Text = "Scrolling tool";
            this.btnSwScrolling.UseVisualStyleBackColor = true;
            // 
            // ExtendSP
            // 
            this.ExtendSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtendSP.Location = new System.Drawing.Point(0, 0);
            this.ExtendSP.Name = "ExtendSP";
            // 
            // ExtendSP.Panel1
            // 
            this.ExtendSP.Panel1.Controls.Add(this.WView);
            // 
            // ExtendSP.Panel2
            // 
            this.ExtendSP.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.ExtendSP.Size = new System.Drawing.Size(734, 379);
            this.ExtendSP.SplitterDistance = 597;
            this.ExtendSP.TabIndex = 0;
            // 
            // WView
            // 
            this.WView.AllowExternalDrop = true;
            this.WView.CreationProperties = null;
            this.WView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WView.Location = new System.Drawing.Point(0, 0);
            this.WView.Name = "WView";
            this.WView.Size = new System.Drawing.Size(597, 379);
            this.WView.Source = new System.Uri("https://www.amazon.com/", System.UriKind.Absolute);
            this.WView.TabIndex = 0;
            this.WView.ZoomFactor = 1D;
            this.WView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WView_CoreWebView2InitializationCompleted_1);
            this.WView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WView_NavigationCompleted_1);
            this.WView.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.WView_WebMessageReceived_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.grbValues, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 379);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // grbValues
            // 
            this.grbValues.Controls.Add(this.tableLayoutPanel4);
            this.grbValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbValues.Location = new System.Drawing.Point(3, 3);
            this.grbValues.Name = "grbValues";
            this.grbValues.Size = new System.Drawing.Size(127, 373);
            this.grbValues.TabIndex = 2;
            this.grbValues.TabStop = false;
            this.grbValues.Text = "Values";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.LstValues, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnClearValues, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(121, 347);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // LstValues
            // 
            this.LstValues.BackColor = System.Drawing.Color.White;
            this.LstValues.BorderColor = System.Drawing.Color.LightGray;
            this.LstValues.Depth = 0;
            this.LstValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LstValues.Location = new System.Drawing.Point(3, 43);
            this.LstValues.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.LstValues.Name = "LstValues";
            this.LstValues.SelectedIndex = -1;
            this.LstValues.SelectedItem = null;
            this.LstValues.Size = new System.Drawing.Size(115, 301);
            this.LstValues.TabIndex = 1;
            // 
            // btnClearValues
            // 
            this.btnClearValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearValues.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearValues.Depth = 0;
            this.btnClearValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearValues.HighEmphasis = true;
            this.btnClearValues.Icon = null;
            this.btnClearValues.Location = new System.Drawing.Point(4, 6);
            this.btnClearValues.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearValues.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnClearValues.Name = "btnClearValues";
            this.btnClearValues.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearValues.Size = new System.Drawing.Size(113, 28);
            this.btnClearValues.TabIndex = 0;
            this.btnClearValues.Text = "Clear";
            this.btnClearValues.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearValues.UseAccentColor = false;
            this.btnClearValues.UseVisualStyleBackColor = true;
            this.btnClearValues.Click += new System.EventHandler(this.btnClearValues_Click);
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.TPLLog);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Location = new System.Drawing.Point(0, 0);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(944, 124);
            this.grpLog.TabIndex = 0;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // TPLLog
            // 
            this.TPLLog.ColumnCount = 2;
            this.TPLLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPLLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.TPLLog.Controls.Add(this.btnExpotLog, 1, 0);
            this.TPLLog.Controls.Add(this.btnClearLog, 1, 1);
            this.TPLLog.Controls.Add(this.rchLog, 0, 0);
            this.TPLLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TPLLog.Location = new System.Drawing.Point(3, 23);
            this.TPLLog.Name = "TPLLog";
            this.TPLLog.RowCount = 3;
            this.TPLLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPLLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TPLLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPLLog.Size = new System.Drawing.Size(938, 98);
            this.TPLLog.TabIndex = 0;
            // 
            // btnExpotLog
            // 
            this.btnExpotLog.AutoSize = false;
            this.btnExpotLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExpotLog.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExpotLog.Depth = 0;
            this.btnExpotLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpotLog.HighEmphasis = true;
            this.btnExpotLog.Icon = null;
            this.btnExpotLog.Location = new System.Drawing.Point(802, 6);
            this.btnExpotLog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExpotLog.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnExpotLog.Name = "btnExpotLog";
            this.btnExpotLog.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExpotLog.Size = new System.Drawing.Size(132, 30);
            this.btnExpotLog.TabIndex = 1;
            this.btnExpotLog.Text = "Export Log";
            this.btnExpotLog.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExpotLog.UseAccentColor = false;
            this.btnExpotLog.UseVisualStyleBackColor = true;
            this.btnExpotLog.Click += new System.EventHandler(this.btnExpotLog_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.AutoSize = false;
            this.btnClearLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearLog.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearLog.Depth = 0;
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearLog.HighEmphasis = true;
            this.btnClearLog.Icon = null;
            this.btnClearLog.Location = new System.Drawing.Point(802, 48);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearLog.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearLog.Size = new System.Drawing.Size(132, 30);
            this.btnClearLog.TabIndex = 2;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearLog.UseAccentColor = false;
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // rchLog
            // 
            this.rchLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchLog.Location = new System.Drawing.Point(3, 3);
            this.rchLog.Name = "rchLog";
            this.TPLLog.SetRowSpan(this.rchLog, 3);
            this.rchLog.Size = new System.Drawing.Size(792, 92);
            this.rchLog.TabIndex = 3;
            this.rchLog.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.btnForward, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrawserHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtURL, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 45);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnForward
            // 
            this.btnForward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForward.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnForward.Depth = 0;
            this.btnForward.HighEmphasis = true;
            this.btnForward.Icon = null;
            this.btnForward.Location = new System.Drawing.Point(114, 6);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnForward.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnForward.Name = "btnForward";
            this.btnForward.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnForward.Size = new System.Drawing.Size(42, 33);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">";
            this.btnForward.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnForward.UseAccentColor = false;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(64, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(42, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBrawserHome
            // 
            this.btnBrawserHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrawserHome.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrawserHome.Depth = 0;
            this.btnBrawserHome.HighEmphasis = true;
            this.btnBrawserHome.Icon = null;
            this.btnBrawserHome.Location = new System.Drawing.Point(4, 6);
            this.btnBrawserHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrawserHome.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnBrawserHome.Name = "btnBrawserHome";
            this.btnBrawserHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBrawserHome.Size = new System.Drawing.Size(52, 33);
            this.btnBrawserHome.TabIndex = 2;
            this.btnBrawserHome.Text = "Home";
            this.btnBrawserHome.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrawserHome.UseAccentColor = false;
            this.btnBrawserHome.UseVisualStyleBackColor = true;
            this.btnBrawserHome.Click += new System.EventHandler(this.btnBrawserHome_Click);
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = false;
            this.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGo.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGo.Depth = 0;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.HighEmphasis = true;
            this.btnGo.Icon = null;
            this.btnGo.Location = new System.Drawing.Point(888, 6);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGo.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnGo.Name = "btnGo";
            this.btnGo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGo.Size = new System.Drawing.Size(52, 33);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "go";
            this.btnGo.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGo.UseAccentColor = false;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtURL
            // 
            this.txtURL.AnimateReadOnly = false;
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Depth = 0;
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtURL.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtURL.LeadingIcon = null;
            this.txtURL.Location = new System.Drawing.Point(163, 3);
            this.txtURL.MaxLength = 50;
            this.txtURL.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtURL.Multiline = false;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(718, 36);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "";
            this.txtURL.TrailingIcon = null;
            this.txtURL.UseTallSize = false;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 631);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.btnHome);
            this.Name = "frmMain";
            this.Text = "Smart Crawler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblMain.ResumeLayout(false);
            this.MainSp.Panel1.ResumeLayout(false);
            this.MainSp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSp)).EndInit();
            this.MainSp.ResumeLayout(false);
            this.ToolsSP.Panel1.ResumeLayout(false);
            this.ToolsSP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolsSP)).EndInit();
            this.ToolsSP.ResumeLayout(false);
            this.tblToolbox.ResumeLayout(false);
            this.grpTools.ResumeLayout(false);
            this.tblInToolBox.ResumeLayout(false);
            this.tblInToolBox.PerformLayout();
            this.ExtendSP.Panel1.ResumeLayout(false);
            this.ExtendSP.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExtendSP)).EndInit();
            this.ExtendSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grbValues.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.TPLLog.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin2DotNet.Controls.MaterialButton btnHome;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnData;
        private MaterialSkin2DotNet.Controls.MaterialButton btnSettings;
        private MaterialSkin2DotNet.Controls.MaterialButton btnClose;
        private TableLayoutPanel tblMain;
        private SplitContainer MainSp;
        private SplitContainer ToolsSP;
        private SplitContainer ExtendSP;
        private GroupBox grpLog;
        private TableLayoutPanel TPLLog;
        private MaterialSkin2DotNet.Controls.MaterialButton btnExpotLog;
        private MaterialSkin2DotNet.Controls.MaterialButton btnClearLog;
        private Microsoft.Web.WebView2.WinForms.WebView2 WView;
        private GroupBox grpTools;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin2DotNet.Controls.MaterialButton btnForward;
        private MaterialSkin2DotNet.Controls.MaterialButton btnBack;
        private MaterialSkin2DotNet.Controls.MaterialButton btnBrawserHome;
        private MaterialSkin2DotNet.Controls.MaterialButton btnGo;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtURL;
        private MaterialSkin2DotNet.Controls.MaterialListBox LstToolbox;
        private RichTextBox rchLog;
        private TableLayoutPanel tblInToolBox;
        private MaterialSkin2DotNet.Controls.MaterialSwitch btnSwAddValue;
        private MaterialSkin2DotNet.Controls.MaterialSwitch btnSwPrevLinks;
        private MaterialSkin2DotNet.Controls.MaterialSwitch btnSwScrolling;
        private TableLayoutPanel tblToolbox;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox grbValues;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin2DotNet.Controls.MaterialListBox LstValues;
        private MaterialSkin2DotNet.Controls.MaterialButton btnClearValues;
    }
}