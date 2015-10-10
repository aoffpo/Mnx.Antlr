parser grammar Sql_reducedParser;
options { tokenVocab=Sql_reducedLexer; } 
@parser::header {#pragma warning disable 3021}

@parser::members
{
    protected const int EOF = Eof;
}
 
@lexer::members
{
    protected const int EOF = Eof;
    protected const int HIDDEN = Hidden;
}
/*
 * Parser Rules
 */
prog : batch EOF;
  //  | Batch GoBatchList
	//;
batch : genericStatement 
	;

genericStatement : dmlStatement+;

dmlStatement : setStatement 
			 | selectStatement
			 | createTableStatement
			 | ifStatement
			 | dropTableStatement
			 | insertStatement
			 ;
 //Id
 //   | QuotedId | ;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// SELECT Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
selectStatement : selectQuery;
selectQuery : SELECT columnItemList fromClause
			| SELECT ((LITERAL | NULL) AS IDENTIFIER) (COMMA (LITERAL | NULL) AS columnNameQualified)* 
; 
columnItemList : columnNameList
	| columnWildQualifiedList
	| columnNameQualifiedList;
columnNameList : columnName (COMMA columnName)*;
columnNameQualified : columnName 
    | tableName '.' columnName
    | variableName '.' columnName;
columnNameQualifiedList : columnNameQualified (COMMA columnNameQualified)*;
columnWild : ASTERISK;
columnWildQualified : columnWild
    | objectName DOT columnWild
    | variableName DOT columnWild;
columnWildQualifiedList : columnWildQualified (COMMA columnWildQualified)*;

fromClause : FROM tableName;
////WhereClause : WHERE Predicate
////    |
////    ;
//source : sourceRowset;
//sourceRowset : variableName;
 
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE TABLE Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
createTableStatement
 : CREATE TABLE
   ( databaseName DOT )? (tempTableName | tableName) 
  // ( LPAREN columnName ( COMMA columnName )* ( COMMA table_constraint )* RPAREN ( K_WITHOUT IDENTIFIER )?
   ( LPAREN columnDescription ( COMMA columnDescription )* RPAREN )
   | AS selectStatement 
 ;
columnDescription : columnName datatype (NOT)? NULL columnConstraint?;
 //table_constraint
 //: ( K_CONSTRAINT name )?
 //  ( ( K_PRIMARY K_KEY | K_UNIQUE ) '(' indexed_column ( ',' indexed_column )* ')' conflict_clause
 //  | K_CHECK '(' expr ')'
 //  | K_FOREIGN K_KEY '(' column_name ( ',' column_name )* ')' foreign_key_clause
 //  )
 //;
 
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// SET (both variables and options, but not yet CLR UDT properties and fields)
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

setStatement : (setVariableStatement
    | setOptionStatement) SEMICOLON;
setVariableStatement : SET objectName COLON ;//Expression
//    | SET objectName '.' NamedFunctionList
//    | SET objectName ':' CursorDefinition;

setOptionStatement : 
	SET NOCOUNT setValue;
    //  SET Id SetValueList
    //| SET TRANSACTION SetValueList
    //| SET OFFSETS SetValueList
    //| SET ROWCOUNT SetValue
    //| SET STATISTICS SetValueList
    //| SET IDENTITY_INSERT TableNameQualified Toggle;

//SetValueList : SetValue SetValueList
//    | SetValue;

setValue : toggle ;
   /* Id
    | READ UNCOMMITTED
    | READ COMMITTED
    | REPEATABLE READ
    | Toggle
    | IntegerLiteral
    | StringValue;*/

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//  INSERT Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
insertStatement : insertColumnSpec insertSelectSpec ;
insertColumnSpec : INSERT (tempTableName | objectName) LPAREN columnItemList RPAREN ;
insertSelectSpec : ( insertSelectSpecItem )+ ;
insertSelectSpecItem : SELECT (aliasedSetValue)+ unionAll ;
aliasedSetValue : COMMA? (LITERAL | NULL)  AS columnName ;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//  Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
columnConstraint : identityStatement;
identityStatement : IDENTITY LPAREN DIGIT+ COMMA DIGIT+ RPAREN;
ifStatement : IF OBJECT_ID LPAREN IDENTIFIER RPAREN IS NOT NULL dropTableStatement;
varcharStatement :  (VARCHAR | NVARCHAR | NCHAR | CHAR) LPAREN DIGIT* RPAREN;
decimalStatement :  DECIMAL LPAREN DIGIT+ COMMA DIGIT+ RPAREN;
dropTableStatement : DROP TABLE tempTableName ;
unionAll : UNION ALL ;
toggle : ON
    | OFF;
 //decimal : decimal ( digit comma digit)
variableName 
	: anyname 
	;
objectName 
	: anyname 
	;
columnName 
	: (LBRACKET)? anyname (RBRACKET)? 
	;
tableName 
	: anyname 
	;
tempTableName 
	: (POUND tableName);
databaseName 
	: anyname 
	;
anyname
	: IDENTIFIER 
	| keyword
	//| STRING_LITERAL
	;
 datatype : 
	BIT
	| DATETIME
	| DECIMAL
	| FLOAT
	| INT
	| varcharStatement
	| decimalStatement
	; 
 keyword 
	 : ALL 
	 | SELECT
	 | FROM
	 | ACTION
	 | SELECT
	 | SET
	 | FROM 
	 | WHERE 
	 | FOR
	 | TABLE
	 | NOT 
	 | NULL
	 | IDENTITY
	 | AS
	 | DROP
	 | OBJECT_ID
	 | ON
	 | OFF
	 | TEMPDB
	 | UNION
	 | datatype
	 ;

 //island grammar for interior spaces ~mnop