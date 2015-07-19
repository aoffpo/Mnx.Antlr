using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using Mnx.Antlr.Grammars.SqlReduced;
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
            IParseTree tree = parser.prog();
            System.Console.WriteLine(tree.ToStringTree(parser));
            //var visitor = new MSSql2008BaseVisitor<string>();
            //System.Console.WriteLine(visitor.Visit(tree));

        }
    }
}
