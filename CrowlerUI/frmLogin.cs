using LibGeneralUtilities;
using LibStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerUI
{
    public partial class frmLogin : Form
    {
        public MaterialMessage Message { get; set; } = new MaterialMessage();

        public frmMain Main { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            Main = new frmMain();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                clsUser user = new clsUser();
                user.username = txtUser.Text;
                user.password = txtPassword.Text;
                string requestBody = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                var data = new StringContent(requestBody, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync("http://192.168.159.230:8000/auth/jwt/create/", data);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    clsLoginResBody res = Newtonsoft.Json.JsonConvert.DeserializeObject<clsLoginResBody>(responseBody);
                    Console.WriteLine(responseBody);
                    Main.LoginUser = res;
                    Main.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                Message.Message = ModResoucres.MsgLoginFaild;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
