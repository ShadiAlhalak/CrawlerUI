using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using HtmlAgilityPack;

public static class htmlSplitter
{
    private static List<string> IgnoredElements = new List<string>() { "html", "head", "link", "script", "meta", "style" };
    public static List<string> SplitHtml(string FullHtml)
    {
        List<string> result = new List<string>();
        string htmlString = @"<html><head><title>صفحتي</title></head><body><h1>هذا هو العنوان</h1><p>هذه فقرة.</p></body></html>";

        var doc = new HtmlDocument();
        doc.LoadHtml(FullHtml);

        // الحصول على جميع العناصر
        var elements = doc.DocumentNode.Descendants();


        // تصفية حسب العناصر (باستثناء التعليقات وعقد النصوص)
        var elementList = elements.Where(n => n.NodeType == HtmlNodeType.Element);
        elementList = elementList.Where(n => !IgnoredElements.Contains(n.Name));

        var elementsInDivs = new List<HtmlNode>();  // قائمة فارغة لتخزين العناصر

        var allDivs = doc.DocumentNode.SelectNodes("//div");  // الحصول على جميع عناصر div

        foreach (var div in allDivs)
        {
            // الحصول على العناصر الفرعية لـ div الحالي
            var childElements = div.SelectNodes("./*");  // تحديد جميع العقد الفرعية باستخدام XPath

            // إضافة العناصر الفرعية (باستثناء التعليقات والعقد النصية) إلى القائمة
            if (childElements != null)
            {
                elementsInDivs.AddRange(childElements.Where(n => n.NodeType == HtmlNodeType.Element && !IgnoredElements.Contains(n.Name)));
                //elementsInDivs = elementsInDivs.Where(n => !IgnoredElements.Contains(n.Name)).ToList();
            }
        }

        foreach (var item in elementsInDivs)
        {
            if (item.InnerHtml.ToLower().Trim().Contains("note"))
            {
                Console.WriteLine(item.InnerText);
            }
        }

        foreach (var element in elementList)
        {
            Console.WriteLine($"اسم العلامة: {element.Name} |" + // الوصول إلى خصائص أخرى مثل النص الداخلي والصفات وما إلى ذلك
        $" المحتوى : {element.InnerText}"); // الوصول إلى اسم علامة العنصر (على سبيل المثال، h1، p)
            if (element.InnerText.ToLower().Trim().Contains("note"))
            {
                Console.WriteLine(element.Name);
            }
        }
        return result;
    }
}
