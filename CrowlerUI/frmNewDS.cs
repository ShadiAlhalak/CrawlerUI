using LibGeneralUtilities;
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

namespace CrawlerUI
{
    public partial class frmNewDS : MaterialForm
    {
        public MaterialMessage Message { get; set; } = new MaterialMessage();

        public frmNewDS()
        {
            InitializeComponent();
        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                Message.Message = ModResoucres.MsgDataSetNameAndDescreptionAreRequired;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
