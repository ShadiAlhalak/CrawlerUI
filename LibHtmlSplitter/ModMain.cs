using LibGeneralUtilities;
using System.Text;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using LibStructure;
using System.Diagnostics;
using System.Collections;
using System.Net.Http;

namespace LibHtmlSplitter
{
    public static class ModMain
    {
        public static clsElements CrawlCore(clsElements AllElements, List<clsHtmlElem> Rules)
        {
            clsElements Result = new clsElements();
            try
            {
                Result.LstElements = AllElements.LstElements.Where(elem => Rules.Any(rule =>
                    !string.IsNullOrEmpty(elem.ClassName) && !string.IsNullOrEmpty(rule.ClassName) && rule.ClassName == elem.ClassName
                    )).ToList();
                //var filteredListA = listA.Where(a => listB.Any(b => b.Id == a.Id)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return Result;
        }

        public static List<string> GetSrcValuesFromHtml(string htmlContent)
        {
            var srcValues = new List<string>();
            try
            {
                if (string.IsNullOrEmpty(htmlContent))
                {
                    return srcValues;
                }
                int index = 0;
                while (true)
                {
                    // Find the next occurrence of 'src="'
                    int srcIndex = htmlContent.IndexOf("src=\"", index, StringComparison.OrdinalIgnoreCase);
                    if (srcIndex == -1)
                        break; // No more 'src' attributes found

                    // Find the closing double quote after the 'src' value
                    int quoteIndex = htmlContent.IndexOf("\"", srcIndex + 5);
                    if (quoteIndex == -1)
                        break; // Malformed HTML

                    // Extract the 'src' value
                    string srcValue = htmlContent.Substring(srcIndex + 5, quoteIndex - (srcIndex + 5));
                    srcValues.Add(srcValue);

                    // Move the index to the next position
                    index = quoteIndex + 1;
                }
            }
            catch (Exception)
            {

            }
            return srcValues;
        }

        public static string KeepOnlyNumbers(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return Regex.Replace(input, "[^0-9]", "");
        }

        public static void htmlSplit(string FullHtml)
        {
            string newFullHtml = LibGeneralUtilities.modHtmlTextProcessing.PreProcessingHtml(FullHtml);
            File.AppendAllText("newFullHtml.html", newFullHtml);
            clsElements clsElements = new clsElements();
            clsElements = SplitHtmlToElements(newFullHtml);
            clsElements.LstElements = clsElements.LstElements.Where(item => !string.IsNullOrEmpty(item.Element)).ToList();

            string ErrorMessage = string.Empty;
            string fpath = @"C:\Users\shadi\Desktop\gsm\Values.xml";
            List<clsHtmlElem> SelElems = clsHtmlElem.LoadHtmlElementsFromFile(fpath, ref ErrorMessage);


            foreach (clsHtmlElem item in SelElems)
            {
                clsElements.LstElements.Where(i => i.ClassName == item.ClassName && i.Tag.Trim().ToLower() == item.tagName.Trim().ToLower() && i.TextContent.Trim().ToLower() == item.Value.Trim().ToLower()).All(it => it.HasData = true);
            }
            Debug.WriteLine(clsElements.LstElements.Where(it => it.HasData).Count());

        }
        //1-First one doesnt fill class id guid ...
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();

        //    int currentPosition = 0;
        //    int elementStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];

        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0]; // Get the first part (tag name)
        //            element.Start = elementStart;
        //            elementStack.Push(element);

        //            // Extract attributes (optional)
        //            foreach (string attribute in tagName.Split(' ').Skip(1))
        //            {
        //                // Implement logic to parse attribute (key-value pair) and set element properties like Id or ClassName
        //            }

        //            currentPosition++;
        //        }
        //        else
        //        {
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        elements.Add(element);
        //    }

        //    return elements;
        //}



        //2-Secound try fill class name id .. but not guid and just first class 
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();

        //    int currentPosition = 0;
        //    int elementStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];

        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart);
        //            string[] parts = tagName.Split(' ');
        //            clsElement element = new clsElement();
        //            element.Tag = parts[0]; // Tag name

        //            // Extract attributes (optional)
        //            foreach (string attribute in parts.Skip(1))
        //            {
        //                string[] keyValue = attribute.Split('=');
        //                if (keyValue.Length == 2)
        //                {
        //                    string key = keyValue[0].Trim();
        //                    string value = keyValue[1].Trim(new char[] { '\'', '"' }); // Remove quotes

        //                    if (key.Equals("id", StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        element.Id = value;
        //                    }
        //                    else if (key.Equals("class", StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        element.ClassName = value;
        //                    }
        //                    // Add logic for other attributes as needed
        //                }
        //            }

        //            element.Start = elementStart;
        //            elementStack.Push(element);

        //            currentPosition++;
        //        }
        //        else
        //        {
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        elements.Add(element);
        //    }

        //    return elements;
        //}




        ////3-Third try get guid and paprent guid same
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    Guid currentGuid = Guid.NewGuid(); // Start with a new GUID

        //    int currentPosition = 0;
        //    int elementStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];

        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //            currentGuid = Guid.NewGuid(); // Generate new GUID for each element
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart);
        //            string[] parts = tagName.Split(' ');
        //            clsElement element = new clsElement();
        //            element.Tag = parts[0]; // Tag name
        //            element.Guid = currentGuid.ToString();

        //            // Extract attributes (optional)
        //            foreach (string attribute in parts.Skip(1))
        //            {
        //                string[] keyValue = attribute.Split('=');
        //                if (keyValue.Length == 2)
        //                {
        //                    string key = keyValue[0].Trim();
        //                    string value = keyValue[1].Trim(new char[] { '\'', '"' }); // Remove quotes

        //                    if (key.Equals("id", StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        element.Id = value;
        //                    }
        //                    else if (key.Equals("class", StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        element.ClassName = value;
        //                    }
        //                    // Add logic for other attributes as needed
        //                }
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);

        //            currentPosition++;
        //        }
        //        else
        //        {
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        elements.Add(element);
        //    }

        //    return elements;
        //}


        //4-this must be the perfect function after all edits (perfectly not work :) )
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    Guid currentGuid = Guid.NewGuid(); // Start with a new GUID

        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    StringBuilder elementText = new StringBuilder(); // Track element text

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];

        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    element.TextContent = elementText.ToString().Trim(); // Set element text
        //                    elementText.Clear(); // Reset text builder

        //                    // Extract class names (assuming space-separated)
        //                    element.ClassName = "";
        //                    foreach (string attribute in element.Element.Split(' '))
        //                    {
        //                        if (attribute.StartsWith("class="))
        //                        {
        //                            string classValue = attribute.Substring(6).Trim(new char[] { '\'', '"' }); // Remove quotes
        //                            element.ClassName = (element.ClassName.Length > 0 ? element.ClassName + " " : "") + classValue;
        //                        }
        //                    }

        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //            currentGuid = Guid.NewGuid(); // Generate new GUID for each element
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            // Capture element text until next opening tag
        //            if (elementText.Length == 0) // Start capturing text
        //            {
        //                elementText.Append(html.Substring(currentPosition, 1));
        //            }
        //            currentPosition++;
        //        }
        //        else
        //        {
        //            elementText.Append(html[currentPosition]);
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        element.TextContent = elementText.ToString().Trim(); // Set element text
        //        elementText.Clear(); // Reset text builder

        //        // Extract class names (assuming space-separated)
        //        element.ClassName = "";
        //        foreach (string attribute in element.Element.Split(' '))
        //        {
        //            if (attribute.StartsWith("class="))
        //            {
        //                string classValue = attribute.Substring(6).Trim(new char[] { '\'', '"' }); // Remove quotes
        //                element.ClassName = (element.ClassName.Length > 0 ? element.ClassName + " " : "") + classValue;
        //            }
        //        }

        //        elements.Add(element);
        //    }

        //    return elements;
        //}



        //5-fifth try editing by copilot (still class name has proplem)
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    Guid currentGuid = Guid.NewGuid(); // Start with a new GUID

        //    int currentPosition = 0;
        //    int elementStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];

        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //            currentGuid = Guid.NewGuid(); // Generate new GUID for each element
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart);
        //            string[] parts = tagName.Split(' ');
        //            clsElement element = new clsElement();
        //            element.Tag = parts[0]; // Tag name
        //            element.Guid = currentGuid.ToString();

        //            // Extract attributes (optional)
        //            foreach (string attribute in parts.Skip(1))
        //            {
        //                string[] keyValue = attribute.Split('=');
        //                if (keyValue.Length == 2)
        //                {
        //                    string key = keyValue[0].Trim();
        //                    string value = keyValue[1].Trim(new char[] { '\'', '"' }); // Remove quotes

        //                    if (key.Equals("id", StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        element.Id = value;
        //                    }
        //                    else if (key.Equals("class", StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        // If ClassName already has a value, append the new class
        //                        if (!string.IsNullOrEmpty(element.ClassName))
        //                        {
        //                            element.ClassName += " " + value;
        //                        }
        //                        else
        //                        {
        //                            element.ClassName = value;
        //                        }
        //                    }
        //                    // Add logic for other attributes as needed
        //                }
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);

        //            currentPosition++;
        //        }
        //        else
        //        {
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        elements.Add(element);
        //    }

        //    return elements;
        //}


        //6-Copilot version (fixing class name problem)
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    Guid currentGuid = Guid.NewGuid(); // Start with a new GUID

        //    int currentPosition = 0;
        //    int elementStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];

        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //            currentGuid = Guid.NewGuid(); // Generate new GUID for each element
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0]; // Tag name
        //            element.Guid = currentGuid.ToString();

        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);

        //            currentPosition++;
        //        }
        //        else
        //        {
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        elements.Add(element);
        //    }

        //    return elements;
        //}

        ////7-Copilot work version(6) put with textcontext the pronblem of this code is guid and parent guid still same 
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    Guid currentGuid = Guid.NewGuid(); // Start with a new GUID
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == '<')
        //        {// Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition - 1;
        //                    element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //                    int textStart = element.Element.IndexOf('>') + 1;
        //                    if (textStart < element.Element.Length)
        //                    {
        //                        element.TextContent = element.Element.Substring(textStart).Trim(); // Added this line
        //                        int closingTagStart = element.TextContent.LastIndexOf('<');
        //                        if (closingTagStart != -1)
        //                        {
        //                            element.TextContent = element.TextContent.Substring(0, closingTagStart); // Remove closing tag
        //                        }
        //                    }
        //                    elements.Add(element);
        //                }
        //                currentPosition += 2;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition + 1;
        //            currentPosition++;
        //            currentGuid = Guid.NewGuid(); // Generate new GUID for each element
        //        }
        //        else if (currentChar == ' ' || currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0]; // Tag name
        //            element.Guid = currentGuid.ToString();
        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);

        //            currentPosition++;
        //        }
        //        else
        //        {
        //            currentPosition++;
        //        }
        //    }

        //    // Handle remaining elements in stack (self-closing tags)
        //    while (elementStack.Count > 0)
        //    {
        //        clsElement element = elementStack.Pop();
        //        element.End = html.Length - 1;
        //        element.Element = html.Substring(elementStart, element.End - elementStart + 1);
        //        int textStart = element.Element.IndexOf('>') + 1;
        //        if (textStart < element.Element.Length)
        //        {
        //            element.TextContent = element.Element.Substring(textStart).Trim(); // Added this line
        //            int closingTagStart = element.TextContent.LastIndexOf('<');
        //            if (closingTagStart != -1)
        //            {
        //                element.TextContent = element.TextContent.Substring(0, closingTagStart); // Remove closing tag
        //            }
        //        }
        //        elements.Add(element);
        //    }
        //    return elements;
        //}

        ////8-Copilot work version(7) put with fixing guid problem (testing result is perfect with my simple example)
        ///note: I note sorting of list is not ok it start with cheldren then add parents (need reverse not fix full proplem but its better)
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                currentPosition += 2; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != '>') // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    element.End = currentPosition;
        //                    element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                    elements.Add(element);
        //                }
        //                currentPosition++;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim('<', '>'); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element
        //                                                      // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}



        ////9-try get data just from body (need reverse)
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    bool isBody = false; // Flag to check if we are inside the body tag

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                currentPosition += 2; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != '>') // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    if (isBody)
        //                    {
        //                        element.End = currentPosition;
        //                        element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                        elements.Add(element);
        //                    }
        //                    if (element.Tag == "body")
        //                    {
        //                        isBody = false;
        //                    }
        //                }
        //                currentPosition++;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim('<', '>'); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element
        //                                                      // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);

        //            if (element.Tag == "body")
        //            {
        //                isBody = true;
        //            }
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}

        //////10-try add element in correct sort add element when open not when close

        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> elementStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    bool isBody = false; // Flag to check if we are inside the body tag

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                currentPosition += 2; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != '>') // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (elementStack.Count > 0)
        //                {
        //                    clsElement element = elementStack.Pop();
        //                    if (isBody)
        //                    {
        //                        element.End = currentPosition;
        //                        element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                    }
        //                    if (element.Tag == "body")
        //                    {
        //                        isBody = false;
        //                    }
        //                }
        //                currentPosition++;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim('<', '>'); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element

        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (elementStack.Count > 0)
        //            {
        //                element.ParentGuid = elementStack.Peek().Guid; // Set parent GUID
        //            }
        //            elementStack.Push(element);

        //            // Add the element to the list right after it is created
        //            if (isBody)
        //            {
        //                elements.Add(element);
        //            }

        //            if (element.Tag == "body")
        //            {
        //                isBody = true;
        //            }
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}


        //11- enhanced version of code (10)
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    const char OPEN_TAG = '<';
        //    const char CLOSE_TAG = '>';
        //    const char END_TAG = '/';
        //    const int SKIP_END_TAG = 2;

        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> openElementsStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    bool isBody = false; // Flag to check if we are inside the body tag

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == OPEN_TAG)
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == END_TAG)
        //            {
        //                currentPosition += SKIP_END_TAG; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != CLOSE_TAG) // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (openElementsStack.Count > 0)
        //                {
        //                    clsElement element = openElementsStack.Pop();
        //                    if (isBody)
        //                    {
        //                        element.End = currentPosition;
        //                        element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                    }
        //                    if (element.Tag == "body")
        //                    {
        //                        isBody = false;
        //                    }
        //                }
        //                currentPosition++;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == CLOSE_TAG)
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim(OPEN_TAG, CLOSE_TAG); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element

        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (openElementsStack.Count > 0)
        //            {
        //                element.ParentGuid = openElementsStack.Peek().Guid; // Set parent GUID
        //            }
        //            openElementsStack.Push(element);

        //            // Add the element to the list right after it is created
        //            if (isBody)
        //            {
        //                elements.Add(element);
        //            }

        //            if (element.Tag == "body")
        //            {
        //                isBody = true;
        //            }
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}

        //Final version use Elements insted of list of elements
        //public static clsElements SplitHtmlToElements(string html)
        //{
        //    const char OPEN_TAG = '<';
        //    const char CLOSE_TAG = '>';
        //    const char END_TAG = '/';
        //    const int SKIP_END_TAG = 2;

        //    clsElements elements = new clsElements();
        //    Stack<clsElement> openElementsStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    bool isBody = false; // Flag to check if we are inside the body tag

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == OPEN_TAG)
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == END_TAG)
        //            {
        //                currentPosition += SKIP_END_TAG; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != CLOSE_TAG) // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (openElementsStack.Count > 0)
        //                {
        //                    clsElement element = openElementsStack.Pop();
        //                    if (isBody)
        //                    {
        //                        element.End = currentPosition;
        //                        element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                    }
        //                    if (element.Tag == "body")
        //                    {
        //                        isBody = false;
        //                    }
        //                }
        //                currentPosition++;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == CLOSE_TAG)
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim(OPEN_TAG, CLOSE_TAG); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element

        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (openElementsStack.Count > 0)
        //            {
        //                element.ParentGuid = openElementsStack.Peek().Guid; // Set parent GUID
        //            }
        //            openElementsStack.Push(element);

        //            // Add the element to the list right after it is created
        //            if (isBody)
        //            {
        //                elements.LstElements.Add(element);
        //            }

        //            if (element.Tag == "body")
        //            {
        //                isBody = true;
        //            }
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}

        /////13-Return text content 
        //public static clsElements SplitHtmlToElements(string html)
        //{
        //    clsElements elements = new clsElements();
        //    Stack<clsElement> openElementsStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    bool isBody = false; // Flag to check if we are inside the body tag
        //    int textStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                currentPosition += 2; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != '>') // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (openElementsStack.Count > 0)
        //                {
        //                    clsElement element = openElementsStack.Pop();
        //                    if (isBody)
        //                    {
        //                        element.End = currentPosition;
        //                        element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                        if (textStart < elementStart)
        //                        {
        //                            element.TextContent = html.Substring(textStart, elementStart - textStart).Trim();
        //                        }
        //                    }
        //                    if (element.Tag == "body")
        //                    {
        //                        isBody = false;
        //                    }
        //                }
        //                currentPosition++;
        //                textStart = currentPosition + 1;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim('<', '>'); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element

        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (openElementsStack.Count > 0)
        //            {
        //                element.ParentGuid = openElementsStack.Peek().Guid; // Set parent GUID
        //            }
        //            openElementsStack.Push(element);

        //            // Add the element to the list right after it is created
        //            if (isBody)
        //            {
        //                elements.LstElements.Add(element);
        //            }

        //            if (element.Tag == "body")
        //            {
        //                isBody = true;
        //            }
        //            textStart = currentPosition + 1;
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}

        //14- try return text content 
        //public static List<clsElement> SplitHtmlToElements(string html)
        //{
        //    List<clsElement> elements = new List<clsElement>();
        //    Stack<clsElement> openElementsStack = new Stack<clsElement>();
        //    int currentPosition = 0;
        //    int elementStart = 0;
        //    bool isBody = false; // Flag to check if we are inside the body tag
        //    int textStart = 0;

        //    while (currentPosition < html.Length)
        //    {
        //        char currentChar = html[currentPosition];
        //        if (currentChar == '<')
        //        {
        //            // Handle closing tag
        //            if (html[currentPosition + 1] == '/')
        //            {
        //                currentPosition += 2; // Skip over '</'
        //                while (currentPosition < html.Length && html[currentPosition] != '>') // Skip to end of closing tag
        //                {
        //                    currentPosition++;
        //                }
        //                if (openElementsStack.Count > 0)
        //                {
        //                    clsElement element = openElementsStack.Pop();
        //                    if (isBody)
        //                    {
        //                        element.End = currentPosition;
        //                        element.Element = html.Substring(element.Start, element.End - element.Start + 1);
        //                        //for (int i = element.Start; i < element.End - 1; i++)
        //                        //{
        //                        //    if (html[i] == '>')
        //                        //    {
        //                        //        string startText2Endelment = html.Substring(html[i + 1], element.End - element.Start);
        //                        //        element.TextContent = startText2Endelment.Substring(0, startText2Endelment.LastIndexOf("<") - (html[i] + 1));
        //                        //    }
        //                        //}
        //                    }
        //                    if (element.Tag == "body")
        //                    {
        //                        isBody = false;
        //                    }
        //                }
        //                currentPosition++;
        //                textStart = currentPosition + 1;
        //                continue;
        //            }

        //            // Create new element
        //            elementStart = currentPosition;
        //        }
        //        else if (currentChar == '>')
        //        {
        //            string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
        //            clsElement element = new clsElement();
        //            element.Tag = tagName.Split(' ')[0].Trim('<', '>'); // Tag name
        //            element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element

        //            // Extract attributes (optional)
        //            var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
        //            if (match.Success)
        //            {
        //                element.ClassName = match.Groups[1].Value;
        //            }

        //            element.Start = elementStart;
        //            if (openElementsStack.Count > 0)
        //            {
        //                element.ParentGuid = openElementsStack.Peek().Guid; // Set parent GUID
        //            }
        //            openElementsStack.Push(element);

        //            //Add the element to the list right after it is created
        //            if (isBody)
        //            {
        //                elements.Add(element);
        //            }
        //            //if (isBody && element.End > element.Start)
        //            //{
        //            //        elements.Add(element);
        //            //}

        //            if (element.Tag == "body")
        //            {
        //                isBody = true;
        //            }
        //            textStart = currentPosition + 1;
        //        }
        //        currentPosition++;
        //    }

        //    return elements;
        //}


        //I- return to zero point test this function with rules from gemini 
        public static clsElements SplitHtmlToElements(string html, string debugvalue = "")
        {
            clsElements elements = new clsElements();
            Stack<clsElement> openElementsStack = new Stack<clsElement>();
            int currentPosition = 0;
            int elementStart = 0;
            bool isBody = false; // Flag to check if we are inside the body tag
            int textStart = 0;
            bool debug = false;

            while (currentPosition < html.Length)
            {
                if (!string.IsNullOrEmpty(debugvalue))
                {
                    string curval = html.Substring(currentPosition, debugvalue.Length);
                    if (curval == debugvalue)
                    {
                        debug = true;
                        Debugger.Launch();
                    }
                }
                char currentChar = html[currentPosition];
                if (currentChar == '<')
                {
                    // Handle closing tag
                    if (html[currentPosition + 1] == '/')
                    {
                        currentPosition += 2; // Skip over '</'
                        while (currentPosition < html.Length && html[currentPosition] != '>') // Skip to end of closing tag
                        {
                            currentPosition++;
                        }
                        if (openElementsStack.Count > 0)
                        {
                            clsElement element = openElementsStack.Pop();
                            if (isBody)
                            {
                                element.End = currentPosition;
                                element.Element = html.Substring(element.Start, element.End - element.Start + 1);

                                try
                                {
                                    int TextContentLength = element.End - textStart - element.Tag.Length - 2;
                                    if (TextContentLength > 0)
                                    {
                                        string text2end = html.Substring(textStart, TextContentLength);
                                        //element.TextContent = html.Substring(textStart, text2end.LastIndexOf("<")).Trim(); // Extract the text content
                                        element.TextContent = System.Net.WebUtility.HtmlDecode(text2end); // Decode HTML entities
                                    }
                                    else
                                    {
                                        //int start = element.Element.IndexOf('>') + 1;
                                        //int end = element.Element.LastIndexOf('<');
                                        //string innerText = element.Element.Substring(start, end - start).Trim();
                                        try
                                        {
                                            var textContents = new List<string>();
                                            int currentPos = 0;

                                            while (true)
                                            {
                                                int startTag = element.Element.IndexOf('<', currentPos);
                                                if (startTag == -1)
                                                    break; // لم يتم العثور على علامات

                                                int endTag = element.Element.IndexOf('>', startTag);
                                                if (endTag == -1)
                                                    break; // HTML غير صحيح

                                                string tag = element.Element.Substring(startTag, endTag - startTag + 1);
                                                if (!tag.StartsWith("</")) // تجاوز العلامات الإغلاقية
                                                {
                                                    int startText = endTag + 1;
                                                    int endText = element.Element.IndexOf('<', startText);
                                                    if (endText == -1)
                                                        endText = element.Element.Length; // نهاية النص

                                                    string innerText = element.Element.Substring(startText, endText - startText).Trim();
                                                    if (!string.IsNullOrEmpty(innerText))
                                                        textContents.Add(innerText);
                                                }

                                                currentPos = endTag + 1;
                                            }

                                            Console.WriteLine(textContents);
                                            string tempText = string.Join(" ", textContents);
                                            element.TextContent = System.Net.WebUtility.HtmlDecode(tempText); // Decode HTML entities
                                        }
                                        catch (Exception)
                                        {

                                        }

                                    }
                                }
                                catch { }
                            }
                            if (element.Tag == "body")
                            {
                                isBody = false;
                            }
                        }
                        currentPosition++;
                        textStart = currentPosition + 1;
                        continue;
                    }

                    // Create new element
                    elementStart = currentPosition;
                }
                else if (currentChar == '>')
                {
                    string tagName = html.Substring(elementStart, currentPosition - elementStart + 1);
                    clsElement element = new clsElement();
                    element.Tag = tagName.Split(' ')[0].Trim('<', '>'); // Tag name
                    element.Guid = Guid.NewGuid().ToString(); // Generate new GUID for each element

                    // Extract attributes (optional)
                    var match = Regex.Match(tagName, @"class\s*=\s*""([^""]*)""");
                    if (match.Success)
                    {
                        element.ClassName = match.Groups[1].Value;
                    }

                    match = Regex.Match(tagName, @"id\s*=\s*""([^""]*)""");
                    if (match.Success)
                    {
                        element.Id = match.Groups[1].Value;
                    }

                    element.Start = elementStart;
                    if (openElementsStack.Count > 0)
                    {
                        element.ParentGuid = openElementsStack.Peek().Guid; // Set parent GUID
                    }
                    openElementsStack.Push(element);

                    // Add the element to the list right after it is created
                    if (isBody)
                    {
                        elements.LstElements.Add(element);
                    }

                    if (element.Tag == "body")
                    {
                        isBody = true;
                    }
                    textStart = currentPosition + 1;
                }
                currentPosition++;
            }

            return elements;
        }

        //public static List<string> GetTextContentFromHtml(string htmlContent)
        //{
        //    var textContents = new List<string>();

        //    int index = 0;
        //    while (index < htmlContent.Length)
        //    {
        //        int startTagIndex = htmlContent.IndexOf('<', index);
        //        if (startTagIndex == -1)
        //            break; // No more tags found

        //        int endTagIndex = htmlContent.IndexOf('>', startTagIndex);
        //        if (endTagIndex == -1)
        //            break; // Malformed HTML

        //        string tag = htmlContent.Substring(startTagIndex, endTagIndex - startTagIndex + 1);
        //        if (!tag.StartsWith("</")) // Skip closing tags
        //        {
        //            int textStart = endTagIndex + 1;
        //            int nextTagIndex = htmlContent.IndexOf('<', textStart);
        //            int textEnd = (nextTagIndex != -1) ? nextTagIndex : htmlContent.Length;

        //            string textContent = htmlContent.Substring(textStart, textEnd - textStart).Trim();
        //            if (!string.IsNullOrEmpty(textContent))
        //                textContents.Add(textContent);
        //        }

        //        index = endTagIndex + 1;
        //    }

        //    return textContents;
        //}
    }
}