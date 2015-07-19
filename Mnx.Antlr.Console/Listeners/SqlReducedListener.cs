using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Grammars.SqlReduced;

namespace Mnx.Antlr.Console.Listeners
{
    public class SqlReducedListener : ISql_reducedParserListener
    {
        public SqlReducedListener(Stream filestream)
        {
            var inputStream = new AntlrInputStream(filestream);
            var lexer = new Sql_reducedLexer(inputStream);
        }

        public void VisitTerminal(ITerminalNode node)
        {
            throw new System.NotImplementedException();
        }

        public void VisitErrorNode(IErrorNode node)
        {
            throw new System.NotImplementedException();
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            throw new System.NotImplementedException();
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            throw new System.NotImplementedException();
        }

        public void EnterProg(Sql_reducedParser.ProgContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitProg(Sql_reducedParser.ProgContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterBatch(Sql_reducedParser.BatchContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitBatch(Sql_reducedParser.BatchContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterGenericStatement(Sql_reducedParser.GenericStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitGenericStatement(Sql_reducedParser.GenericStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterDmlStatement(Sql_reducedParser.DmlStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitDmlStatement(Sql_reducedParser.DmlStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterSelectStatement(Sql_reducedParser.SelectStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitSelectStatement(Sql_reducedParser.SelectStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterSelectQuery(Sql_reducedParser.SelectQueryContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitSelectQuery(Sql_reducedParser.SelectQueryContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnItemList(Sql_reducedParser.ColumnItemListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnItemList(Sql_reducedParser.ColumnItemListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnNameList(Sql_reducedParser.ColumnNameListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnNameList(Sql_reducedParser.ColumnNameListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnNameQualified(Sql_reducedParser.ColumnNameQualifiedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnNameQualified(Sql_reducedParser.ColumnNameQualifiedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnNameQualifiedList(Sql_reducedParser.ColumnNameQualifiedListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnNameQualifiedList(Sql_reducedParser.ColumnNameQualifiedListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnWild(Sql_reducedParser.ColumnWildContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnWild(Sql_reducedParser.ColumnWildContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnWildQualified(Sql_reducedParser.ColumnWildQualifiedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnWildQualified(Sql_reducedParser.ColumnWildQualifiedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnWildQualifiedList(Sql_reducedParser.ColumnWildQualifiedListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnWildQualifiedList(Sql_reducedParser.ColumnWildQualifiedListContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterFromClause(Sql_reducedParser.FromClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitFromClause(Sql_reducedParser.FromClauseContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterCreateTableStatement(Sql_reducedParser.CreateTableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitCreateTableStatement(Sql_reducedParser.CreateTableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnDescription(Sql_reducedParser.ColumnDescriptionContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnDescription(Sql_reducedParser.ColumnDescriptionContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterSetStatement(Sql_reducedParser.SetStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitSetStatement(Sql_reducedParser.SetStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterSetVariableStatement(Sql_reducedParser.SetVariableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitSetVariableStatement(Sql_reducedParser.SetVariableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterSetOptionStatement(Sql_reducedParser.SetOptionStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitSetOptionStatement(Sql_reducedParser.SetOptionStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterSetValue(Sql_reducedParser.SetValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitSetValue(Sql_reducedParser.SetValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterInsertStatement(Sql_reducedParser.InsertStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitInsertStatement(Sql_reducedParser.InsertStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterInsertColumnSpec(Sql_reducedParser.InsertColumnSpecContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitInsertColumnSpec(Sql_reducedParser.InsertColumnSpecContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterInsertSelectSpec(Sql_reducedParser.InsertSelectSpecContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitInsertSelectSpec(Sql_reducedParser.InsertSelectSpecContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterAliasedSetValue(Sql_reducedParser.AliasedSetValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitAliasedSetValue(Sql_reducedParser.AliasedSetValueContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnConstraint(Sql_reducedParser.ColumnConstraintContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnConstraint(Sql_reducedParser.ColumnConstraintContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterIdentityStatement(Sql_reducedParser.IdentityStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitIdentityStatement(Sql_reducedParser.IdentityStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterIfStatement(Sql_reducedParser.IfStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitIfStatement(Sql_reducedParser.IfStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterVarcharStatement(Sql_reducedParser.VarcharStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitVarcharStatement(Sql_reducedParser.VarcharStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterDecimalStatement(Sql_reducedParser.DecimalStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitDecimalStatement(Sql_reducedParser.DecimalStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterDropTableStatement(Sql_reducedParser.DropTableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitDropTableStatement(Sql_reducedParser.DropTableStatementContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterUnionAll(Sql_reducedParser.UnionAllContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitUnionAll(Sql_reducedParser.UnionAllContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterToggle(Sql_reducedParser.ToggleContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitToggle(Sql_reducedParser.ToggleContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterVariableName(Sql_reducedParser.VariableNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitVariableName(Sql_reducedParser.VariableNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterObjectName(Sql_reducedParser.ObjectNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitObjectName(Sql_reducedParser.ObjectNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterColumnName(Sql_reducedParser.ColumnNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitColumnName(Sql_reducedParser.ColumnNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterTableName(Sql_reducedParser.TableNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitTableName(Sql_reducedParser.TableNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterTempTableName(Sql_reducedParser.TempTableNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitTempTableName(Sql_reducedParser.TempTableNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterDatabaseName(Sql_reducedParser.DatabaseNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitDatabaseName(Sql_reducedParser.DatabaseNameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterAnyname(Sql_reducedParser.AnynameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitAnyname(Sql_reducedParser.AnynameContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterDatatype(Sql_reducedParser.DatatypeContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitDatatype(Sql_reducedParser.DatatypeContext context)
        {
            throw new System.NotImplementedException();
        }

        public void EnterKeyword(Sql_reducedParser.KeywordContext context)
        {
            throw new System.NotImplementedException();
        }

        public void ExitKeyword(Sql_reducedParser.KeywordContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
