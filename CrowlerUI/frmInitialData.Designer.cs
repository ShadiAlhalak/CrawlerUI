namespace CrawlerUI
{
    partial class frmInitialData
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
            this.grpData = new System.Windows.Forms.GroupBox();
            this.tlbData = new System.Windows.Forms.TableLayoutPanel();
            this.dgvinitData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOrder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupParent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grpConfigrations = new System.Windows.Forms.GroupBox();
            this.tlbTools = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.materialCheckbox1 = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.materialCheckbox2 = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            this.btnApply = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnSave = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFild = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tlbMain.SuspendLayout();
            this.grpData.SuspendLayout();
            this.tlbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinitData)).BeginInit();
            this.grpConfigrations.SuspendLayout();
            this.tlbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tlbMain
            // 
            this.tlbMain.ColumnCount = 3;
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbMain.Controls.Add(this.grpData, 1, 2);
            this.tlbMain.Controls.Add(this.grpConfigrations, 1, 1);
            this.tlbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbMain.Location = new System.Drawing.Point(3, 64);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.RowCount = 4;
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlbMain.Size = new System.Drawing.Size(1367, 623);
            this.tlbMain.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.tlbData);
            this.grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData.Location = new System.Drawing.Point(8, 108);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(1351, 507);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // tlbData
            // 
            this.tlbData.ColumnCount = 1;
            this.tlbData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbData.Controls.Add(this.dgvinitData, 0, 0);
            this.tlbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbData.Location = new System.Drawing.Point(3, 23);
            this.tlbData.Name = "tlbData";
            this.tlbData.RowCount = 1;
            this.tlbData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbData.Size = new System.Drawing.Size(1345, 481);
            this.tlbData.TabIndex = 0;
            // 
            // dgvinitData
            // 
            this.dgvinitData.AllowUserToAddRows = false;
            this.dgvinitData.AllowUserToResizeRows = false;
            this.dgvinitData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvinitData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvinitData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinitData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.colGroup,
            this.colField,
            this.colPage,
            this.colOrder,
            this.FieldId,
            this.GroupParent});
            this.dgvinitData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvinitData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvinitData.Location = new System.Drawing.Point(3, 3);
            this.dgvinitData.MultiSelect = false;
            this.dgvinitData.Name = "dgvinitData";
            this.dgvinitData.RowHeadersVisible = false;
            this.dgvinitData.RowHeadersWidth = 51;
            this.dgvinitData.RowTemplate.Height = 29;
            this.dgvinitData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinitData.ShowCellErrors = false;
            this.dgvinitData.ShowRowErrors = false;
            this.dgvinitData.Size = new System.Drawing.Size(1339, 475);
            this.dgvinitData.TabIndex = 0;
            this.dgvinitData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinitData_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ClassName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Href";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Src";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // colGroup
            // 
            this.colGroup.HeaderText = "Group";
            this.colGroup.MinimumWidth = 6;
            this.colGroup.Name = "colGroup";
            // 
            // colField
            // 
            this.colField.HeaderText = "Field";
            this.colField.MinimumWidth = 6;
            this.colField.Name = "colField";
            // 
            // colPage
            // 
            this.colPage.HeaderText = "Page";
            this.colPage.MinimumWidth = 6;
            this.colPage.Name = "colPage";
            // 
            // colOrder
            // 
            this.colOrder.HeaderText = "Order";
            this.colOrder.MinimumWidth = 6;
            this.colOrder.Name = "colOrder";
            this.colOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FieldId
            // 
            this.FieldId.HeaderText = "FieldId";
            this.FieldId.MinimumWidth = 6;
            this.FieldId.Name = "FieldId";
            this.FieldId.ReadOnly = true;
            this.FieldId.Visible = false;
            // 
            // GroupParent
            // 
            this.GroupParent.HeaderText = "Group Parent";
            this.GroupParent.MinimumWidth = 6;
            this.GroupParent.Name = "GroupParent";
            // 
            // grpConfigrations
            // 
            this.grpConfigrations.Controls.Add(this.tlbTools);
            this.grpConfigrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfigrations.Location = new System.Drawing.Point(8, 8);
            this.grpConfigrations.Name = "grpConfigrations";
            this.grpConfigrations.Size = new System.Drawing.Size(1351, 94);
            this.grpConfigrations.TabIndex = 2;
            this.grpConfigrations.TabStop = false;
            this.grpConfigrations.Text = "Configrations";
            // 
            // tlbTools
            // 
            this.tlbTools.ColumnCount = 8;
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlbTools.Controls.Add(this.materialLabel1, 0, 0);
            this.tlbTools.Controls.Add(this.materialCheckbox1, 0, 1);
            this.tlbTools.Controls.Add(this.numUD, 1, 0);
            this.tlbTools.Controls.Add(this.materialCheckbox2, 1, 1);
            this.tlbTools.Controls.Add(this.btnApply, 2, 0);
            this.tlbTools.Controls.Add(this.btnSave, 2, 1);
            this.tlbTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbTools.Location = new System.Drawing.Point(3, 23);
            this.tlbTools.Name = "tlbTools";
            this.tlbTools.RowCount = 2;
            this.tlbTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbTools.Size = new System.Drawing.Size(1345, 68);
            this.tlbTools.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 34);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Selected items count :";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 34);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(168, 34);
            this.materialCheckbox1.TabIndex = 1;
            this.materialCheckbox1.Text = "Select Parents";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // numUD
            // 
            this.numUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUD.Location = new System.Drawing.Point(171, 3);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(162, 27);
            this.numUD.TabIndex = 2;
            this.numUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCheckbox2.Location = new System.Drawing.Point(168, 34);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(168, 34);
            this.materialCheckbox2.TabIndex = 3;
            this.materialCheckbox2.Text = "LoopOnPages";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApply.Depth = 0;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.HighEmphasis = true;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(337, 1);
            this.btnApply.Margin = new System.Windows.Forms.Padding(1);
            this.btnApply.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApply.Size = new System.Drawing.Size(166, 32);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply ";
            this.btnApply.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApply.UseAccentColor = false;
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(337, 35);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(166, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colTag
            // 
            this.colTag.HeaderText = "Tag";
            this.colTag.MinimumWidth = 6;
            this.colTag.Name = "colTag";
            this.colTag.ReadOnly = true;
            this.colTag.Width = 125;
            // 
            // colClassName
            // 
            this.colClassName.HeaderText = "ClassName";
            this.colClassName.MinimumWidth = 6;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            this.colClassName.Width = 125;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 125;
            // 
            // colHref
            // 
            this.colHref.HeaderText = "Href";
            this.colHref.MinimumWidth = 6;
            this.colHref.Name = "colHref";
            this.colHref.ReadOnly = true;
            this.colHref.Width = 125;
            // 
            // colSrc
            // 
            this.colSrc.HeaderText = "Src";
            this.colSrc.MinimumWidth = 6;
            this.colSrc.Name = "colSrc";
            this.colSrc.ReadOnly = true;
            this.colSrc.Width = 125;
            // 
            // colFild
            // 
            this.colFild.HeaderText = "Field";
            this.colFild.MinimumWidth = 6;
            this.colFild.Name = "colFild";
            this.colFild.ReadOnly = true;
            this.colFild.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFild.Width = 125;
            // 
            // frmInitialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 690);
            this.Controls.Add(this.tlbMain);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "frmInitialData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Data";
            this.tlbMain.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.tlbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinitData)).EndInit();
            this.grpConfigrations.ResumeLayout(false);
            this.tlbTools.ResumeLayout(false);
            this.tlbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlbMain;
        private TableLayoutPanel tlbTools;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private GroupBox grpData;
        private TableLayoutPanel tlbData;
        private DataGridView dgvinitData;
        private GroupBox grpConfigrations;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox materialCheckbox1;
        private NumericUpDown numUD;
        private DataGridViewTextBoxColumn colTag;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewTextBoxColumn colHref;
        private DataGridViewTextBoxColumn colSrc;
        private DataGridViewComboBoxColumn colFild;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin2DotNet.Controls.MaterialButton btnApply;
        private MaterialSkin2DotNet.Controls.MaterialButton btnSave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewComboBoxColumn colGroup;
        private DataGridViewComboBoxColumn colField;
        private DataGridViewCheckBoxColumn colPage;
        private DataGridViewComboBoxColumn colOrder;
        private DataGridViewTextBoxColumn FieldId;
        private DataGridViewComboBoxColumn GroupParent;
    }
}