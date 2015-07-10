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

dmlStatement : selectStatement;

 //Id
 //   | QuotedId | ;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// SELECT Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
selectStatement : selectQuery ;//'select' columnName (',' columnName)* 'from' tableName;
//selectQuery : SELECT columnItemList fromClause;
selectQuery : (SELECT) columnName (COMMA columnName)* FROM tableName ;  

//columnItemList : columnNameList;
//	| columnWildQualifiedList
//	| columnNameQualifiedList;

//columnNameList : columnName (',' columnName)*;
//columnNameList : columnName ',' columnNameList
//    | columnName;

//columnItem : columnWildQualified
//    | variableName;

//columnNameQualified : columnName
//    | tableName '.' columnName
//    | variableName '.' columnName;

//columnNameQualifiedList : columnNameQualified ',' columnNameQualifiedList
//    | columnNameQualified;

//columnWild : '*';

//columnWildQualified : columnWild
//    | objectName '.' columnWild;
// //   | variableName '.' columnWild;
// columnWildQualifiedList : columnWildQualified ',' columnWildQualifiedList
//    | columnWildQualified;

//fromClause : FROM source;
////WhereClause : WHERE Predicate
////    |
////    ;
//source : sourceRowset;
//sourceRowset : variableName;

columnName 
	: anyname 
	;
tableName 
	: anyname 
	;
//variableName : objectName;
//objectName : IDENTIFIER ;

anyname
 : IDENTIFIER 
 | keyword
 | STRING_LITERAL
 ;
 keyword 
 : SELECT
 | FROM
 ;

 //island grammar for interior spaces ~mnop