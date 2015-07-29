using System;

namespace Mnx.Antlr.Console.Classes
{
    public static class TypeResolver
    {
        public static bool Resolve(string type, string value)
        {
           var typebase = type.Split('(');
            switch (typebase[0])
            {
                case "bit":
                    return value == "1" || value == "0";
                case "int":
                    int intval;
                    return int.TryParse(value,out intval);
                case "float":
                    float floatval;
                    return float.TryParse(value, out floatval);
                case "nvarchar":
                    var lengthstr = typebase[1].Replace("(", "").Replace(")", "");
                    var length = int.Parse(lengthstr);
                    return value.Length <= length;
                case "decimal":
                    decimal decval;
                    var parts = typebase[1].Replace("(", "").Replace(")", "").Split(',');
                    var charCount = int.Parse(parts[0]);
                    var decCount = int.Parse(parts[1]);
                    var result= decimal.TryParse(value, out decval);
                    var lengthresult = value.Length <= charCount;
                    return result && lengthresult;                    
                case "datetime":
                    DateTime date;
                    return DateTime.TryParse(value, out date);
                default:
                    return false;
            }
        }
    }
}
