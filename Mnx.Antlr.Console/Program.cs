using System.Diagnostics;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using System.Web.UI;
using Mnx.Antlr.Console.Classes;
using Mnx.Antlr.Console.Listeners;
using Mnx.Antlr.Grammars.SqlReduced;
namespace Mnx.Antlr.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("Filename is required");
                return;
            }
            var stream = new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var inputStream = new AntlrInputStream(stream);
            
            var lexer = new Sql_reducedLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new Sql_reducedParser(tokens);

            ParserRuleContext tree = parser.prog();
            var walker = new ParseTreeWalker();

            var listener = new SqlToPocoListener();                

            walker.Walk(listener, tree);
            var output = listener.Result;

            System.Console.WriteLine(output);
            var outputFileName = args[0].Replace(".sql", ".cs");
            File.WriteAllText(outputFileName, output);
            Process.Start(outputFileName);
        }
    }
}
