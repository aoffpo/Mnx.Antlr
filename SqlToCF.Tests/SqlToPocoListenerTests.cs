using Antlr4.Runtime;
using Mnx.Antlr.Console.Listeners;
using Mnx.Antlr.Grammars.SqlReduced;
using NUnit.Framework;

namespace SqlToCF.Tests
{
    [TestFixture]
    public class SqlToPocoListenerTests
    {
        private static SqlToPocoListener _listener;
        private static Sql_reducedParser _parser;
        private static void Parse(string input)
        {
            var stream = new AntlrInputStream(input); //not IDisposable
            ITokenSource lexer = new Sql_reducedLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);//not IDisposable
            _parser = _parser ?? new Sql_reducedParser(tokens);
            _listener = _listener ?? new SqlToPocoListener();
            if (!_parser.ParseListeners.Contains(_listener))
            {
                _parser.AddParseListener(_listener);
            }
            _parser.prog();
        }

        [Test]
        public static void CreateRepositoryStatementTest()
        {
            const string sqlStatement = @"DECLARE @Account2PurposeCapitalPlanning INT
                SELECT @Account2PurposeCapitalPlanning = Purpose_ID
                FROM DSI.Purpose
                WHERE PurposeValueName = '*Capital Planning' AND AccountSummary_ID = 2";
            const string csStatement = "var Account2PurposeCapitalPlanning = purposeRepository.FirstOrDefault(p=>p.PurposeValueName = \"*CapitalPlanning\" && p.AccountSummaryId == 2);";

            Parse(sqlStatement);
            Assert.AreEqual(csStatement, _listener.Result);
        }
    }
}
