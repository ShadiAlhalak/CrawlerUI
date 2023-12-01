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
            this.swHEBold = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.swHEItalic = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.btnHESave = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnHEReload = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.rchHtmlEditor = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpHtmlEditor.SuspendLayout();
            this.tblPanelHtmlEditor.SuspendLayout();
            this.tblHEditorTools.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpHtmlEditor
            // 
            this.grpHtmlEditor.Controls.Add(this.tblPanelHtmlEditor);
            this.grpHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHtmlEditor.Location = new System.Drawing.Point(8, 8);
            this.grpHtmlEditor.Name = "grpHtmlEditor";
            this.grpHtmlEditor.Size = new System.Drawing.Size(778, 367);
            this.grpHtmlEditor.TabIndex = 0;
            this.grpHtmlEditor.TabStop = false;
            this.grpHtmlEditor.Text = "Html Editor";
            // 
            // tblPanelHtmlEditor
            // 
            this.tblPanelHtmlEditor.ColumnCount = 1;
            this.tblPanelHtmlEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelHtmlEditor.Controls.Add(this.tblHEditorTools, 0, 0);
            this.tblPanelHtmlEditor.Controls.Add(this.rchHtmlEditor, 0, 1);
            this.tblPanelHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelHtmlEditor.Location = new System.Drawing.Point(3, 23);
            this.tblPanelHtmlEditor.Name = "tblPanelHtmlEditor";
            this.tblPanelHtmlEditor.RowCount = 2;
            this.tblPanelHtmlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelHtmlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelHtmlEditor.Size = new System.Drawing.Size(772, 341);
            this.tblPanelHtmlEditor.TabIndex = 0;
            // 
            // tblHEditorTools
            // 
            this.tblHEditorTools.ColumnCount = 7;
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblHEditorTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblHEditorTools.Controls.Add(this.swHEBold, 0, 0);
            this.tblHEditorTools.Controls.Add(this.swHEItalic, 1, 0);
            this.tblHEditorTools.Controls.Add(this.btnHESave, 6, 0);
            this.tblHEditorTools.Controls.Add(this.btnHEReload, 5, 0);
            this.tblHEditorTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHEditorTools.Location = new System.Drawing.Point(3, 3);
            this.tblHEditorTools.Name = "tblHEditorTools";
            this.tblHEditorTools.RowCount = 1;
            this.tblHEditorTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHEditorTools.Size = new System.Drawing.Size(766, 34);
            this.tblHEditorTools.TabIndex = 0;
            // 
            // swHEBold
            // 
            this.swHEBold.AutoSize = true;
            this.swHEBold.Depth = 0;
            this.swHEBold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swHEBold.Location = new System.Drawing.Point(0, 0);
            this.swHEBold.Margin = new System.Windows.Forms.Padding(0);
            this.swHEBold.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swHEBold.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.swHEBold.Name = "swHEBold";
            this.swHEBold.Ripple = true;
            this.swHEBold.Size = new System.Drawing.Size(109, 34);
            this.swHEBold.TabIndex = 0;
            this.swHEBold.Text = "Bold";
            this.swHEBold.UseVisualStyleBackColor = true;
            // 
            // swHEItalic
            // 
            this.swHEItalic.AutoSize = true;
            this.swHEItalic.Depth = 0;
            this.swHEItalic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swHEItalic.Location = new System.Drawing.Point(109, 0);
            this.swHEItalic.Margin = new System.Windows.Forms.Padding(0);
            this.swHEItalic.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swHEItalic.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.swHEItalic.Name = "swHEItalic";
            this.swHEItalic.Ripple = true;
            this.swHEItalic.Size = new System.Drawing.Size(109, 34);
            this.swHEItalic.TabIndex = 1;
            this.swHEItalic.Text = "Italic";
            this.swHEItalic.UseVisualStyleBackColor = true;
            // 
            // btnHESave
            // 
            this.btnHESave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHESave.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHESave.Depth = 0;
            this.btnHESave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHESave.HighEmphasis = true;
            this.btnHESave.Icon = null;
            this.btnHESave.Location = new System.Drawing.Point(658, 6);
            this.btnHESave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHESave.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnHESave.Name = "btnHESave";
            this.btnHESave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHESave.Size = new System.Drawing.Size(104, 22);
            this.btnHESave.TabIndex = 2;
            this.btnHESave.Text = "Save ";
            this.btnHESave.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHESave.UseAccentColor = false;
            this.btnHESave.UseVisualStyleBackColor = true;
            // 
            // btnHEReload
            // 
            this.btnHEReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHEReload.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHEReload.Depth = 0;
            this.btnHEReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHEReload.HighEmphasis = true;
            this.btnHEReload.Icon = null;
            this.btnHEReload.Location = new System.Drawing.Point(549, 6);
            this.btnHEReload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHEReload.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnHEReload.Name = "btnHEReload";
            this.btnHEReload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHEReload.Size = new System.Drawing.Size(101, 22);
            this.btnHEReload.TabIndex = 3;
            this.btnHEReload.Text = "Reload";
            this.btnHEReload.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHEReload.UseAccentColor = false;
            this.btnHEReload.UseVisualStyleBackColor = true;
            // 
            // rchHtmlEditor
            // 
            this.rchHtmlEditor.BackColor = System.Drawing.Color.Black;
            this.rchHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchHtmlEditor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchHtmlEditor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rchHtmlEditor.Location = new System.Drawing.Point(3, 43);
            this.rchHtmlEditor.Name = "rchHtmlEditor";
            this.rchHtmlEditor.Size = new System.Drawing.Size(766, 295);
            this.rchHtmlEditor.TabIndex = 1;
            this.rchHtmlEditor.Text = "HTML Editor";
            // 
            // htmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "htmlEditor";
            this.Text = "htmlEditor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpHtmlEditor.ResumeLayout(false);
            this.tblPanelHtmlEditor.ResumeLayout(false);
            this.tblHEditorTools.ResumeLayout(false);
            this.tblHEditorTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpHtmlEditor;
        private TableLayoutPanel tblPanelHtmlEditor;
        private TableLayoutPanel tblHEditorTools;
        private MaterialSkin2DotNet.Controls.MaterialSwitch swHEBold;
        private MaterialSkin2DotNet.Controls.MaterialSwitch swHEItalic;
        private MaterialSkin2DotNet.Controls.MaterialButton btnHESave;
        private MaterialSkin2DotNet.Controls.MaterialButton btnHEReload;
        private RichTextBox rchHtmlEditor;
    }
}