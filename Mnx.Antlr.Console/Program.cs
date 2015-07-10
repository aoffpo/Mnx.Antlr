using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
//using Mnx.Antlr.Grammars.MSSql2008;
using MSSql2008Lexer = Mnx.Antlr.Grammars.MSSql2008.Sql_reducedLexer;
using MSSql2008Parser = Mnx.Antlr.Grammars.MSSql2008.Sql_reducedParser;
namespace Mnx.Antlr.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStream = new AntlrInputStream("select colname1,colname2 from myTable");
            var lexer = new MSSql2008Lexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new MSSql2008Parser(tokens);
            IParseTree tree = parser.prog();
            System.Console.WriteLine(tree.ToStringTree(parser));
            //var visitor = new MSSql2008BaseVisitor<string>();
            //System.Console.WriteLine(visitor.Visit(tree));

        }
    }
}
