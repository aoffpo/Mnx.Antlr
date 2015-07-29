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

        public string Styles
        {
            get { return _styles.ToString(); }
        }

        public CssBuilder()
        {
            _styles = new StringBuilder();
         
            //add default styles
            _styles.AppendLine(".notnullable {background-color:red;}");
            _styles.AppendLine(".typemismatch { color: red;}");
            _styles.AppendLine(" th, td {border: 1px solid black;}");
        }

        public string CreateSelector(string name)
        {
            return name + "{ }";
        }

        public string AddProperty(string selector, string property, string value)
        {
            var styleList = _styles.ToString();
            selector = selector.Replace("[", "").Replace("]", "");
            var newProp = property + ":" + value + ";";
            //find selector in _styles
            var selectorIndex = styleList.IndexOf(selector, StringComparison.Ordinal);
            if (selectorIndex == -1)
            {
                _styles.AppendFormat("{0} {{ {1}:{2}; }}",selector,property,value);
            }
            else
            {
                
                //var startIndex = selectorIndex + selector.Length + 2;
                //append text at index
                //_styles.Insert(startIndex, newProp);
            }
            _styles.AppendLine();
            return selector;
        }
    }
}
