using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnx.Antlr.Console.Classes
{
    /// <summary>
    /// generate css
    /// notnull - color property gray unless overriden by non NULL text in aliasedSetValue:LITERAL (or by existence of  aliasedSetValue:NULL)
    /// 
    /// created bracketed strings with css attributes : value
    /// </summary>
    public class CssBuilder
    {
        private StringBuilder _styles;

        public String Styles
        {
            get
            {
                if (!_styles.ToString().EndsWith("</style>"))
                {
                    _styles.Append("</style>");
                }
                return _styles.ToString();
            }
        }

        public CssBuilder()
        {
            _styles = new StringBuilder();
            _styles.Append("<style type=\"text/css\">");
        }

        public string CreateSelector(string name)
        {
            return string.Empty;
        }

        public string AddProperty(string selector, string property, string value)
        {
            return selector;
        }
    }
}
