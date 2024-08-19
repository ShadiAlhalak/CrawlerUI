using LibGeneralUtilities;
using LibStructure;
using System.Text;

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
                string ErrorMessage = string.Empty;
                clsSettings settings = clsSettings.loadSettings(ref ErrorMessage);
                if (settings != null && !string.IsNullOrEmpty(settings.AIServiceUrl))
                {
                    clsUser user = new clsUser();
                    user.username = txtUser.Text;
                    user.password = txtPassword.Text;
                    string requestBody = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                    var data = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    clsLoginResBody res;
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"{settings.AIServiceUrl}{ModConstant.cnstAPILogin}";
                        HttpResponseMessage response = await client.PostAsync(url, data);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        res = Newtonsoft.Json.JsonConvert.DeserializeObject<clsLoginResBody>(responseBody);
                        Console.WriteLine(responseBody);
                        Main.LoginUser = res;
                        Main.Show();
                        this.Hide();
                    }
                }
                else
                {
                    Message.Message = ModResoucres.MsgAIServiceURLISInvalid;
                    Message.MessageType = ModResoucres.MsgType_Error;
                    Message.ShowMessage();
                }
                //using (HttpClient client = new HttpClient())
                //{
                //    try
                //    {
                //        // Send the GET request
                //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", res.access);

                //        HttpResponseMessage response = await client.GetAsync("https://8b91-185-183-34-180.ngrok-free.app/documents/document/es_data?title=shadi_es_data");

                //        // Check if the response indicates success
                //        if (response.IsSuccessStatusCode)
                //        {
                //            // Read the content as a byte array
                //            byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                //            // Specify the file path to save the downloaded file
                //            string filePath = Path.Combine(Environment.CurrentDirectory, "test.csv");

                //            // Write the bytes to a file
                //            await File.WriteAllBytesAsync(filePath, fileBytes);
                //            Console.WriteLine($"File downloaded successfully: {filePath}");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine($"Exception: {ex.Message}");
                //    }
            

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
