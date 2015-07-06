namespace Mnx.Antlr.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStream = new Antlr4.Runtime.AntlrFileStream("");
            var lexer = new Grammars.MSSql2008.MSSql2008Lexer(inputStream);
        }
    }
}
