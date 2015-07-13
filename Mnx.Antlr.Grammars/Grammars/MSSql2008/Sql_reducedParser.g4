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
batch : genericStatement;

genericStatement : dmlStatement;

dmlStatement : selectStatement
			 | createTableStatement;

 //Id
 //   | QuotedId | ;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// SELECT Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
selectStatement : selectQuery;
selectQuery : SELECT columnItemList fromClause; 
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
columnDescription : columnName datatype (NOT)? NULL identityStatement?;
 //table_constraint
 //: ( K_CONSTRAINT name )?
 //  ( ( K_PRIMARY K_KEY | K_UNIQUE ) '(' indexed_column ( ',' indexed_column )* ')' conflict_clause
 //  | K_CHECK '(' expr ')'
 //  | K_FOREIGN K_KEY '(' column_name ( ',' column_name )* ')' foreign_key_clause
 //  )
 //;
identityStatement : IDENTITY LPAREN DIGIT+ COMMA DIGIT+ RPAREN;
varcharStatement :  (VARCHAR | NVARCHAR | NCHAR | CHAR) LPAREN DIGIT* RPAREN;
decimalStatement :  DECIMAL LPAREN DIGIT+ COMMA DIGIT+ RPAREN;
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
	: POUND tableName;
databaseName 
	: anyname 
	;
anyname
	: IDENTIFIER 
	| keyword
	| STRING_LITERAL
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
	 : SELECT
	 | FROM
	 | ACTION
	 | SELECT
	 | FROM 
	 | WHERE 
	 | FOR
	 | TABLE
	 | NOT 
	 | NULL
	 | IDENTITY
	 | AS
	 | datatype
	 ;

 //island grammar for interior spaces ~mnop