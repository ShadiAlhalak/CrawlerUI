namespace CrawlerUI
{
    partial class frmProcessConfigrations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RdpServerPages = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            this.rdbClientPages = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            this.ckbLoopOnPages = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            this.grpSendData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialRadioButton1 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnOk = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpSendData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpSendData, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pages";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.RdpServerPages, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rdbClientPages, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ckbLoopOnPages, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 98);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RdpServerPages
            // 
            this.RdpServerPages.AutoSize = true;
            this.RdpServerPages.Depth = 0;
            this.RdpServerPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdpServerPages.Location = new System.Drawing.Point(0, 64);
            this.RdpServerPages.Margin = new System.Windows.Forms.Padding(0);
            this.RdpServerPages.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdpServerPages.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.RdpServerPages.Name = "RdpServerPages";
            this.RdpServerPages.Ripple = true;
            this.RdpServerPages.Size = new System.Drawing.Size(530, 34);
            this.RdpServerPages.TabIndex = 2;
            this.RdpServerPages.TabStop = true;
            this.RdpServerPages.Text = "Server";
            this.RdpServerPages.UseVisualStyleBackColor = true;
            // 
            // rdbClientPages
            // 
            this.rdbClientPages.AutoSize = true;
            this.rdbClientPages.Checked = true;
            this.rdbClientPages.Depth = 0;
            this.rdbClientPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbClientPages.Location = new System.Drawing.Point(0, 32);
            this.rdbClientPages.Margin = new System.Windows.Forms.Padding(0);
            this.rdbClientPages.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbClientPages.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.rdbClientPages.Name = "rdbClientPages";
            this.rdbClientPages.Ripple = true;
            this.rdbClientPages.Size = new System.Drawing.Size(530, 32);
            this.rdbClientPages.TabIndex = 1;
            this.rdbClientPages.TabStop = true;
            this.rdbClientPages.Text = "Client";
            this.rdbClientPages.UseVisualStyleBackColor = true;
            // 
            // ckbLoopOnPages
            // 
            this.ckbLoopOnPages.AutoSize = true;
            this.ckbLoopOnPages.Checked = true;
            this.ckbLoopOnPages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLoopOnPages.Depth = 0;
            this.ckbLoopOnPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbLoopOnPages.Location = new System.Drawing.Point(0, 0);
            this.ckbLoopOnPages.Margin = new System.Windows.Forms.Padding(0);
            this.ckbLoopOnPages.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbLoopOnPages.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.ckbLoopOnPages.Name = "ckbLoopOnPages";
            this.ckbLoopOnPages.ReadOnly = false;
            this.ckbLoopOnPages.Ripple = true;
            this.ckbLoopOnPages.Size = new System.Drawing.Size(530, 32);
            this.ckbLoopOnPages.TabIndex = 0;
            this.ckbLoopOnPages.Text = "Loop on pages";
            this.ckbLoopOnPages.UseVisualStyleBackColor = true;
            // 
            // grpSendData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpSendData, 2);
            this.grpSendData.Controls.Add(this.tableLayoutPanel3);
            this.grpSendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSendData.Location = new System.Drawing.Point(8, 138);
            this.grpSendData.Name = "grpSendData";
            this.grpSendData.Size = new System.Drawing.Size(536, 94);
            this.grpSendData.TabIndex = 4;
            this.grpSendData.TabStop = false;
            this.grpSendData.Text = "Send Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.materialRadioButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialRadioButton2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(530, 68);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialRadioButton1.Location = new System.Drawing.Point(0, 0);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(530, 34);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "HTML";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialRadioButton2.Location = new System.Drawing.Point(0, 34);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(530, 34);
            this.materialRadioButton2.TabIndex = 1;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "URLs";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOk, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 278);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(536, 44);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(450, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(82, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Depth = 0;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.HighEmphasis = true;
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(360, 6);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOk.Size = new System.Drawing.Size(82, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk.UseAccentColor = false;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmProcessConfigrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmProcessConfigrations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Process Configrations";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpSendData.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox ckbLoopOnPages;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton rdbClientPages;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdpServerPages;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grpSendData;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton materialRadioButton2;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin2DotNet.Controls.MaterialButton btnCancel;
        private MaterialSkin2DotNet.Controls.MaterialButton btnOk;
    }
}