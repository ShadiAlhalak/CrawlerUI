namespace CrawlerUI
{
    partial class frmNewDS
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
            this.tlbMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblDSName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblDiscription = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtDescription = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox2();
            this.txtName = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnLaunch = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.tlbMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbMain
            // 
            this.tlbMain.ColumnCount = 4;
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.Controls.Add(this.lblDSName, 1, 1);
            this.tlbMain.Controls.Add(this.lblDiscription, 1, 2);
            this.tlbMain.Controls.Add(this.txtDescription, 1, 3);
            this.tlbMain.Controls.Add(this.txtName, 2, 1);
            this.tlbMain.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tlbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbMain.Location = new System.Drawing.Point(3, 64);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.RowCount = 6;
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.Size = new System.Drawing.Size(389, 307);
            this.tlbMain.TabIndex = 0;
            // 
            // lblDSName
            // 
            this.lblDSName.AutoSize = true;
            this.lblDSName.Depth = 0;
            this.lblDSName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDSName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDSName.Location = new System.Drawing.Point(8, 5);
            this.lblDSName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblDSName.Name = "lblDSName";
            this.lblDSName.Size = new System.Drawing.Size(109, 40);
            this.lblDSName.TabIndex = 0;
            this.lblDSName.Text = "Dataset Name:";
            this.lblDSName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Depth = 0;
            this.lblDiscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDiscription.Location = new System.Drawing.Point(8, 45);
            this.lblDiscription.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(109, 40);
            this.lblDiscription.TabIndex = 2;
            this.lblDiscription.Text = "Description :";
            this.lblDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tlbMain.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Depth = 0;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.HideSelection = true;
            this.txtDescription.Location = new System.Drawing.Point(8, 88);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(373, 161);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TabStop = false;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(123, 8);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(258, 36);
            this.txtName.TabIndex = 5;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.UseTallSize = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tlbMain.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLaunch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 255);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(373, 44);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(295, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(74, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "cancel";
            this.btnCancel.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLaunch.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLaunch.Depth = 0;
            this.btnLaunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaunch.HighEmphasis = true;
            this.btnLaunch.Icon = null;
            this.btnLaunch.Location = new System.Drawing.Point(213, 6);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLaunch.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLaunch.Size = new System.Drawing.Size(74, 32);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLaunch.UseAccentColor = false;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // frmNewDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 374);
            this.Controls.Add(this.tlbMain);
            this.Name = "frmNewDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dataset Info";
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlbMain;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblDSName;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblDiscription;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin2DotNet.Controls.MaterialButton btnCancel;
        private MaterialSkin2DotNet.Controls.MaterialButton btnLaunch;
        public MaterialSkin2DotNet.Controls.MaterialTextBox2 txtName;
        public MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox2 txtDescription;
    }
}