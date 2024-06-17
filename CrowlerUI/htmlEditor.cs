using LibGeneralUtilities;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrawlerUI
{
    public partial class htmlEditor : MaterialForm
    {
        #region Variables
        private static string FullHtml = string.Empty;
        public Color DefaultColor { get; set; } = Color.WhiteSmoke;
        public Color TagColor { get; set; } = Color.RoyalBlue;
        public Color BracketsColor { get; set; } = Color.DimGray;
        public Color StringColor { get; set; } = Color.Orange;
        public Color LinkColor { get; set; } = Color.DarkCyan;
        public MaterialMessage Message { get; set; } = new MaterialMessage();
        #endregion

        #region Constructor

        public htmlEditor(string html)
        {
            try
            {
                InitializeComponent();
                FullHtml = html;
                if (string.IsNullOrEmpty(html))
                {
                    FullHtml = File.ReadAllText("C:\\Users\\shadi\\AppData\\Roaming\\Smart Crawler\\Output\\2023-12-01 15-41-24\\Training Files\\amazonae.html", Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        public htmlEditor(FileInfo FileInf)
        {
            try
            {
                InitializeComponent();
                if (FileInf.Exists)
                {
                    FullHtml = File.ReadAllText(FileInf.FullName, Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }

        }

        #endregion

        #region Methods

        private void SetHtmlEditorText()
        {
            try
            {
                FullHtml = modHtmlTextProcessing.PreProcessingHtml(FullHtml);
                if (!string.IsNullOrEmpty(FullHtml))
                {
                    rchHtmlEditor.Text = FullHtml;
                    //rchHtmlEditor.SuspendLayout();
                    //ColorHtmlTags(rchHtmlEditor);
                    //ColoringStringValues();
                    //rchHtmlEditor.ResumeLayout();
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void ColorHtmlTags(RichTextBox rchHtmlEditor)
        {
            try
            {
                // Get the current text of the rchHtmlEditor
                string text = rchHtmlEditor.Text;

                // Loop through each HTML tag and color it
                foreach (string tag in ModConstant.HTMLTagsList)
                {
                    // Find all instances of the tag in the text
                    int tagIndex = text.IndexOf("<" + tag);
                    while (tagIndex != -1)
                    {
                        // Color the tag
                        rchHtmlEditor.Select(tagIndex, tag.Length + 1);
                        rchHtmlEditor.SelectionColor = TagColor;

                        // Find the next instance of the tag
                        tagIndex = text.IndexOf("<" + tag, tagIndex + tag.Length);
                    }

                    // Find all instances of the tag in the text
                    tagIndex = text.IndexOf("/" + tag + ">");
                    while (tagIndex != -1)
                    {
                        // Color the tag
                        rchHtmlEditor.Select(tagIndex, tag.Length + 1);
                        rchHtmlEditor.SelectionColor = TagColor;

                        // Find the next instance of the tag
                        tagIndex = text.IndexOf("/" + tag + ">", tagIndex + tag.Length);
                    }
                }

                // Find all instances of the tag in the text
                int index = text.IndexOf("<");
                while (index != -1)
                {
                    // Color the tag
                    rchHtmlEditor.Select(index, 1);
                    rchHtmlEditor.SelectionColor = BracketsColor;

                    // Find the next instance of the tag
                    index = text.IndexOf("<", index + 1);
                }

                // Find all instances of the tag in the text
                index = text.IndexOf(">");
                while (index != -1)
                {
                    // Color the tag
                    rchHtmlEditor.Select(index, 1);
                    rchHtmlEditor.SelectionColor = BracketsColor;

                    // Find the next instance of the tag
                    index = text.IndexOf(">", index + 1);
                }
            }
            catch (Exception ex)
            {

                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void ColoringStringValues()
        {
            try
            {
                List<HtmlSection> StringSections = modHtmlTextProcessing.GetStringValues(FullHtml);
                foreach (HtmlSection Section in StringSections)
                {
                    rchHtmlEditor.Select(Section.Start, Section.Length);
                    rchHtmlEditor.SelectionColor = StringColor;
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        #endregion

        #region Events

        private void htmlEditor_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FullHtml))
            {
                SetHtmlEditorText();
            }
        }

        private void btnHESave_Click(object sender, EventArgs e)
        {
            try
            {
                if (HtmlSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(HtmlSaveFileDialog.FileName, rchHtmlEditor.Text);
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnHEReload_Click(object sender, EventArgs e)
        {
            try
            {
                if (HtmlOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FullHtml = File.ReadAllText(HtmlOpenFileDialog.FileName);
                    SetHtmlEditorText();
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rchHtmlEditor.ZoomFactor < 3)
                {
                    rchHtmlEditor.ZoomFactor += 0.5f;
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (rchHtmlEditor.ZoomFactor > 1)
                {
                    rchHtmlEditor.ZoomFactor -= 0.5f;
                }
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void swHEWrap_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                rchHtmlEditor.WordWrap = swHEWrap.Checked;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void btnResetZoom_Click(object sender, EventArgs e)
        {
            try
            {
                rchHtmlEditor.ZoomFactor = 1;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        #endregion

        private void btnFind_Click(object sender, EventArgs e)
        {
            //SuspendDrawing(rchHtmlEditor);

            //int index = 0;
            //string searchText = txtSearch.Text; // Replace with your search text
            //rchHtmlEditor.HideSelection = false; // Keep selection highlighted when focus is lost

            //while (index < rchHtmlEditor.Text.LastIndexOf(searchText))
            //{
            //    rchHtmlEditor.Find(searchText, index, rchHtmlEditor.TextLength, rchHtmlEditorFinds.None);
            //    rchHtmlEditor.SelectionBackColor = Color.LightYellow;
            //    index = rchHtmlEditor.Text.IndexOf(searchText, index) + searchText.Length;
            //}

            //ResumeDrawing(rchHtmlEditor);


            SuspendDrawing(rchHtmlEditor);
            rchHtmlEditor.SelectionStart = 0;
            rchHtmlEditor.SelectionLength = 0;
            rchHtmlEditor.Select(0, 0);

            int index = 0;
            rchHtmlEditor.HideSelection = false; // Keep selection highlighted when focus is lost

            // Find and highlight the first occurrence
            string searchText = txtSearch.Text;
            index = rchHtmlEditor.Text.IndexOf(txtSearch.Text);
            if (index != -1) // Check if the text was found
            {
                rchHtmlEditor.Select(index, searchText.Length);
                rchHtmlEditor.ScrollToCaret(); // Scrolls to the selected text
                rchHtmlEditor.SelectionBackColor = Color.Gray;
                index += searchText.Length;
            }

            // Find and highlight all other occurrences
            while (index < rchHtmlEditor.Text.LastIndexOf(searchText))
            {
                rchHtmlEditor.Find(searchText, index, rchHtmlEditor.TextLength, RichTextBoxFinds.None);
                rchHtmlEditor.SelectionBackColor = Color.Gray;
                index = rchHtmlEditor.Text.IndexOf(searchText, index) + searchText.Length;
            }

            ResumeDrawing(rchHtmlEditor);
        }

        // Import the necessary Windows API functions
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;

        public void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }



    }
}
