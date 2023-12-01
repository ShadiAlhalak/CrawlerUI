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

                if (string.IsNullOrEmpty(html))
                {
                    FullHtml = File.ReadAllText("C:\\Users\\shadi\\AppData\\Roaming\\Smart Crawler\\Output\\2023-12-01 15-41-24\\Training Files\\amazonae.html", Encoding.UTF8);
                }
                if (!string.IsNullOrEmpty(FullHtml))
                {
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

        public htmlEditor(FileInfo FileInf)
        {
            try
            {
                InitializeComponent();
                if (FileInf.Exists)
                {
                    FullHtml = File.ReadAllText(FileInf.FullName, Encoding.UTF8);
                }
                if (!string.IsNullOrEmpty(FullHtml))
                {
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

        #endregion

        #region Methods

        private void SetHtmlEditorText()
        {
            try
            {
                FullHtml = modHtmlTextProcessing.PreProcessingHtml(FullHtml);
                ColorHtmlTags();
                ColoringStringValues();
                rchHtmlEditor.Text = FullHtml;
            }
            catch (Exception ex)
            {
                Message.Message = ex.Message;
                Message.MessageType = ModResoucres.MsgType_Error;
                Message.ShowMessage();
            }
        }

        private void ColorHtmlTags()
        {
            try
            {
                // Get the current text of the RichTextBox
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

    }
}
