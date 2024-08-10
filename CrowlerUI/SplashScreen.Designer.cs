namespace CrawlerUI
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spTimer = new System.Windows.Forms.Timer(this.components);
            this.MtProBar = new MaterialSkin2DotNet.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SlateGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(930, 530);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Eleven";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "AI-Driven Web Data Extractor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spTimer
            // 
            this.spTimer.Interval = 20;
            this.spTimer.Tick += new System.EventHandler(this.spTimer_Tick);
            // 
            // MtProBar
            // 
            this.MtProBar.Depth = 0;
            this.MtProBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MtProBar.Location = new System.Drawing.Point(96, 458);
            this.MtProBar.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.MtProBar.Name = "MtProBar";
            this.MtProBar.Size = new System.Drawing.Size(742, 5);
            this.MtProBar.Step = 2;
            this.MtProBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MtProBar.TabIndex = 4;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(930, 530);
            this.ControlBox = false;
            this.Controls.Add(this.MtProBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 530);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(930, 530);
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private MaterialSkin2DotNet.Controls.MaterialProgressBar PrgBar;
        private System.Windows.Forms.Timer spTimer;
        private MaterialSkin2DotNet.Controls.MaterialProgressBar MtProBar;
    }
}