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
        public Color StringColor { get; set; } = Color.OrangeRed;
        public Color LinkColor { get; set; } = Color.DarkCyan;
        #endregion

        #region Constructor

        public htmlEditor(string html)
        {
            FullHtml = File.ReadAllText("C:\\Users\\shadi\\AppData\\Roaming\\Smart Crawler\\Output\\2023-12-01 15-41-24\\Training Files\\amazonae.html", Encoding.UTF8);

            InitializeComponent();
            SetHtmlEditorText(FullHtml);
            ColorHtmlTags(rchHtmlEditor);
        }

        #endregion

        #region Methods

        private void SetHtmlEditorText(string FullHtml)
        {
            try
            {
                FullHtml = modHtmlTextProcessing.PreProcessingHtml(FullHtml);
                rchHtmlEditor.Text = FullHtml;
            }
            catch (Exception ex)
            {

            }
        }

        private void ColorHtmlTags(RichTextBox richTextBox)
        {
            // Get the current text of the RichTextBox
            string text = richTextBox.Text;

            // Loop through each HTML tag and color it
            foreach (string tag in ModConstant.HTMLTagsList)
            {
                // Find all instances of the tag in the text
                int tagIndex = text.IndexOf("<" + tag);
                while (tagIndex != -1)
                {
                    // Color the tag
                    richTextBox.Select(tagIndex, tag.Length + 1);
                    richTextBox.SelectionColor = TagColor;

                    // Find the next instance of the tag
                    tagIndex = text.IndexOf("<" + tag, tagIndex + tag.Length);
                }

                // Find all instances of the tag in the text
                tagIndex = text.IndexOf("/" + tag + ">");
                while (tagIndex != -1)
                {
                    // Color the tag
                    richTextBox.Select(tagIndex, tag.Length + 1);
                    richTextBox.SelectionColor = TagColor;

                    // Find the next instance of the tag
                    tagIndex = text.IndexOf("/" + tag + ">", tagIndex + tag.Length);
                }
            }

            // Find all instances of the tag in the text
            int index = text.IndexOf("<");
            while (index != -1)
            {
                // Color the tag
                richTextBox.Select(index, 1);
                richTextBox.SelectionColor = BracketsColor;

                // Find the next instance of the tag
                index = text.IndexOf("<", index + 1);
            }

            // Find all instances of the tag in the text
            index = text.IndexOf(">");
            while (index != -1)
            {
                // Color the tag
                richTextBox.Select(index, 1);
                richTextBox.SelectionColor = BracketsColor;

                // Find the next instance of the tag
                index = text.IndexOf(">", index + 1);
            }
        }

        private void ColoringTags()
        {
            // Loop through each word in the list
            foreach (string tag in ModConstant.HTMLTagsList)
            {
                int StartIndex = 0;
                while ((StartIndex = FullHtml.IndexOf("<" + tag, StartIndex)) != -1)
                {
                    // If the word is found, set the color of the text
                    if (StartIndex != -1)
                    {
                        rchHtmlEditor.SelectionStart = StartIndex;
                        rchHtmlEditor.SelectionLength = tag.Length;
                        rchHtmlEditor.SelectionColor = TagColor;
                    }
                    StartIndex++;
                }
            }
        }

        private void OriginalColorHtmlTags(RichTextBox richTextBox)
        {
            // Define the HTML tags that you want to color
            string[] htmlTags = { "html", "head", "title", "body", "div", "p", "span", "a", "img", "ul", "ol", "li", "table", "tr", "td", "th" };

            // Define the colors that you want to use for each tag
            Dictionary<string, Color> tagColors = new Dictionary<string, Color>
    {
        { "html", Color.Blue },
        { "head", Color.Blue },
        { "title", Color.Blue },
        { "body", Color.Blue },
        { "div", Color.Red },
        { "p", Color.Red },
        { "span", Color.Red },
        { "a", Color.Green },
        { "img", Color.Purple },
        { "ul", Color.Orange },
        { "ol", Color.Orange },
        { "li", Color.Orange },
        { "table", Color.DarkCyan },
        { "tr", Color.DarkCyan },
        { "td", Color.DarkCyan },
        { "th", Color.DarkCyan }
    };

            // Get the current text of the RichTextBox
            string text = richTextBox.Text;

            // Loop through each HTML tag and color it
            foreach (string tag in htmlTags)
            {
                // Find all instances of the tag in the text
                int index = text.IndexOf("<" + tag);

                while (index != -1)
                {
                    // Find the end of the tag
                    int endIndex = text.IndexOf(">", index);

                    // Color the tag
                    richTextBox.Select(index, endIndex - index + 1);
                    richTextBox.SelectionColor = tagColors[tag];

                    // Find the next instance of the tag
                    index = text.IndexOf("<" + tag, endIndex);
                }
            }
        }

        #endregion

        #region Events

        #endregion
    }
}
