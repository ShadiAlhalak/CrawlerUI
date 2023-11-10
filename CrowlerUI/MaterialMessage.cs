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
    public partial class MaterialMessage : MaterialSkin2DotNet.Controls.MaterialForm
    {
        public string Message
        {
            get { return lblMessage.Text; }
            set
            {
                lblMessage.Text = value;
            }
        }

        public string MessageType
        {
            get { return this.Text; }
            set
            {
                this.Text = value;
            }
        }

        public MaterialMessage()
        {
            InitializeComponent();
        }

        public MaterialMessage(string Message, string MessageType)
        {
            InitializeComponent();
            lblMessage.Text = Message;
            this.Text = MessageType;
        }

        public void ShowMessage()
        {
            this.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
