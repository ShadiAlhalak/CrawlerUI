namespace CrawlerUI
{
    partial class frmSettings
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
            this.tblSettings = new System.Windows.Forms.TableLayoutPanel();
            this.txtOutput = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.txtHome = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.lblAIService = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.cmbColor = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAIService = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.tblSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSettings
            // 
            this.tblSettings.ColumnCount = 5;
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.24203F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblSettings.Controls.Add(this.txtOutput, 2, 3);
            this.tblSettings.Controls.Add(this.txtHome, 2, 2);
            this.tblSettings.Controls.Add(this.lblAIService, 1, 1);
            this.tblSettings.Controls.Add(this.lblHomePage, 1, 2);
            this.tblSettings.Controls.Add(this.lblOutputFolder, 1, 3);
            this.tblSettings.Controls.Add(this.materialButton2, 2, 6);
            this.tblSettings.Controls.Add(this.materialButton1, 3, 6);
            this.tblSettings.Controls.Add(this.cmbColor, 2, 4);
            this.tblSettings.Controls.Add(this.label4, 1, 4);
            this.tblSettings.Controls.Add(this.txtAIService, 2, 1);
            this.tblSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettings.Location = new System.Drawing.Point(3, 64);
            this.tblSettings.Name = "tblSettings";
            this.tblSettings.RowCount = 8;
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblSettings.Size = new System.Drawing.Size(726, 296);
            this.tblSettings.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.AnimateReadOnly = false;
            this.txtOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOutput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tblSettings.SetColumnSpan(this.txtOutput, 2);
            this.txtOutput.Depth = 0;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOutput.HideSelection = true;
            this.txtOutput.LeadingIcon = null;
            this.txtOutput.Location = new System.Drawing.Point(221, 108);
            this.txtOutput.MaxLength = 32767;
            this.txtOutput.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.PasswordChar = '\0';
            this.txtOutput.PrefixSuffixText = null;
            this.txtOutput.ReadOnly = false;
            this.txtOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutput.SelectedText = "";
            this.txtOutput.SelectionLength = 0;
            this.txtOutput.SelectionStart = 0;
            this.txtOutput.ShortcutsEnabled = true;
            this.txtOutput.Size = new System.Drawing.Size(496, 48);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TabStop = false;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOutput.TrailingIcon = null;
            this.txtOutput.UseSystemPasswordChar = false;
            // 
            // txtHome
            // 
            this.txtHome.AnimateReadOnly = false;
            this.txtHome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tblSettings.SetColumnSpan(this.txtHome, 2);
            this.txtHome.Depth = 0;
            this.txtHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHome.HideSelection = true;
            this.txtHome.LeadingIcon = null;
            this.txtHome.Location = new System.Drawing.Point(221, 58);
            this.txtHome.MaxLength = 32767;
            this.txtHome.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtHome.Name = "txtHome";
            this.txtHome.PasswordChar = '\0';
            this.txtHome.PrefixSuffixText = null;
            this.txtHome.ReadOnly = false;
            this.txtHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHome.SelectedText = "";
            this.txtHome.SelectionLength = 0;
            this.txtHome.SelectionStart = 0;
            this.txtHome.ShortcutsEnabled = true;
            this.txtHome.Size = new System.Drawing.Size(496, 48);
            this.txtHome.TabIndex = 5;
            this.txtHome.TabStop = false;
            this.txtHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHome.TrailingIcon = null;
            this.txtHome.UseSystemPasswordChar = false;
            // 
            // lblAIService
            // 
            this.lblAIService.AutoSize = true;
            this.lblAIService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAIService.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAIService.Location = new System.Drawing.Point(8, 5);
            this.lblAIService.Name = "lblAIService";
            this.lblAIService.Size = new System.Drawing.Size(207, 50);
            this.lblAIService.TabIndex = 0;
            this.lblAIService.Text = "AI Service URL:";
            this.lblAIService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHomePage.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHomePage.Location = new System.Drawing.Point(8, 55);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(207, 50);
            this.lblHomePage.TabIndex = 1;
            this.lblHomePage.Text = "Home Page Url:";
            this.lblHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutputFolder.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutputFolder.Location = new System.Drawing.Point(8, 105);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(207, 50);
            this.lblOutputFolder.TabIndex = 2;
            this.lblOutputFolder.Text = "Output Folder:";
            this.lblOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(568, 261);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(64, 24);
            this.materialButton2.TabIndex = 9;
            this.materialButton2.Text = "OK";
            this.materialButton2.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(640, 261);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 24);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "Cancel";
            this.materialButton1.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.AutoResize = false;
            this.cmbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblSettings.SetColumnSpan(this.cmbColor, 2);
            this.cmbColor.Depth = 0;
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbColor.DropDownHeight = 174;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.DropDownWidth = 121;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.IntegralHeight = false;
            this.cmbColor.ItemHeight = 43;
            this.cmbColor.Location = new System.Drawing.Point(221, 158);
            this.cmbColor.MaxDropDownItems = 4;
            this.cmbColor.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(271, 49);
            this.cmbColor.StartIndex = 0;
            this.cmbColor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selection Color:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAIService
            // 
            this.txtAIService.AnimateReadOnly = false;
            this.txtAIService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAIService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAIService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAIService.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tblSettings.SetColumnSpan(this.txtAIService, 2);
            this.txtAIService.Depth = 0;
            this.txtAIService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAIService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAIService.HideSelection = true;
            this.txtAIService.LeadingIcon = null;
            this.txtAIService.Location = new System.Drawing.Point(221, 8);
            this.txtAIService.MaxLength = 32767;
            this.txtAIService.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtAIService.Name = "txtAIService";
            this.txtAIService.PasswordChar = '\0';
            this.txtAIService.PrefixSuffixText = null;
            this.txtAIService.ReadOnly = false;
            this.txtAIService.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAIService.SelectedText = "";
            this.txtAIService.SelectionLength = 0;
            this.txtAIService.SelectionStart = 0;
            this.txtAIService.ShortcutsEnabled = true;
            this.txtAIService.Size = new System.Drawing.Size(496, 48);
            this.txtAIService.TabIndex = 4;
            this.txtAIService.TabStop = false;
            this.txtAIService.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAIService.TrailingIcon = null;
            this.txtAIService.UseSystemPasswordChar = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 363);
            this.Controls.Add(this.tblSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tblSettings.ResumeLayout(false);
            this.tblSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblSettings;
        private Label lblAIService;
        private Label lblHomePage;
        private Label lblOutputFolder;
        private Label label4;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cmbColor;
        private MaterialSkin2DotNet.Controls.MaterialButton materialButton2;
        private MaterialSkin2DotNet.Controls.MaterialButton materialButton1;
        public MaterialSkin2DotNet.Controls.MaterialTextBox2 txtOutput;
        public MaterialSkin2DotNet.Controls.MaterialTextBox2 txtHome;
        public MaterialSkin2DotNet.Controls.MaterialTextBox2 txtAIService;
    }
}