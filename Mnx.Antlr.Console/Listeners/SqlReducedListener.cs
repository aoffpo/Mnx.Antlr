using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Mnx.Antlr.Console.Classes;
using Mnx.Antlr.Grammars.SqlReduced;

namespace Mnx.Antlr.Console.Listeners
{
    public class SqlReducedListener : ISql_reducedParserListener
    {
        private HtmlTextWriter _writer;
        private CssBuilder _styles;
        private Dictionary<string, string> _typeLookup;
        private List<string> _notnullLookup; 

        public SqlReducedListener(CssBuilder styles, HtmlTextWriter writer)
        {
            _writer = writer;
            _styles = styles;
            _typeLookup = new Dictionary<string, string>();
            _notnullLookup = new List<string>();
        }

        //public SqlReducedListener(Stream filestream)
        //{
        //    var inputStream = new AntlrInputStream(filestream);
        //    var lexer = new Sql_reducedLexer(inputStream);
        //}

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
          //  System.Console.WriteLine(context.GetText());
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
            _writer.RenderBeginTag(HtmlTextWriterTag.Head);
            _writer.AddAttribute(HtmlTextWriterAttribute.Type, "text/css");
            _writer.RenderBeginTag(HtmlTextWriterTag.Style);
            
        }

        public void ExitCreateTableStatement(Sql_reducedParser.CreateTableStatementContext context)
        {
            _writer.Write(_styles.Styles);
            _writer.RenderEndTag();            
            _writer.RenderEndTag();
            //create css for table definition
            //add content style for "NULL" conten when in non-null style
            
        }

        public void EnterColumnDescription(Sql_reducedParser.ColumnDescriptionContext context)
        {
           // System.Console.WriteLine("Enter" + context.columnName());
        }

        public void ExitColumnDescription(Sql_reducedParser.ColumnDescriptionContext context)
        {
            var constraint = context.columnConstraint();
            var columnName = context.columnName().GetText().Replace("[","").Replace("]","");
            var dataType =  context.datatype().GetText().ToLower();
            var nullable = context.NOT()== null;
            _typeLookup.Add(columnName, dataType);
            if (!nullable) _notnullLookup.Add(columnName);

            columnName = "#" +columnName;
            dataType = "." + dataType;
            //identity style
            _styles.CreateSelector(columnName);
            var value = constraint != null ? "yellow" : "white";
            _styles.AddProperty(columnName, "background-color", value);

            //datatype style
            _styles.CreateSelector(dataType);
            value = dataType == ".int" ? "blue" : "white";
            _styles.AddProperty(dataType, "background-color", value);
            

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
           _writer.RenderBeginTag(HtmlTextWriterTag.Body);
            _writer.RenderBeginTag(HtmlTextWriterTag.Table);
            _writer.RenderBeginTag(HtmlTextWriterTag.Tr);
        }

        public void ExitInsertStatement(Sql_reducedParser.InsertStatementContext context)
        {
            //setup table
            _writer.RenderEndTag();//table
            _writer.RenderEndTag();//body
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
            //create table cell
            
            //set css classes
            //insert value

        }

        public void EnterAliasedSetValue(Sql_reducedParser.AliasedSetValueContext context)
        {
            
        }

        public void ExitAliasedSetValue(Sql_reducedParser.AliasedSetValueContext context)
        {
            //if (context.objectName() == null) return;
            var value = context.LITERAL() == null ? "" : context.LITERAL().GetText();
            //context.columnItemList().

            var columnName = context.columnName().GetText();
            columnName = columnName.Replace("[", "");
            columnName = columnName.Replace("]", "");
            value = value.Replace("N'", "");
            value = value.Replace("'", "");
            var datatype = "";
            _typeLookup.TryGetValue(columnName, out datatype);

            //map columns to css created in CREATE Table
            //find datatype info in dictionary, check value against data type and add .typemismatch if mismatched
            var isResolved = TypeResolver.Resolve(datatype, value);
            //check if column not nullable; add .notnullable if NULL
            var notnull = _notnullLookup.Any(n => n == columnName);
            if (notnull && value.ToUpper() == "")
                _writer.AddAttribute(HtmlTextWriterAttribute.Class, "notnullable");
            else _writer.AddAttribute(HtmlTextWriterAttribute.Class, isResolved ? columnName : "typemismatch");
            _writer.RenderBeginTag(HtmlTextWriterTag.Td);         
            _writer.Write(value);
            _writer.RenderEndTag();
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

        public void EnterUnionAll(Sql_reducedParser.UnionAllContext context)
        {
            _writer.RenderEndTag();
        }

        public void ExitUnionAll(Sql_reducedParser.UnionAllContext context)
        {
            _writer.RenderBeginTag(HtmlTextWriterTag.Tr);
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
