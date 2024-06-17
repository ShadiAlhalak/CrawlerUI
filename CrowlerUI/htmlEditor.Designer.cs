namespace CrawlerUI
{
    partial class htmlEditor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpHtmlEditor = new System.Windows.Forms.GroupBox();
            this.tblPanelHtmlEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tblHEditorTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnHESave = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnHEReload = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.lblZoomText = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.btnZoomIn = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnZoomOut = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnResetZoom = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.swHEWrap = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.rchHtmlEditor = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.btnFind = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.HtmlSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.HtmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpHtmlEditor.SuspendLayout();
            this.tblPanelHtmlEditor.SuspendLayout();
            this.tblHEditorTools.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.grpHtmlEditor, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpHtmlEditor
            // 
            this.grpHtmlEditor.Controls.Add(this.tblPanelHtmlEditor);
            this.grpHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHtmlEditor.Location = new System.Drawing.Point(8, 8);
            this.grpHtmlEditor.Name = "grpHtmlEditor";
            this.grpHtmlEditor.Size = new System.Drawing.Size(918, 456);
            this.grpHtmlEditor.TabIndex = 0;
            this.grpHtmlEditor.TabStop = false;
            this.grpHtmlEditor.Text = "Html Editor";
            // 
            // tblPanelHtmlEditor
            // 
            this.tblPanelHtmlEditor.ColumnCount = 1;
            this.tblPanelHtmlEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelHtmlEditor.Controls.Add(this.tblHEditorTools, 0, 0);
            this.tblPanelHtmlEditor.Controls.Add(this.rchHtmlEditor, 0, 2);
            this.tblPanelHtmlEditor.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblPanelHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelHtmlEditor.Location = new System.Drawing.Point(3, 23);
            this.tblPanelHtmlEditor.Name = "tblPanelHtmlEditor";
            this.tblPanelHtmlEditor.RowCount = 3;
            this.tblPanelHtmlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelHtmlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelHtmlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelHtmlEditor.Size = new System.Drawing.Size(912, 430);
            this.tblPanelHtmlEditor.TabIndex = 0;
            // 
            // tblHEditorTools
            // 
            this.tblHEditorTools.ColumnCount = 9;
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblHEditorTools.Controls.Add(this.btnHESave, 8, 0);
            this.tblHEditorTools.Controls.Add(this.btnHEReload, 7, 0);
            this.tblHEditorTools.Controls.Add(this.lblZoomText, 0, 0);
            this.tblHEditorTools.Controls.Add(this.btnZoomIn, 1, 0);
            this.tblHEditorTools.Controls.Add(this.btnZoomOut, 2, 0);
            this.tblHEditorTools.Controls.Add(this.btnResetZoom, 3, 0);
            this.tblHEditorTools.Controls.Add(this.swHEWrap, 4, 0);
            this.tblHEditorTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHEditorTools.Location = new System.Drawing.Point(3, 3);
            this.tblHEditorTools.Name = "tblHEditorTools";
            this.tblHEditorTools.RowCount = 1;
            this.tblHEditorTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHEditorTools.Size = new System.Drawing.Size(906, 34);
            this.tblHEditorTools.TabIndex = 0;
            // 
            // btnHESave
            // 
            this.btnHESave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHESave.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHESave.Depth = 0;
            this.btnHESave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHESave.HighEmphasis = true;
            this.btnHESave.Icon = null;
            this.btnHESave.Location = new System.Drawing.Point(800, 6);
            this.btnHESave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHESave.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnHESave.Name = "btnHESave";
            this.btnHESave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHESave.Size = new System.Drawing.Size(102, 22);
            this.btnHESave.TabIndex = 2;
            this.btnHESave.Text = "Save ";
            this.btnHESave.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHESave.UseAccentColor = false;
            this.btnHESave.UseVisualStyleBackColor = true;
            this.btnHESave.Click += new System.EventHandler(this.btnHESave_Click);
            // 
            // btnHEReload
            // 
            this.btnHEReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHEReload.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHEReload.Depth = 0;
            this.btnHEReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHEReload.HighEmphasis = true;
            this.btnHEReload.Icon = null;
            this.btnHEReload.Location = new System.Drawing.Point(690, 6);
            this.btnHEReload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHEReload.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnHEReload.Name = "btnHEReload";
            this.btnHEReload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHEReload.Size = new System.Drawing.Size(102, 22);
            this.btnHEReload.TabIndex = 3;
            this.btnHEReload.Text = "Reload";
            this.btnHEReload.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHEReload.UseAccentColor = false;
            this.btnHEReload.UseVisualStyleBackColor = true;
            this.btnHEReload.Click += new System.EventHandler(this.btnHEReload_Click);
            // 
            // lblZoomText
            // 
            this.lblZoomText.AutoSize = true;
            this.lblZoomText.Depth = 0;
            this.lblZoomText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZoomText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblZoomText.Location = new System.Drawing.Point(3, 0);
            this.lblZoomText.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblZoomText.Name = "lblZoomText";
            this.lblZoomText.Size = new System.Drawing.Size(86, 34);
            this.lblZoomText.TabIndex = 5;
            this.lblZoomText.Text = "Zoom Text :";
            this.lblZoomText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZoomIn.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnZoomIn.Depth = 0;
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomIn.HighEmphasis = true;
            this.btnZoomIn.Icon = null;
            this.btnZoomIn.Location = new System.Drawing.Point(96, 6);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnZoomIn.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnZoomIn.Size = new System.Drawing.Size(32, 22);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnZoomIn.UseAccentColor = false;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZoomOut.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnZoomOut.Depth = 0;
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.HighEmphasis = true;
            this.btnZoomOut.Icon = null;
            this.btnZoomOut.Location = new System.Drawing.Point(136, 6);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnZoomOut.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnZoomOut.Size = new System.Drawing.Size(32, 22);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnZoomOut.UseAccentColor = false;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetZoom.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetZoom.Depth = 0;
            this.btnResetZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetZoom.HighEmphasis = true;
            this.btnResetZoom.Icon = null;
            this.btnResetZoom.Location = new System.Drawing.Point(176, 6);
            this.btnResetZoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetZoom.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetZoom.Size = new System.Drawing.Size(112, 22);
            this.btnResetZoom.TabIndex = 8;
            this.btnResetZoom.Text = "Reset zoom";
            this.btnResetZoom.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResetZoom.UseAccentColor = false;
            this.btnResetZoom.UseVisualStyleBackColor = true;
            this.btnResetZoom.Click += new System.EventHandler(this.btnResetZoom_Click);
            // 
            // swHEWrap
            // 
            this.swHEWrap.AutoSize = true;
            this.swHEWrap.Depth = 0;
            this.swHEWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swHEWrap.Location = new System.Drawing.Point(292, 0);
            this.swHEWrap.Margin = new System.Windows.Forms.Padding(0);
            this.swHEWrap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swHEWrap.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.swHEWrap.Name = "swHEWrap";
            this.swHEWrap.Ripple = true;
            this.swHEWrap.Size = new System.Drawing.Size(150, 34);
            this.swHEWrap.TabIndex = 4;
            this.swHEWrap.Text = "Wrap Text";
            this.swHEWrap.UseVisualStyleBackColor = true;
            this.swHEWrap.CheckedChanged += new System.EventHandler(this.swHEWrap_CheckedChanged);
            // 
            // rchHtmlEditor
            // 
            this.rchHtmlEditor.BackColor = System.Drawing.Color.Black;
            this.rchHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchHtmlEditor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchHtmlEditor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rchHtmlEditor.Location = new System.Drawing.Point(3, 83);
            this.rchHtmlEditor.Name = "rchHtmlEditor";
            this.rchHtmlEditor.Size = new System.Drawing.Size(906, 344);
            this.rchHtmlEditor.TabIndex = 1;
            this.rchHtmlEditor.Text = "HTML Editor";
            this.rchHtmlEditor.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFind, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(906, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Depth = 0;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 34);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search :";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.HideSelection = true;
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(67, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(726, 36);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.UseTallSize = false;
            // 
            // btnFind
            // 
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFind.Depth = 0;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFind.HighEmphasis = true;
            this.btnFind.Icon = null;
            this.btnFind.Location = new System.Drawing.Point(800, 6);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFind.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnFind.Name = "btnFind";
            this.btnFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFind.Size = new System.Drawing.Size(102, 22);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFind.UseAccentColor = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // HtmlSaveFileDialog
            // 
            this.HtmlSaveFileDialog.DefaultExt = "html";
            this.HtmlSaveFileDialog.Filter = "html files (*.html)|*.html|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.HtmlSaveFileDialog.RestoreDirectory = true;
            // 
            // HtmlOpenFileDialog
            // 
            this.HtmlOpenFileDialog.DefaultExt = "html";
            this.HtmlOpenFileDialog.Filter = "html files (*.html)|*.html|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // htmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "htmlEditor";
            this.Text = "htmlEditor";
            this.Load += new System.EventHandler(this.htmlEditor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpHtmlEditor.ResumeLayout(false);
            this.tblPanelHtmlEditor.ResumeLayout(false);
            this.tblHEditorTools.ResumeLayout(false);
            this.tblHEditorTools.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpHtmlEditor;
        private TableLayoutPanel tblPanelHtmlEditor;
        private TableLayoutPanel tblHEditorTools;
        private MaterialSkin2DotNet.Controls.MaterialButton btnHESave;
        private MaterialSkin2DotNet.Controls.MaterialButton btnHEReload;
        private RichTextBox rchHtmlEditor;
        private MaterialSkin2DotNet.Controls.MaterialSwitch swHEWrap;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblZoomText;
        private MaterialSkin2DotNet.Controls.MaterialButton btnZoomIn;
        private MaterialSkin2DotNet.Controls.MaterialButton btnZoomOut;
        private SaveFileDialog HtmlSaveFileDialog;
        private OpenFileDialog HtmlOpenFileDialog;
        private MaterialSkin2DotNet.Controls.MaterialButton btnResetZoom;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblSearch;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtSearch;
        private MaterialSkin2DotNet.Controls.MaterialButton btnFind;
    }
}