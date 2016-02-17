using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Grammars.SqlReduced;

namespace Mnx.Antlr.Console.Listeners
{
    public class SqlToPocoListener : ISql_reducedParserListener
    {
        private string _objectType;
        private string _collectionType;
        private StringBuilder _result = new StringBuilder();
        public string Result { get { return _result.ToString(); } }
        private Dictionary<string, string> _typeLookup = new Dictionary<string, string>();

        public void VisitTerminal(ITerminalNode node)
        {
            
        }

        public void VisitErrorNode(IErrorNode node)
        {
            
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            
        }

        public void EnterProg(Sql_reducedParser.ProgContext context)
        {
            
        }

        public void ExitProg(Sql_reducedParser.ProgContext context)
        {
            _result.AppendLine(");");
        }

        public void EnterBatch(Sql_reducedParser.BatchContext context)
        {
            
        }

        public void ExitBatch(Sql_reducedParser.BatchContext context)
        {
            
        }

        public void EnterGenericStatement(Sql_reducedParser.GenericStatementContext context)
        {
            
        }

        public void ExitGenericStatement(Sql_reducedParser.GenericStatementContext context)
        {
            
        }

        public void EnterDmlStatement(Sql_reducedParser.DmlStatementContext context)
        {
            
        }

        public void ExitDmlStatement(Sql_reducedParser.DmlStatementContext context)
        {
            
        }

        public void EnterSelectStatement(Sql_reducedParser.SelectStatementContext context)
        {
            
        }

        public void ExitSelectStatement(Sql_reducedParser.SelectStatementContext context)
        {
            var tableName = context.selectQuery().GetText();//.columnNameQualified().FirstOrDefault().GetText();
            _result.AppendFormat("{0}Repository.FirstOrDefault(p=>p.{1} = \"{2}\" && p.{3} == {4};",
                tableName,
                "wherevarname1",
                "wherevarvalue1",
                "wherevarname2,",
                "wherevarvalue2");
        }

        public void EnterSelectQuery(Sql_reducedParser.SelectQueryContext context)
        {
            
        }

        public void ExitSelectQuery(Sql_reducedParser.SelectQueryContext context)
        {
            
        }

        public void EnterColumnItemList(Sql_reducedParser.ColumnItemListContext context)
        {
            
        }

        public void ExitColumnItemList(Sql_reducedParser.ColumnItemListContext context)
        {
            
        }

        public void EnterColumnNameList(Sql_reducedParser.ColumnNameListContext context)
        {
            
        }

        public void ExitColumnNameList(Sql_reducedParser.ColumnNameListContext context)
        {
            
        }

        public void EnterColumnNameQualified(Sql_reducedParser.ColumnNameQualifiedContext context)
        {
            
        }

        public void ExitColumnNameQualified(Sql_reducedParser.ColumnNameQualifiedContext context)
        {
            
        }

        public void EnterColumnNameQualifiedList(Sql_reducedParser.ColumnNameQualifiedListContext context)
        {
            
        }

        public void ExitColumnNameQualifiedList(Sql_reducedParser.ColumnNameQualifiedListContext context)
        {
            
        }

        public void EnterColumnWild(Sql_reducedParser.ColumnWildContext context)
        {
            
        }

        public void ExitColumnWild(Sql_reducedParser.ColumnWildContext context)
        {
            
        }

        public void EnterColumnWildQualified(Sql_reducedParser.ColumnWildQualifiedContext context)
        {
            
        }

        public void ExitColumnWildQualified(Sql_reducedParser.ColumnWildQualifiedContext context)
        {
            
        }

        public void EnterColumnWildQualifiedList(Sql_reducedParser.ColumnWildQualifiedListContext context)
        {
            
        }

        public void ExitColumnWildQualifiedList(Sql_reducedParser.ColumnWildQualifiedListContext context)
        {
            
        }

        public void EnterFromClause(Sql_reducedParser.FromClauseContext context)
        {
            
        }

        public void ExitFromClause(Sql_reducedParser.FromClauseContext context)
        {
            
        }

        public void EnterCreateTableStatement(Sql_reducedParser.CreateTableStatementContext context)
        {
            
        }

        public void ExitCreateTableStatement(Sql_reducedParser.CreateTableStatementContext context)
        {

        }
        

        public void EnterColumnDescription(Sql_reducedParser.ColumnDescriptionContext context)
        {
            
        }

        public void ExitColumnDescription(Sql_reducedParser.ColumnDescriptionContext context)
        {
            var columnName = context.columnName().GetText().Replace("[", "").Replace("]", "");
            var dataType = context.datatype().GetText().ToLower();
           
            _typeLookup.Add(columnName, dataType);
        }

        public void EnterSetStatement(Sql_reducedParser.SetStatementContext context)
        {
            
        }

        public void ExitSetStatement(Sql_reducedParser.SetStatementContext context)
        {
            
        }

        public void EnterSetVariableStatement(Sql_reducedParser.SetVariableStatementContext context)
        {
            
        }

        public void ExitSetVariableStatement(Sql_reducedParser.SetVariableStatementContext context)
        {
            
        }

        public void EnterSetOptionStatement(Sql_reducedParser.SetOptionStatementContext context)
        {
            
        }

        public void ExitSetOptionStatement(Sql_reducedParser.SetOptionStatementContext context)
        {
            
        }

        public void EnterSetValue(Sql_reducedParser.SetValueContext context)
        {
            
        }

        public void ExitSetValue(Sql_reducedParser.SetValueContext context)
        {
            
        }

        public void EnterInsertStatement(Sql_reducedParser.InsertStatementContext context)
        {
            
            
        }

        public void ExitInsertStatement(Sql_reducedParser.InsertStatementContext context)
        {

        }

        public void EnterInsertColumnSpec(Sql_reducedParser.InsertColumnSpecContext context)
        {

        }

        public void ExitInsertColumnSpec(Sql_reducedParser.InsertColumnSpecContext context)
        {
           
        }

        public void EnterInsertSelectSpec(Sql_reducedParser.InsertSelectSpecContext context)
        {
           
        }

        public void ExitInsertSelectSpec(Sql_reducedParser.InsertSelectSpecContext context)
        {
           
        }

        public void EnterInsertSelectSpecItem(Sql_reducedParser.InsertSelectSpecItemContext context)
        {
            _result.AppendFormat("new {0}() {{ ", _objectType);
        }

        public void ExitInsertSelectSpecItem(Sql_reducedParser.InsertSelectSpecItemContext context)
        {
           
        }

        public void EnterAliasedSetValue(Sql_reducedParser.AliasedSetValueContext context)
        {
            
        }

        public void ExitAliasedSetValue(Sql_reducedParser.AliasedSetValueContext context)
        {
            var value = context.LITERAL() == null ? "null" : context.LITERAL().GetText();

            var columnName = context.columnName().GetText();
            columnName = columnName.Replace("[", string.Empty)
                .Replace("]", string.Empty)
                .Replace("_ID", "Id")
                .Replace("_", string.Empty);
            value = value.Replace("N'", string.Empty).
                Replace("'", string.Empty);
            var datatype = string.Empty;
            _typeLookup.TryGetValue(columnName, out datatype);
            if (datatype != null)
            {
                if (datatype.Contains("date"))
                {

                    value = string.Format("DateTime.Parse(\"{0}\")", value);
                }
                else if (datatype.Contains("char"))
                {
                    value = @"""" + value + @"""";
                }

            }
            _result.AppendFormat("{0} = {1},",columnName, value);


        }

        public void EnterColumnConstraint(Sql_reducedParser.ColumnConstraintContext context)
        {
            
        }

        public void ExitColumnConstraint(Sql_reducedParser.ColumnConstraintContext context)
        {
            
        }

        public void EnterIdentityStatement(Sql_reducedParser.IdentityStatementContext context)
        {
            
        }

        public void ExitIdentityStatement(Sql_reducedParser.IdentityStatementContext context)
        {
            
        }

        public void EnterIfStatement(Sql_reducedParser.IfStatementContext context)
        {
            
        }

        public void ExitIfStatement(Sql_reducedParser.IfStatementContext context)
        {
            
        }

        public void EnterVarcharStatement(Sql_reducedParser.VarcharStatementContext context)
        {
            
        }

        public void ExitVarcharStatement(Sql_reducedParser.VarcharStatementContext context)
        {
            
        }

        public void EnterDecimalStatement(Sql_reducedParser.DecimalStatementContext context)
        {
            
        }

        public void ExitDecimalStatement(Sql_reducedParser.DecimalStatementContext context)
        {
            
        }

        public void EnterDropTableStatement(Sql_reducedParser.DropTableStatementContext context)
        {
            
        }

        public void ExitDropTableStatement(Sql_reducedParser.DropTableStatementContext context)
        {           
        }

        public void EnterDeclareStatement(Sql_reducedParser.DeclareStatementContext context)
        {
        }

        public void ExitDeclareStatement(Sql_reducedParser.DeclareStatementContext context)
        {
            var variableName = context.variableName().GetText();

            _result.AppendFormat("var {0} =  ", variableName);
        }

        public void EnterUnionAll(Sql_reducedParser.UnionAllContext context)
        {
            
        }

        public void ExitUnionAll(Sql_reducedParser.UnionAllContext context)
        {
            _result.AppendLine("},");  
        }

        public void EnterToggle(Sql_reducedParser.ToggleContext context)
        {
            
        }

        public void ExitToggle(Sql_reducedParser.ToggleContext context)
        {
            
        }

        public void EnterVariableName(Sql_reducedParser.VariableNameContext context)
        {
            
        }

        public void ExitVariableName(Sql_reducedParser.VariableNameContext context)
        {
            
        }

        public void EnterObjectName(Sql_reducedParser.ObjectNameContext context)
        {
            
        }

        public void ExitObjectName(Sql_reducedParser.ObjectNameContext context)
        {
            
        }

        public void EnterColumnName(Sql_reducedParser.ColumnNameContext context)
        {
            
        }

        public void ExitColumnName(Sql_reducedParser.ColumnNameContext context)
        {
            
        }

        public void EnterTableName(Sql_reducedParser.TableNameContext context)
        {
            
        }

        public void ExitTableName(Sql_reducedParser.TableNameContext context)
        {
            
        }

        public void EnterTempTableName(Sql_reducedParser.TempTableNameContext context)
        {
            
        }

        public void ExitTempTableName(Sql_reducedParser.TempTableNameContext context)
        {
            if (_objectType == null)
            {
                _objectType = context.tableName().GetText();
                _collectionType = _objectType + "s";

                var addOrUpdateStatement = string.Format("context.{0}.AddOrUpdate(x => x.Id,", _collectionType);
                _result.AppendLine(addOrUpdateStatement);
            }
        }

        public void EnterDatabaseName(Sql_reducedParser.DatabaseNameContext context)
        {
            
        }

        public void ExitDatabaseName(Sql_reducedParser.DatabaseNameContext context)
        {
            
        }

        public void EnterAnyname(Sql_reducedParser.AnynameContext context)
        {
            
        }

        public void ExitAnyname(Sql_reducedParser.AnynameContext context)
        {
            
        }

        public void EnterDatatype(Sql_reducedParser.DatatypeContext context)
        {
            
        }

        public void ExitDatatype(Sql_reducedParser.DatatypeContext context)
        {
            
        }

        public void EnterKeyword(Sql_reducedParser.KeywordContext context)
        {
            
        }

        public void ExitKeyword(Sql_reducedParser.KeywordContext context)
        {
            
        }
    }
}
