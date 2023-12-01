﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LibGeneralUtilities
{
    public static class modHtmlTextProcessing
    {
        public static string PreProcessingHtml(string FullHtml)
        {
            string Output = string.Empty;
            try
            {
                Output = RemoveScripts(FullHtml);
                Output = RemoveStyles(Output);
                Output = RemoveComments(Output);
                Output = RemoveEmptyLines(Output);
            }
            catch (Exception ex)
            {
                Output = FullHtml;
            }
            return Output;
        }

        public static string RemoveScripts(string HtmlText)
        {
            string Output = string.Empty;
            try
            {
                //Remove Scripts
                List<HtmlSection> Scripts = new List<HtmlSection>();
                // Find all instances of the script in the text
                int StartIndex = HtmlText.IndexOf("<script");
                while (StartIndex != -1)
                {
                    int EndIndex = HtmlText.IndexOf("/script>", StartIndex) + 8;
                    Scripts.Add(new HtmlSection(StartIndex, EndIndex));
                    // Find the next instance of the script
                    StartIndex = HtmlText.IndexOf("<script", EndIndex);
                }
                Scripts.Reverse();
                foreach (HtmlSection Sec in Scripts)
                {
                    HtmlText = HtmlText.Remove(Sec.Start, Sec.End - Sec.Start);
                }
                Output = HtmlText;
            }
            catch (Exception ex)
            {
                Output = HtmlText;
            }
            return Output;
        }

        public static string RemoveComments(string HtmlText)
        {
            string Output = string.Empty;
            try
            {
                List<HtmlSection> Comments = new List<HtmlSection>();
                // Find all instances of the comments in the text
                int StartIndex = HtmlText.IndexOf("<!--");
                while (StartIndex != -1)
                {
                    int EndIndex = HtmlText.IndexOf(">", StartIndex) + 1;
                    Comments.Add(new HtmlSection(StartIndex, EndIndex));
                    // Find the next instance of the comment
                    StartIndex = HtmlText.IndexOf("<!--", EndIndex);
                }
                Comments.Reverse();
                foreach (HtmlSection Sec in Comments)
                {
                    HtmlText = HtmlText.Remove(Sec.Start, Sec.End - Sec.Start);
                }
                Output = HtmlText;
            }
            catch (Exception ex)
            {
                Output = HtmlText;
            }
            return Output;
        }

        public static string RemoveStyles(string HtmlText)
        {
            string Output = string.Empty;
            try
            {
                List<HtmlSection> Styles = new List<HtmlSection>();
                // Find all instances of the styles in the text
                int StartIndex = HtmlText.IndexOf("<style");
                while (StartIndex != -1)
                {
                    int EndIndex = HtmlText.IndexOf("/style>", StartIndex) + 7;
                    Styles.Add(new HtmlSection(StartIndex, EndIndex));
                    // Find the next instance of the tag
                    StartIndex = HtmlText.IndexOf("<style", EndIndex);
                }
                Styles.Reverse();
                foreach (HtmlSection Sec in Styles)
                {
                    HtmlText = HtmlText.Remove(Sec.Start, Sec.End - Sec.Start);
                }
                Output = HtmlText;
            }
            catch (Exception ex)
            {
                Output = HtmlText;
            }
            return Output;
        }

        public static string RemoveEmptyLines(string HtmlText)
        {
            string Output = string.Empty;
            try
            {
                Output = string.Join("\n", HtmlText.Split('\n').Where(line => !string.IsNullOrWhiteSpace(line)));
            }
            catch (Exception ex)
            {
                Output = HtmlText;
            }
            return Output;
        }
    }
}
