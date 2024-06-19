using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibGeneralUtilities
{
    public static class ModConstant
    {
        #region Folder & Files Names
        public const string cnst_SettingsFolder = "Settings";
        public const string cnst_TempFolder = "Temp";      
        public const string cnst_HtmlTextFile = "HtmlText";
        public const string cnst_TrainingFilesFolder = "Training Files";
        public const string cnst_ResultFolder = "Result";
        public const string cnst_ValuesFileName = "Values";
        public const string cnst_ScriptsFolderName = "Scripts";
        public const string cnst_LinksDisable_ScriptFileName = "LinksDisable";
        public const string cnst_GetAllElem_ScriptFileName = "GetAllElem";
        public const string cnst_HighlightHoverElement_ScriptFileName = "HighlightHoverElement";
        public const string cnst_Scroll_ScriptFileName = "ScrollScript";
        public const string cnst_Mouse_ScriptFileName = "Mouse";
        public const string cnst_OutputFolder = "Output";
        public const string cnst_FieldsFileName = "Fields";
        #endregion

        #region Extetions
        public const string cnst_txt_Extention = ".txt";
        public const string cnst_xml_Extention = ".xml";
        public const string cnst_html_Extention = ".html";
        public const string cnst_js_Extention = ".js";
        public const string cnst_json_Extention = ".json";
        #endregion

        #region URLs 
        public const string HomeUrl = "http://www.amazon.ae/";
        #endregion

        #region Validation
        public const string cnst_HttpPrefix = "http";
        public const string cnst_HttpsPrefix = "https";
        public const string cnst_HttpSuffix = "://";
        public const string cnst_WorldWideWeb = "www.";
        public const string cnst_comertialSite = ".com";
        #endregion

        #region General 

        #endregion

        #region HTML

        public static List<string> HTMLTagsList = new List<string>(){
        "!doctype html",
        "a",
        "abbr",
        "acronym",
        "address",
        "applet",
        "area",
        "article",
        "aside",
        "audio",
        "b",
        "base",
        "basefont",
        "bdi",
        "bdo",
        "bgsound",
        "big",
        "blink",
        "blockquote",
        "body",
        "br",
        "button",
        "canvas",
        "caption",
        "center",
        "cite",
        "code",
        "col",
        "colgroup",
        "content",
        "data",
        "datalist",
        "dd",
        "decorator",
        "del",
        "details",
        "dfn",
        "dir",
        "div",
        "dl",
        "dt",
        "element",
        "em",
        "embed",
        "fieldset",
        "figcaption",
        "figure",
        "font",
        "footer",
        "form",
        "frame",
        "frameset",
        "h1",
        "h2",
        "h3",
        "h4",
        "h5",
        "h6",
        "head",
        "header",
        "hgroup",
        "hr",
        "html",
        "i",
        "iframe",
        "img",
        "input",
        "ins",
        "isindex",
        "kbd",
        "keygen",
        "label",
        "legend",
        "li",
        "link",
        "listing",
        "main",
        "map",
        "mark",
        "marquee",
        "menu",
        "menuitem",
        "meta",
        "meter",
        "nav",
        "nobr",
        "noframes",
        "noscript",
        "object",
        "ol",
        "optgroup",
        "option",
        "output",
        "p",
        "param",
        "plaintext",
        "pre",
        "progress",
        "q",
        "rp",
        "rt",
        "ruby",
        "s",
        "samp",
        "script",
        "section",
        "select",
        "shadow",
        "small",
        "source",
        "spacer",
        "span",
        "strike",
        "strong",
        "style",
        "sub",
        "summary",
        "sup",
        "table",
        "tbody",
        "td",
        "template",
        "textarea",
        "tfoot",
        "th",
        "thead",
        "time",
        "title",
        "tr",
        "track",
        "tt",
        "u",
        "ul",
        "var",
        "video",
        "wbr",
        "xmp"
        };

        #endregion

        #region API Endpoints
        public const string cnstAPILogin = "Login";
        public const string cnstAPIGetSimilar = "get_similar";
        #endregion
    }
}
