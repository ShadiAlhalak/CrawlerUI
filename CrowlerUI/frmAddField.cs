using LibStructure;
using LogManagment;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrawlerUI
{

    public partial class frmAddField : MaterialForm
    {
        bool EditMode = false;
        static clsFields Fields = clsFields.GetFields();
        clsField CurrentField = new clsField();

        public frmAddField()
        {
            InitializeComponent();
            FillTypes();
        }
        public frmAddField(string FieldId)
        {
            InitializeComponent();
            FillTypes();

            EditMode = true;

            CurrentField = Fields.LstFields.FirstOrDefault(x => x.Id == FieldId);
            if (CurrentField != null)
            {
                txtName.Text = CurrentField?.Name;
                txtDescription.Text = CurrentField?.Description;
                cmbType.SelectedItem = CurrentField?.Type;
            }
        }

        private void FillTypes()
        {
            //cmbType.DataSource = ModEnum.FieldsTypes;
            cmbType.DataSource = Enum.GetValues(typeof(ModEnum.FieldsTypes));
            cmbType.SelectedItem = ModEnum.FieldsTypes.Text;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                CurrentField.Name = txtName.Text;
                CurrentField.Description = txtDescription.Text;
                CurrentField.Type = (ModEnum.FieldsTypes)cmbType.SelectedItem;
                string ErrorMessage = string.Empty;
                Fields.SetFields();
                //if (!string.IsNullOrEmpty(ErrorMessage.Trim()))
                //{
                //    //ModLog
                //}
            }
            else
            {
                clsField NewField = new clsField();
                NewField.Id = Guid.NewGuid().ToString();
                NewField.Name = txtName.Text;
                NewField.Description = txtDescription.Text;
                NewField.Type = (ModEnum.FieldsTypes)cmbType.SelectedItem;
                Fields.LstFields.Add(NewField);
                string ErrorMessage = string.Empty;
                Fields.SetFields();
                //if (!string.IsNullOrEmpty(ErrorMessage.Trim()))
                //{
                //    //ModLog
                //}
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
