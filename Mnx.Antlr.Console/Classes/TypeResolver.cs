using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnx.Antlr.Console.Classes
{
    public static class TypeResolver
    {
        public static bool Resolve(string type, string value)
        {
            switch (type.ToUpper())
            {
                case "BIT":
                    break;
                case "INT":
                    break;
                case "FLOAT":
                    break;
                case "NVARCHAR":
                    break;
                case "DECIMAL":
                    break;
                case "DATETIME":
                    break;

            }
            return true;
        }
    }
}
