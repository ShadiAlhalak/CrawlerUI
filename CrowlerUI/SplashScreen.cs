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
    public partial class SplashScreen : Form
    {
        public frmMain Main { get; set; }

        public SplashScreen()
        {
            InitializeComponent();
            Main = new frmMain();
            spTimer.Enabled = true;
        }

        private void spTimer_Tick(object sender, EventArgs e)
        {
            if (MtProBar.Value < 100)
            {
                MtProBar.Value += MtProBar.Step;
            }
            else
            {
                spTimer.Enabled = false;
                Main.Show();
                this.Hide();
            }
        }
    }
}
