using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebApiResit.Helpers
{
    public class HtmlUtility
    {
        public static string EscapeForHtmlAttribute(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            return input.Replace("&", "&amp;")
                        .Replace("\"", "&quot;")  // double quote
                        .Replace("'", "&#39;")    // single quote
                        .Replace("<", "&lt;")
                        .Replace(">", "&gt;");
            //.Replace("\n", " ")       // optional: keep this commented to preserve newlines
            //.Replace("\r", " ");
        }



        public static string AmbilBulanTahun(DateTime tarikh)
        {
            // "MMMM" untuk nama penuh bulan
            // "yyyy" untuk format tahun 4 digit
            return tarikh.ToString("MMMM yyyy", CultureInfo.InvariantCulture);
        }
    }
}