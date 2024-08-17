using LibGeneralUtilities;
using LibStructure;
using MaterialSkin2DotNet.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerUI
{
    public partial class frmNewDS : MaterialForm
    {
        public MaterialMessage Message { get; set; } = new MaterialMessage();
        public List<clsHtmlElem> Rules { get; set; } = new List<clsHtmlElem>();
        public clsLoginResBody LoginUser { get; set; } = new clsLoginResBody();
        public frmNewDS(List<clsHtmlElem> rules, clsLoginResBody LoginUser)
        {
            InitializeComponent();
            this.Rules = rules;
            this.LoginUser = LoginUser;
        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text))
                {
                    Message.Message = ModResoucres.MsgDataSetNameAndDescreptionAreRequired;
                    Message.MessageType = ModResoucres.MsgType_Error;
                    Message.ShowMessage();
                    return;
                }
                clsAddDocument doc = new clsAddDocument();
                doc.title = txtName.Text.ToLower();
                doc.description = txtDescription.Text.ToLower();
                var flds = Rules.Select(item => item.FieldName).Distinct().ToList();
                foreach (var item in flds)
                {
                    if (!string.IsNullOrEmpty(item?.ToString()))
                    {
                        clsAPIFields apiFields = new clsAPIFields();
                        apiFields.FieldName = item.ToLower();
                        apiFields.type = "text";
                        doc.fields.Add(apiFields);
                    }
                }
                string requestBody = Newtonsoft.Json.JsonConvert.SerializeObject(doc);
                var data = new StringContent(requestBody, Encoding.UTF8, "application/json");
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", LoginUser.access);

                    HttpResponseMessage response = await client.PostAsync("https://8b91-185-183-34-180.ngrok-free.app/documents/document/add", data);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //clsLoginResBody res = Newtonsoft.Json.JsonConvert.DeserializeObject<clsLoginResBody>(responseBody);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                Message.Message = ModResoucres.MsgFaildCreateDataset;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        #endregion
    }
}
