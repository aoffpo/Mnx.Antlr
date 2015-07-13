using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private const string CREATE = @"CREATE TABLE #WorkOrder (
	        WorkOrder_ID INT NOT NULL
					         IDENTITY(1, 1),
	        [AccountSummary_ID] INT NOT NULL,
	        [RequestedByUserSummary_ID] INT NULL,
	        [Display_ID] INT NOT NULL,
	        [Latitude] FLOAT NOT NULL,
	        [Longitude] FLOAT NOT NULL,
	        [StreetAddress] NVARCHAR(60) NOT NULL,
	        [City] NVARCHAR(50) NULL,
	        [State] NVARCHAR(10) NULL,
	        [LatLongMatchesAddress] BIT NOT NULL,
	        [WorkOrderStatusTypeCode_ID] INT NOT NULL,
	        [WorkOrderPriorityTypeCode_ID] INT NOT NULL,
	        [Purpose_ID] INT NULL,
	        [WorkCategory_ID] INT NULL,
	        [Trade_ID] INT NULL,
	        [RequestDateTime] DATETIME NOT NULL,
	        [TotalCost] DECIMAL(14, 2) NULL,
	        [DescriptionValue] NVARCHAR(2000) NOT NULL,
	        [ActionTakenText] NVARCHAR(500) NULL,
	        [CompletedDateTime] DATETIME NULL,
	        [CreatedByDateTime] DATETIME NOT NULL,
	        [CreatedByUserSummary_ID] INT NOT NULL,
	        [UpdatedDateTime] DATETIME NOT NULL,
	        [UpdatedByUserSummary_ID] INT NOT NULL)";
        private const string SELECT = "select colname1,colname2,column3 from myTable";
        static void Main(string[] args)
        {
            var inputStream = new AntlrInputStream(CREATE);
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
