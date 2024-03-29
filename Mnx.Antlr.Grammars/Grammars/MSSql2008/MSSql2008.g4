grammar MSSql2008;
options{ language=CSharp5;} 

start : Script;
Script : Batch;
  //  | Batch GoBatchList
	//;
Single_Line_Comment : '--' ~[\r\n]* -> channel(HIDDEN);
Multiline_Comment : '/*' .*? ( '*/' | EOF ) -> channel(HIDDEN);
All_Valid:[\x01-\xFF];
Alphanumeric:[\x30-\x39\x41-\x5A\x61-\x7A];
Control_Codes:[\0-\x1F\x7F-\x9F];
Digit:[\x30-\x39];
Letter:[\x41-\x5A\x61-\x7A];
Whitespace:[\x09-\x0D\x20\xA0];
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Terminals
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

Any_Ch : All_Valid  Control_Codes;	//{Any Ch} : {All Valid} - {Control Codes}
String_Ch : Any_Ch + Whitespace;//{String Ch} : {Any Ch} + {Whitespace} - ['']
Id_Ch_Standard : Alphanumeric+[_];//{Id Ch Standard} :{Alphanumeric} + [_]
Id_Ch_Delimited_Bracket : Any_Ch [ '[','\]' ];//{Id Ch Delimited Bracket} : {Any Ch} - ['['']']
Id_Ch_Delimited_Bracket_Start : Id_Ch_Delimited_Bracket  [#];	//{Id Ch Delimited Bracket Start} : {Id Ch Delimited Bracket} - [#]
Id_Ch_Delimited_Quote : Any_Ch ["#];	//{Id Ch Delimited Quote} : {Any Ch} - ["#]
Id_Ch_Delimited_Quote_Start : Id_Ch_Delimited_Quote  [#"];//{Id Ch Delimited Quote Start} : {Id Ch Delimited Quote} - [#]
Hex_Ch : [0123456789ABCDEF];	//{Hex Ch} : [0123456789ABCDEF]
Nonspace_Ch : Any_Ch Whitespace;	//{Nonspace Ch} : {Any Ch} - {Whitespace};

//StringLiteral : N?(String_Ch*)+  //StringLiteral : N?(String_Ch*)+
IntegerLiteral : Digit+;   //IntegerLiteral : {Digit}+
RealLiteral : Digit+'.'+Digit+;	   //RealLiteral : {Digit}+'.'{Digit}+
HexLiteral : '0x'Hex_Ch+;   //HexLiteral : 0x{Hex Ch}+;

// We use a simplified name convention, which does not allow user/schema, database or server to be specified
////Id : {Letter}{Id Ch Standard}*
////QuotedId : '['{Id Ch Delimited Bracket Start}{Id Ch Delimited Bracket}*']'
////         | '"'{Id Ch Delimited Quote Start}{Id Ch Delimited Quote}*'"'
////LocalId : '@'{Letter}{Id Ch Standard}*
////SystemVarId : '@@'{Letter}{Id Ch Standard}*
////SystemFuncId : '::'{Letter}{Id Ch Standard}*
////TempTableId : '#'{Letter}{Id Ch Standard}* | '[#'{Id Ch Delimited Bracket}+']' | '"#'{Id Ch Delimited Quote}+'"';

Id : Letter Id_Ch_Standard*;
QuotedId : '[' Id_Ch_Delimited_Bracket_Start  Id_Ch_Delimited_Bracket *']'
         | '"' Id_Ch_Delimited_Quote_Start  Id_Ch_Delimited_Quote *'"';
LocalId : '@' Letter  Id_Ch_Standard *;
SingleQuotedId : QuotedId;
SystemVarId : '@@' Letter  Id_Ch_Standard *;
SystemFuncId : '::' Letter  Id_Ch_Standard *;
TempTableId : '#' Letter  Id_Ch_Standard * | '[#' Id_Ch_Delimited_Bracket +']' | '"#' Id_Ch_Delimited_Quote +'"';

// The reserved keywords as per MSDN: http://msdn.microsoft.com/en-us/library/ms189822.aspx
// By specifying them explicitly here, we should not see those in the log as implicit when generating the grammar tables, and the unsed ones are still reserved keywords

ADD : ADD;
ALL : ALL;
ALTER : ALTER;
AND : AND;
ANY : ANY;
AS : AS;
ASC : ASC;
AUTHORIZATION : AUTHORIZATION;
BACKUP : BACKUP;
BEGIN : BEGIN;
BETWEEN : BETWEEN;
BREAK : BREAK;
BROWSE : BROWSE;
BULK : BULK;
BY : BY;
CASCADE : CASCADE;
CASE : CASE;
CHECK : CHECK;
CHECKPOINT : CHECKPOINT;
CLOSE : CLOSE;
CLUSTERED : CLUSTERED;
COALESCE : COALESCE;
COLLATE : COLLATE;
COLUMN : COLUMN;
COMMIT : COMMIT;
COMPUTE : COMPUTE;
CONSTRAINT : CONSTRAINT;
CONTAINS : CONTAINS;
CONTAINSTABLE : CONTAINSTABLE;
CONTINUE : CONTINUE;
CONVERT : CONVERT;
CREATE : CREATE;
CROSS : CROSS;
CURRENT : CURRENT;
CURRENT_DATE : CURRENT_DATE;
CURRENT_TIME : CURRENT_TIME;
CURRENT_TIMESTAMP : CURRENT_TIMESTAMP;
CURRENT_USER : CURRENT_USER;
CURSOR : CURSOR;
DATABASE : DATABASE;
DBCC : DBCC;
DEALLOCATE : DEALLOCATE;
DECLARE : DECLARE;
DEFAULT : DEFAULT;
DELETE : DELETE;
DENY : DENY;
DESC : DESC;
DISK : DISK;
DISTINCT : DISTINCT;
DISTRIBUTED : DISTRIBUTED;
DOUBLE : DOUBLE;
DROP : DROP;
DUMMY : DUMMY;
DUMP : DUMP;
ELSE : ELSE;
END : END;
ERRLVL : ERRLVL;
ESCAPE : ESCAPE;
EXCEPT : EXCEPT;
EXEC : EXEC;
EXECUTE : EXECUTE;
EXISTS : EXISTS;
EXIT : EXIT;
FETCH : FETCH;
FILE : FILE;
FILLFACTOR : FILLFACTOR;
FOR : FOR;
FOREIGN : FOREIGN;
FREETEXT : FREETEXT;
FREETEXTTABLE : FREETEXTTABLE;
FROM : FROM;
FULL : FULL;
FUNCTION : FUNCTION;
GOTO : GOTO;
GRANT : GRANT;
GROUP : GROUP;
HAVING : HAVING;
HOLDLOCK : HOLDLOCK;
IDENTITY : IDENTITY;
IDENTITY_INSERT : IDENTITY_INSERT;
IDENTITYCOL : IDENTITYCOL;
IF : IF;
IN : IN;
INDEX : INDEX;
INNER : INNER;
INSERT : INSERT;
INTERSECT : INTERSECT;
INTO : INTO;
IS : IS;
JOIN : JOIN;
KEY : KEY;
KILL : KILL;
LEFT : LEFT;
LIKE : LIKE;
LINENO : LINENO;
LOAD : LOAD;
NATIONAL : NATIONAL;
NOCHECK : NOCHECK;
NONCLUSTERED : NONCLUSTERED;
NOT : NOT;
NULL : NULL;
NULLIF : NULLIF;
OF : OF;
OFF : OFF;
OFFSETS : OFFSETS;
ON : ON;
OPEN : OPEN;
OPENDATASOURCE : OPENDATASOURCE;
OPENQUERY : OPENQUERY;
OPENROWSET : OPENROWSET;
OPENXML : OPENXML;
OPTION : OPTION;
OR : OR;
ORDER : ORDER;
OUTER : OUTER;
OVER : OVER;
PERCENT : PERCENT;
PLAN : PLAN;
PRECISION : PRECISION;
PRIMARY : PRIMARY;
PRINT : PRINT;
PROC : PROC;
PROCEDURE : PROCEDURE;
PUBLIC : PUBLIC;
RAISERROR : RAISERROR;
READ : READ;
READTEXT : READTEXT;
RECONFIGURE : RECONFIGURE;
REFERENCES : REFERENCES;
REPLICATION : REPLICATION;
RESTORE : RESTORE;
RESTRICT : RESTRICT;
RETURN : RETURN;
REVOKE : REVOKE;
RIGHT : RIGHT;
ROLLBACK : ROLLBACK;
ROWCOUNT : ROWCOUNT;
ROWGUIDCOL : ROWGUIDCOL;
RULE : RULE;
SAVE : SAVE;
SCHEMA : SCHEMA;
SELECT : SELECT;
SESSION_USER : SESSION_USER;
SET : SET;
SETUSER : SETUSER;
SHUTDOWN : SHUTDOWN;
SOME : SOME;
STATISTICS : STATISTICS;
SYSTEM_USER : SYSTEM_USER;
TABLE : TABLE;
TEXTSIZE : TEXTSIZE;
THEN : THEN;
TO : TO;
TOP : TOP;
TRAN : TRAN;
TRANSACTION : TRANSACTION;
TRIGGER : TRIGGER;
TRUNCATE : TRUNCATE;
TSEQUAL : TSEQUAL;
UNION : UNION;
UNIQUE : UNIQUE;
UPDATE : UPDATE;
UPDATETEXT : UPDATETEXT;
USE : USE;
USER : USER;
VALUES : VALUES;
VARYING : VARYING;
VIEW : VIEW;
WAITFOR : WAITFOR;
WHEN : WHEN;
WHERE : WHERE;
WHILE : WHILE;
WITH : WITH;
WRITETEXT : WRITETEXT;
ABSOLUTE : ABSOLUTE;
ACTION : ACTION;
AFTER : AFTER;
APPLY : APPLY;
AUTO : AUTO;
CALLED : CALLED;
CALLER : CALLER;
CAST : CAST;
CATCH : CATCH;
CHANGE_TRACKING : CHANGE_TRACKING;
COLLECTION : COLLECTION;
COMMITTED : COMMITTED;
COUNT : COUNT;
DISABLE : DISABLE;
ENABLE : ENABLE;
EXPLICIT : EXPLICIT;
EXTERNAL : EXTERNAL;
FIRST : FIRST;
FULLTEXT : FULLTEXT;
GLOBAL : GLOBAL;
HASH : HASH;
INCLUDE : INCLUDE;
INPUT : INPUT;
INSTEAD : INSTEAD;
LANGUAGE : LANGUAGE;
LAST : LAST;
LOG : LOG;
LOOP : LOOP;
MANUAL : MANUAL;
MARK : MARK;
MATCHED : MATCHED;
MAXRECURSION : MAXRECURSION;
MERGE : MERGE;
//NAME : NAME;
NEXT : NEXT;
NO : NO;
NOLOCK : NOLOCK;
NOWAIT : NOWAIT;
ONLY : ONLY;
OUTPUT : OUTPUT;
PARTITION : PARTITION;
PATH : PATH;
PERSISTED : PERSISTED;
POPULATION : POPULATION;
PRIOR : PRIOR;
PROPERTY : PROPERTY;
RAW : RAW;
READONLY : READONLY;
RECOMPILE : RECOMPILE;
RELATIVE : RELATIVE;
REPEATABLE : REPEATABLE;
RETURNS : RETURNS;
SCHEMABINDING : SCHEMABINDING;
SERVER : SERVER;
SETERROR : SETERROR;
SOURCE : SOURCE;
TARGET : TARGET;
TIES : TIES;
TRY : TRY;
TYPE : TYPE;
UNCOMMITTED : UNCOMMITTED;
USING : USING;
VALUE : VALUE;
VIEW_METADATA : VIEW_METADATA;
WORK : WORK;
XML : XML;
XMLNAMESPACES : XMLNAMESPACES;
INSENSITIVE : INSENSITIVE;
SCROLL : SCROLL;
READCOMMITTED: READCOMMITTED;
READCOMMITTEDLOCK : READCOMMITTEDLOCK;
READPAST : READPAST;
READUNCOMMITTED : READUNCOMMITTED;
REPEATABLEREAD : REPEATABLEREAD;
ROWLOCK :ROWLOCK;
SERIALIZABLE :SERIALIZABLE;
TABLOCK : TABLOCK;
TABLOCKX : TABLOCKX;
UPDLOCK : UPDLOCK;
XLOCK : XLOCK;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Common Terminals (Names, Literals, ...)
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

ObjectName : Id
    | QuotedId;

ObjectNameQualified : ObjectName
    | SchemaName '.' ObjectName;

AliasName : ObjectName
    | SingleQuotedId;

AssemblyName : ObjectName;

ClassName : ObjectName;

CollationName : Id;

ColumnName : ObjectName
    | ACTION;

ColumnNameQualified : ColumnName
    | TableName '.' ColumnName;
//   | VariableName '.' ColumnName;

ColumnNameList : ColumnName ',' ColumnNameList
    | ColumnName;

ColumnNameQualifiedList : ColumnNameQualified ',' ColumnNameQualifiedList
    | ColumnNameQualified;

ColumnWild : '*';

ColumnWildQualified : ColumnWild
    | TableName '.' ColumnWild
    | VariableName '.' ColumnWild;

ColumnWildNameQualified : ColumnNameQualified
    | ColumnWildQualified;

ConstraintName : ObjectName;

CursorName : ObjectName;

FunctionName : ObjectName
    | SystemFuncId;

FunctionNameQualified : FunctionName
    | SchemaName '.' FunctionName;

IndexName : ObjectName;

LabelName : ObjectName;

Label : LabelName ':';

MethodName : ObjectName;

ParameterName : LocalId;

ProcedureName : ObjectName;

ProcedureNameQualified : ProcedureName
    | SchemaName '.' ProcedureName;

TableName : ObjectName
    | TempTableId;

TableNameQualified : TableName
    | SchemaName '.' TableName;

TransactionName : ObjectName;

TriggerName : ObjectName;

TriggerNameQualified : TriggerName
    | SchemaName '.' TriggerName;

SimpleTypeName : ObjectName;

SimpleTypeNameQualified : SimpleTypeName
    | SchemaName '.' SimpleTypeName;

TypeName : SimpleTypeName
    | Id '(' Id ')' // e.g. VARCHAR(MAX)
    | QuotedId '(' Id ')' // e.g. VARCHAR(MAX)
    | Id '(' IntegerLiteral ')' // e.g. VARCHAR(20)
    | QuotedId '(' IntegerLiteral ')' // e.g. VARCHAR(20)
    | Id '(' IntegerLiteral ',' IntegerLiteral ')' // e.g. DECIMAL(10,5)
    | QuotedId '(' IntegerLiteral ',' IntegerLiteral ')'; // e.g. DECIMAL(10,5);

TypeNameQualified : TypeName
    | SchemaName '.' TypeName;

SchemaName : ObjectName;

SystemVariableName : SystemVarId;

VariableName : LocalId;

ViewName : ObjectName;

ViewNameQualified : ViewName
    | SchemaName '.' ViewName;

XmlNamespaceName : ObjectName;

XmlSchemaCollectionName : ObjectName;

XmlSchemaCollectionNameQualified : XmlSchemaCollectionName
    | SchemaName '.' XmlSchemaCollectionName;

ExternalName : 'EXTERNAL NAME' AssemblyName '.' ClassName '.' MethodName;

OptionalAs : AS
    |
;

StringLiteral : StringLiteral;

//IntegerLiteral : IntegerLiteral //TODO
 //   | HexLiteral;

NumberLiteral : IntegerLiteral
    | RealLiteral;

Literal : NumberLiteral
    | StringLiteral
    | StringLiteral COLLATE CollationName
    | NULL;

Toggle : ON
    | OFF;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Any statements allowed as SQL statements in code
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

// In T-SQL, the terminator (;) is usually not required. However, this introduces some ambiguities, so that we require it.;



GoBatchList : GoBatch
    | GoBatch GoBatchList;

Batch : FirstStatement
//////    | FirstStatement statementList
    | StatementList;

GoBatch : GoBatch;

StatementList : Statement
    | Statement StatementList;

Statement : StatementBlock
    | GenericStatement;

StatementBlock : BEGIN GenericStatementList END;

GenericStatementList : GenericStatement
    | GenericStatement  GenericStatementList;

Terminator : ';';

FirstStatement : CreateOrAlterFunctionStatement
    | CreateOrAlterProcedureStatement
    | CreateTriggerStatement
    | CreateOrAlterViewStatement
    | GrantStatement;

GenericStatement : DDLStatement
    | DMLStatement
    | PrgStatement
    | Label;

DDLStatement : CreateFulltextStatement
    | DropFulltextStatement
    | DropFunctionStatement
    | CreateIndexStatement
    | DropIndexStatement
    | DropProcedureStatement
    | CreateTableStatement
    | AlterTableStatement // We don't need anything but this to handle data update scripts
    | DropTableStatement
    | EnableTriggerStatement
    | DisableTriggerStatement
    | DropTriggerStatement
    | CreateTypeStatement
    | DropTypeStatement
    | DropViewStatement
    | CreateXmlSchemaCollectionStatement
    | DropXmlSchemaCollectionStatement;

DMLStatement : SelectStatement
    | InsertStatement
    | UpdateStatement
    | DeleteStatement
    | MergeStatement;

PrgStatement : AnyStatement
    | BeginTransactionStatement
    | BreakStatement
    | CloseStatement
    | CommitTransactionStatement
    | ContinueStatement
    | DeallocateStatement
    | DeclareStatement
    | ExecuteStatement
    | FetchStatement
    | GotoStatement
    | IfStatement
    | OpenStatement
    | PrintStatement
    | ReturnStatement
    | RollbackTransactionStatement
    | SaveTransactionStatement
    | SetStatement
    | TryCatchStatement
    | WaitforStatement
    | WhileStatement
    | RaiserrorStatement;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// GRANT statements
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

GrantStatement : GRANT GrantPermissionList ON ObjectNameQualified ToPricipalWithOption;

GrantPermissionList : GrantPermission
    | GrantPermission ',' GrantPermissionList;

GrantPermission : EXECUTE
    | REFERENCES
    | DELETE
    | INSERT
    | SELECT
    | UPDATE
    | ALL
    | ALL StatementList;

DatabasePrincipalList : DatabasePrincipal
    |  DatabasePrincipal ',' DatabasePrincipalList;

DatabasePrincipal : PUBLIC;
////// | Database_user
////// | Database_role
////// | Application_role
////// | Database_user_mapped_to_Windows_User
////// | Database_user_mapped_to_Windows_Group
////// | Database_user_mapped_to_certificate
////// | Database_user_mapped_to_asymmetric_key
////// | Database_user_with_no_login;

AsDatabasePrincipal : AS DatabasePrincipal;
//    |

WithGrantOption : WITH GRANT OPTION;
  //  |

ToPricipalWithOption : TO DatabasePrincipalList WithGrantOption AsDatabasePrincipal;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Control-of-Flow and simple statements
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

BreakStatement : BREAK;

ContinueStatement : CONTINUE;

GotoStatement : GOTO LabelName;

// To avoid the hanging ELSE problem/ambiguity, we just require a block - even if this is more restrictive than T-SQL
IfStatement : IF Predicate Statement ELSE Statement
    | IF Predicate Statement;

ReturnStatement : RETURN
    | RETURN Expression;

TryCatchStatement : BEGIN TRY StatementList END TRY BEGIN CATCH StatementList END CATCH;

WhileStatement : WHILE Predicate Statement;

WaitforStatement : WAITFOR Id StringLiteral
    | WAITFOR Id VariableName;

PrintStatement : PRINT Expression;

AnyStatement : Id ExpressionList;

RaiserrorStatement : RAISERROR '(' ExpressionList ')'
    | RAISERROR '(' ExpressionList ')' WITH RaiserrorOptionList;

RaiserrorOption : LOG
    | NOWAIT
    | SETERROR;

RaiserrorOptionList : RaiserrorOption ',' RaiserrorOptionList
    | RaiserrorOption;

//Label : Id ':'; //TODO

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// DECLARE and Cursor statements
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

DeclareStatement : DECLARE VariableName AS TABLE TableDefinitionGroup
    | DECLARE VariableName TABLE TableDefinitionGroup
    | DECLARE DeclareItemList
    | DECLARE CursorName CursorDefinition;

CursorDefinition : CursorType CURSOR CursorOptionList FOR SelectStatement  CursorUpdate;
//    |  CURSOR CursorOptionList FOR SelectStatement CursorUpdate;

CursorType : INSENSITIVE
    | SCROLL
    |
;

DeclareItem : VariableName CURSOR
    | VariableName AS TypeNameQualified
    | VariableName TypeNameQualified
    | VariableName AS TypeNameQualified ':' Expression
    | VariableName TypeNameQualified ':' Expression;

DeclareItemList : DeclareItem ',' DeclareItemList
    | DeclareItem;

CursorOptionList : Id CursorOptionList
    |
;

CloseStatement : CLOSE GlobalOrLocalCursor;

OpenStatement : OPEN GlobalOrLocalCursor;

DeallocateStatement : DEALLOCATE GlobalOrLocalCursor;

GlobalOrLocalCursor : VariableName
    | CursorName
    | GLOBAL CursorName;

CursorUpdate : 'FOR UPDATE OF' ColumnNameList
    | 'FOR UPDATE'
    | 'FOR READ ONLY'
    |
;

FetchStatement : FETCH CursorPosition GlobalOrLocalCursor
    | FETCH CursorPosition GlobalOrLocalCursor INTO VariableNameList;

CursorPosition : NEXT FROM
    | PRIOR FROM
    | FIRST FROM
    | LAST FROM
    | ABSOLUTE IntegerLiteral FROM
    | ABSOLUTE VariableName FROM
    | RELATIVE IntegerLiteral FROM
    | RELATIVE VariableName FROM
    | FROM
    |
;

VariableNameList : VariableName ',' VariableNameList
    | VariableName;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Common helper constructs
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

OptionalDefault : ':' Literal
 |
 ;

DestinationRowset : VariableName
    | TableNameQualified TableHintGroup;
// | Openrowset -- not supported
// | Openquery -- not supported;

Openxml : OPENXML '(' VariableName ',' StringLiteral ',' IntegerLiteral ')' OptionalOpenxmlSchema
    | OPENXML '(' VariableName ',' VariableName ',' IntegerLiteral ')' OptionalOpenxmlSchema
    | OPENXML '(' VariableName ',' StringLiteral ')' OptionalOpenxmlSchema
    | OPENXML '(' VariableName ',' VariableName ')' OptionalOpenxmlSchema;

OptionalOpenxmlSchema : OpenxmlImplicitSchema
    | OpenxmlExplicitSchema
    |
;

OpenxmlImplicitSchema : WITH '(' TableNameQualified ')';

OpenxmlExplicitSchema : WITH '(' OpenxmlColumnList ')';

OpenxmlColumnList : OpenxmlColumn ',' OpenxmlColumnList
    | OpenxmlColumn;

OpenxmlColumn : ColumnName TypeName StringLiteral
    | ColumnName TypeName;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// SET (both variables and options, but not yet CLR UDT properties and fields)
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

SetStatement : SetVariableStatement
    | SetOptionStatement;

SetVariableStatement : SET VariableName ':' Expression
    | SET VariableName '.' NamedFunctionList
    | SET VariableName ':' CursorDefinition;

SetOptionStatement : SET Id SetValueList
    | SET TRANSACTION SetValueList
    | SET OFFSETS SetValueList
    | SET ROWCOUNT SetValue
    | SET STATISTICS SetValueList
    | SET IDENTITY_INSERT TableNameQualified Toggle;

SetValueList : SetValue SetValueList
    | SetValue;

SetValue : Id
    | READ UNCOMMITTED
    | READ COMMITTED
    | REPEATABLE READ
    | Toggle
    | IntegerLiteral
    | StringValue;

StringValue : StringLiteral
    | VariableName;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Transaction statements
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

BeginTransactionStatement : BEGIN TRANSACTION
    | BEGIN TRANSACTION TransactionIdentifier
    | BEGIN TRANSACTION TransactionIdentifier WITH MARK
    | BEGIN TRANSACTION TransactionIdentifier WITH MARK StringLiteral;

CommitTransactionStatement : COMMIT
    | COMMIT WORK
    | COMMIT TRANSACTION
    | COMMIT TRANSACTION TransactionIdentifier;

RollbackTransactionStatement : ROLLBACK
    | ROLLBACK WORK
    | ROLLBACK TRANSACTION
    | ROLLBACK TRANSACTION TransactionIdentifier;

SaveTransactionStatement : SAVE TRANSACTION TransactionIdentifier;

TransactionIdentifier : TransactionName
    | VariableName;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP FULLTEXT
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

// We don't allow to specify the catalog name, since the catalog is automatically assigned (module name);

CreateFulltextStatement : CREATE FULLTEXT INDEX ON TABLE TableNameQualified FulltextColumnGroup KEY INDEX IndexName FulltextChangeTracking;

FulltextColumnGroup : '(' FulltextColumnList ')'
    |
;

FulltextColumnList : FulltextColumn ',' FulltextColumnList
    | FulltextColumn;

FulltextColumn : ColumnName FulltextColumnType OptionalLanguage;

FulltextColumnType : TYPE COLUMN TypeNameQualified
    |
;

OptionalLanguage : LANGUAGE IntegerLiteral
    | LANGUAGE StringLiteral
    |
;

FulltextChangeTracking : WITH CHANGE_TRACKING AUTO
    | WITH CHANGE_TRACKING MANUAL
    | WITH CHANGE_TRACKING OFF
    | WITH CHANGE_TRACKING OFF ',' NO POPULATION
    |
;

DropFulltextStatement : DROP FULLTEXT INDEX ON TableNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP FUNCTION
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

// We don't allow to specify the schema name, it is implicit (module name);

CreateOrAlterFunctionStatement : CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption AS StatementBlock
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption StatementBlock
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE OptionalFunctionOption AS RETURN FunctionInlineSelect
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE OptionalFunctionOption RETURN FunctionInlineSelect
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS VariableName TABLE TableDefinitionGroup OptionalFunctionOption AS StatementBlock
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS VariableName TABLE TableDefinitionGroup OptionalFunctionOption StatementBlock
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption AS ExternalName
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption ExternalName
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE TableDefinitionGroup OptionalFunctionOption AS ExternalName
    | CREATE FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE TableDefinitionGroup OptionalFunctionOption ExternalName
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption AS StatementBlock
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption StatementBlock
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE OptionalFunctionOption AS RETURN FunctionInlineSelect
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE OptionalFunctionOption RETURN FunctionInlineSelect
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS VariableName TABLE TableDefinitionGroup OptionalFunctionOption AS StatementBlock
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS VariableName TABLE TableDefinitionGroup OptionalFunctionOption StatementBlock
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption AS ExternalName
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TypeNameQualified OptionalFunctionOption ExternalName
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE TableDefinitionGroup OptionalFunctionOption AS ExternalName
    | ALTER FUNCTION FunctionNameQualified '(' OptionalFunctionParameterList ')' RETURNS TABLE TableDefinitionGroup OptionalFunctionOption ExternalName;

OptionalFunctionParameterList : FunctionParameterList
    |
;

FunctionParameterList : FunctionParameter ',' FunctionParameterList
    | FunctionParameter;

FunctionParameter : ParameterName AS TypeNameQualified OptionalDefault OptionalReadonly
    | ParameterName TypeNameQualified OptionalDefault OptionalReadonly;

FunctionInlineSelect : SelectStatement
    | '(' FunctionInlineSelect ')';

// The option ENCRYPTION is handled by the module and therefore not allowed
OptionalFunctionOption : WITH RETURNS NULL ON NULL INPUT
    | WITH CALLED ON NULL INPUT
    | WITH EXECUTE AS CALLER
    | WITH SCHEMABINDING
    |
;

DropFunctionStatement : DROP FUNCTION FunctionNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP PROCEDURE and EXECUTE
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

CreateOrAlterProcedureStatement : CREATE PROCEDURE ProcedureNameQualified ProcedureParameterGroup ProcedureOptionGroup ProcedureFor AsObjectBody
    | ALTER PROCEDURE ProcedureNameQualified ProcedureParameterGroup ProcedureOptionGroup ProcedureFor AsObjectBody;

AsObjectBody : AS StatementList;

ProcedureParameterGroup : '(' ProcedureParameterList ')'
    | ProcedureParameterList
    | '(' ')'
    |
;

ProcedureParameterList : ProcedureParameter ',' ProcedureParameterList
    | ProcedureParameter;

ProcedureParameter : ParameterName TypeNameQualified OptionalVarying OptionalDefault OptionalOutput OptionalReadonly;

OptionalVarying : VARYING
    |
;

OptionalOutput : OUTPUT
    |
;

OptionalReadonly : READONLY
    |
;

ProcedureOptionGroup : WITH RECOMPILE
    |
;

ProcedureFor : FOR REPLICATION
    |
;

DropProcedureStatement : DROP PROCEDURE ProcedureNameQualified;

ExecuteStatement : EXECUTE VariableName ':' ProcedureNameQualified ExecuteParameterGroup ProcedureOptionGroup
    | EXECUTE ProcedureNameQualified ExecuteParameterGroup ProcedureOptionGroup;

ExecuteParameterGroup : ExecuteParameterList
    |
;

ExecuteParameterList : ExecuteParameter ',' ExecuteParameterList
    | ExecuteParameter;

ExecuteParameter : TableNameQualified // for the system "sp_*" SPs
    | ParameterName ':' VariableName OptionalOutput
    | ParameterName ':' SystemVariableName OptionalOutput
    | ParameterName ':' Literal OptionalOutput
    | VariableName OptionalOutput
    | SystemVariableName OptionalOutput
    | Literal OptionalOutput;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/ALTER/DROP TABLE
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

// We don't support the ON option, filegroup is managed by module manager;

CreateTableStatement : CREATE TABLE TableNameQualified TableDefinitionGroup;

AlterTableStatement : ALTER TABLE TableNameQualified ALTER COLUMN ColumnName ColumnDefinition
    | ALTER TABLE TableNameQualified ALTER COLUMN ColumnName ADD ROWGUIDCOL
    | ALTER TABLE TableNameQualified ALTER COLUMN ColumnName DROP ROWGUIDCOL
    | ALTER TABLE TableNameQualified ALTER COLUMN ColumnName ADD PERSISTED
    | ALTER TABLE TableNameQualified ALTER COLUMN ColumnName DROP PERSISTED
    | ALTER TABLE TableNameQualified ALTER COLUMN ColumnName ADD NOT FOR REPLICATION
    | ALTER TABLE TableNameQualified ALTER COLUMN ColumnName DROP NOT FOR REPLICATION
    | ALTER TABLE TableNameQualified TableCheck ADD TableDefinitionList
    | ALTER TABLE TableNameQualified TableCheck ADD ColumnConstraint FOR ColumnName
    | ALTER TABLE TableNameQualified TableCheck NOCHECK CONSTRAINT ConstraintName
    | ALTER TABLE TableNameQualified TableCheck NOCHECK CONSTRAINT ALL
    | ALTER TABLE TableNameQualified TableCheck CHECK CONSTRAINT ConstraintName
    | ALTER TABLE TableNameQualified TableCheck CHECK CONSTRAINT ALL
    | ALTER TABLE TableNameQualified DROP ConstraintName
    | ALTER TABLE TableNameQualified DROP CONSTRAINT ConstraintName
    | ALTER TABLE TableNameQualified DROP COLUMN ColumnName;

TableCheck : WITH CHECK
    | WITH NOCHECK
    |
;

DropTableStatement : DROP TABLE TableNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP VIEW
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

CreateOrAlterViewStatement : CREATE VIEW ViewNameQualified ColumnNameGroup ViewOptionalAttribute AS SelectStatement ViewOptionalCheckOption
    | ALTER VIEW ViewNameQualified ColumnNameGroup ViewOptionalAttribute AS SelectStatement ViewOptionalCheckOption;

ColumnNameGroup : '(' ColumnNameList ')'
    |
;

ViewOptionalAttribute : WITH VIEW_METADATA
    | WITH SCHEMABINDING
    |
;

ViewOptionalCheckOption : WITH_CHECK_OPTION
    |
;

DropViewStatement : DROP VIEW ViewNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP INDEX
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

// We don't support the ON option, filegroup is managed by module manager;

CreateIndexStatement : CREATE IndexOptionalUnique ConstraintCluster INDEX IndexName ON TableNameQualified '(' IndexColumnList ')' INCLUDE '(' ColumnNameList ')' IndexOptionGroup
    | CREATE IndexOptionalUnique ConstraintCluster INDEX IndexName ON TableNameQualified '(' IndexColumnList ')' IndexOptionGroup
    | CREATE PRIMARY XML INDEX IndexName ON TableNameQualified '(' ColumnName ')' IndexUsing IndexOptionGroup
    | CREATE XML INDEX IndexName ON TableNameQualified '(' ColumnName ')' IndexUsing IndexOptionGroup;

IndexColumnList : IndexColumn ',' IndexColumnList
    | IndexColumn;

IndexOptionalUnique : UNIQUE
    |
;

IndexColumn : ColumnName OrderType;

IndexOptionGroup : WITH '(' IndexOptionList ')'
    |
;

IndexOptionList : IndexOption ',' IndexOptionList
    | IndexOption;

IndexOption : Id ':' IntegerLiteral
    | Id ':' Toggle;

IndexUsing : USING XML INDEX IndexName FOR VALUE
    | USING XML INDEX IndexName FOR PATH
    | USING XML INDEX IndexName FOR PROPERTY
    |
;

DropIndexStatement : DROP INDEX IndexName ON TableNameQualified IndexOptionGroup;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP TRIGGER
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

// Only DML triggers are supported;

CreateTriggerStatement : CREATE TRIGGER TriggerNameQualified ON TableNameQualified TriggerType TriggerOperationList OptionalNotForReplication AS Statement;

TriggerType : FOR
    | INSTEAD OF
    | AFTER;

TriggerOperationList : TriggerOperation ',' TriggerOperationList
    | TriggerOperation;

TriggerOperation : INSERT
    | UPDATE
    | DELETE;

OptionalNotForReplication : NOT FOR REPLICATION
    |
;

TriggerTarget : TableNameQualified
    | DATABASE
    | ALL SERVER;

EnableTriggerStatement : ENABLE TRIGGER ALL ON TriggerTarget
    | ENABLE TRIGGER TriggerNameQualifiedList ON TriggerTarget;

DisableTriggerStatement : DISABLE TRIGGER ALL ON TriggerTarget
    | DISABLE TRIGGER TriggerNameQualifiedList ON TriggerTarget;

TriggerNameQualifiedList : TriggerNameQualified ',' TriggerNameQualifiedList
    | TriggerNameQualified;

DropTriggerStatement : DROP TRIGGER TriggerNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP XML SCHEMA COLLECTION
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

CreateXmlSchemaCollectionStatement : CREATE XML SCHEMA COLLECTION XmlSchemaCollectionNameQualified AS Expression;

DropXmlSchemaCollectionStatement : DROP XML SCHEMA COLLECTION XmlSchemaCollectionNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// CREATE/DROP TYPE
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

CreateTypeStatement : CREATE TYPE SimpleTypeNameQualified FROM TypeName TypeConstraint
    | CREATE TYPE SimpleTypeNameQualified AS TABLE TableDefinitionGroup;

TypeConstraint : NOT NULL
    | NULL
    |
;

DropTypeStatement : DROP TYPE SimpleTypeNameQualified;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Table/Column Type Definitions
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

TableDefinitionGroup : '(' TableDefinitionList ')';

TableDefinitionList : TableDefinition ',' TableDefinitionList
    | TableDefinition;

TableDefinition : ColumnName ColumnDefinition
    | TableConstraint;

TableConstraint : CONSTRAINT ConstraintName PRIMARY KEY ConstraintCluster '(' IndexColumnList ')' ConstraintIndex
    | CONSTRAINT ConstraintName UNIQUE ConstraintCluster '(' IndexColumnList ')' ConstraintIndex
    | CONSTRAINT ConstraintName FOREIGN KEY '(' ColumnNameList ')' REFERENCES TableNameQualified ColumnNameGroup ForeignKeyActionList
    | CONSTRAINT ConstraintName CHECK OptionalNotForReplication '(' Predicate ')'
    | PRIMARY KEY ConstraintCluster '(' IndexColumnList ')' ConstraintIndex
    | UNIQUE ConstraintCluster '(' IndexColumnList ')' ConstraintIndex
    | FOREIGN KEY '(' ColumnNameList ')' REFERENCES TableNameQualified ColumnNameGroup ForeignKeyActionList
    | CHECK OptionalNotForReplication '(' Predicate ')';

ForeignKeyActionList : ForeignKeyAction ForeignKeyActionList
    |
;

ForeignKeyAction : ON DELETE NO ACTION
    | ON DELETE CASCADE
    | ON DELETE SET NULL
    | ON DELETE SET DEFAULT
    | ON UPDATE NO ACTION
    | ON UPDATE CASCADE
    | ON UPDATE SET NULL
    | ON UPDATE SET DEFAULT;

OptionalForeignRefColumn : '(' ColumnName ')'
    |
;

ColumnDefinition : TypeNameQualified ColumnConstraintList
    | AS Expression ComputedColumnConstraintList;

ColumnConstraintList : ColumnConstraint ColumnConstraintList
    |
;

ColumnConstraint : NamedColumnConstraint
    | COLLATE CollationName
    | IDENTITY
    | IDENTITY '(' IntegerLiteral ',' IntegerLiteral ')'
    | ROWGUIDCOL
    | NOT NULL
    | NULL;

ComputedColumnConstraintList : ComputedColumnConstraint ComputedColumnConstraintList
    |
;

ComputedColumnConstraint : NamedColumnConstraint
    | PERSISTED
    | NOT NULL;

NamedColumnConstraint : CONSTRAINT ConstraintName PRIMARY KEY ConstraintCluster ConstraintIndex
    | CONSTRAINT ConstraintName UNIQUE ConstraintCluster ConstraintIndex
    | CONSTRAINT ConstraintName FOREIGN KEY REFERENCES TableNameQualified OptionalForeignRefColumn ForeignKeyActionList
    | CONSTRAINT ConstraintName REFERENCES TableNameQualified OptionalForeignRefColumn ForeignKeyActionList
    | CONSTRAINT ConstraintName CHECK OptionalNotForReplication '(' Predicate ')'
    | CONSTRAINT ConstraintName DEFAULT ConstraintDefaultValue
    | PRIMARY KEY ConstraintCluster ConstraintIndex
    | UNIQUE ConstraintCluster ConstraintIndex
    | FOREIGN KEY REFERENCES TableNameQualified OptionalForeignRefColumn ForeignKeyActionList
    | REFERENCES TableNameQualified OptionalForeignRefColumn ForeignKeyActionList
    | CHECK OptionalNotForReplication '(' Predicate ')'
    | DEFAULT ConstraintDefaultValue;

ConstraintCluster : CLUSTERED
    | NONCLUSTERED
    |
;

ConstraintDefaultValue : ExpressionParens
    | FunctionCall
    | NumberLiteral
    | StringLiteral
    | NULL;

ConstraintIndex : WITH FILLFACTOR ':' IntegerLiteral
    | IndexOptionGroup;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Common Table Expressions, TOP and OUTPUT clauses
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

QueryOptions : WITH XMLNAMESPACES '(' XmlNamespaceList ')'
    | WITH XMLNAMESPACES '(' XmlNamespaceList ')' ',' CTEList
    | WITH CTEList
    |
;

XmlNamespaceList : XmlNamespace ',' XmlNamespaceList
    | XmlNamespace;

XmlNamespace : StringLiteral AS XmlNamespaceName;

CTEList : CTE ',' CTEList
    | CTE;

CTE : AliasName ColumnNameGroup AS '(' SelectQuery ')';

Top : TOP '(' Expression ')' OptionalPercent OptionalWithTies;

OptionalTop : Top
    |
;

OptionalPercent : PERCENT
    |
;

OptionalWithTies : WITH TIES
    |
;

OutputClause : OUTPUT ColumnItemList
    | OUTPUT ColumnItemList INTO DestinationRowset ColumnNameGroup
    |
;

QueryHint : OPTION '(' QueryHintOptionList ')'
    |
;

QueryHintOption : MAXRECURSION IntegerLiteral
    | RECOMPILE;

QueryHintOptionList : QueryHintOption ',' QueryHintOptionList
    | QueryHintOption;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// INSERT Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

InsertStatement : QueryOptions INSERT OptionalTop OptionalInto DestinationRowset ColumnNameGroup OutputClause VALUES '(' ExpressionList ')' QueryHint
    | QueryOptions INSERT OptionalTop OptionalInto DestinationRowset ColumnNameGroup OutputClause SelectQuery QueryHint
    | QueryOptions INSERT OptionalTop OptionalInto DestinationRowset ColumnNameGroup OutputClause ExecuteStatement QueryHint
    | QueryOptions INSERT OptionalTop OptionalInto DestinationRowset DEFAULT VALUES QueryHint;

OptionalInto : INTO
    |
;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// MERGE Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

MergeStatement : QueryOptions MERGE OptionalTop OptionalInto DestinationRowset RowsetAlias USING SourceRowset ON Predicate MergeWhenMatchedList OutputClause QueryHint;

MergeWhenMatchedList : MergeWhenMatched MergeWhenMatchedList
    | MergeWhenMatched;

MergeWhenMatched : WHEN MATCHED AND Predicate THEN MergeMatched
    | WHEN MATCHED THEN MergeMatched
    | WHEN NOT MATCHED BY TARGET AND Predicate THEN MergeNotMatched
    | WHEN NOT MATCHED BY TARGET THEN MergeNotMatched
    | WHEN NOT MATCHED AND Predicate THEN MergeNotMatched
    | WHEN NOT MATCHED THEN MergeNotMatched
    | WHEN NOT MATCHED BY SOURCE AND Predicate THEN MergeMatched
    | WHEN NOT MATCHED BY SOURCE THEN MergeMatched;

MergeMatched : UPDATE SET UpdateItemList
    | DELETE;

MergeNotMatched : INSERT ColumnNameGroup VALUES '(' ExpressionList ')'
    | INSERT ColumnNameGroup DEFAULT VALUES;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// UPDATE Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

UpdateStatement : QueryOptions UPDATE OptionalTop DestinationRowset SET UpdateItemList OutputClause OptionalFromClause WhereClause QueryHint;

UpdateItemList : UpdateItem ',' UpdateItemList
    | UpdateItem;

UpdateItem : ColumnNameQualified ':' Expression
// | ColumnNameQualified ':' ColumnNameQualified .WRITE -- syntax not yet implemented
    | ColumnNameQualified ':' DEFAULT
    | VariableName ':' Expression
    | VariableName ':' ColumnNameQualified ':' Expression
    | VariableName '.' NamedFunctionList
    | TableName '.' NamedFunctionList // TableName is in fact a ColumnName
    | TableName '.' ColumnName '.' NamedFunctionList;

OptionalFromClause : FromClause
    |
;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// DELETE Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

DeleteStatement : QueryOptions DELETE OptionalTop OptionalFrom DestinationRowset OutputClause OptionalFromClause WhereClause QueryHint;

OptionalFrom : FROM
    |
;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// SELECT Statement
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

SelectStatement : QueryOptions SelectQuery QueryHint;

SelectQuery : SELECT Restriction TopLegacy ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause RowsetCombineClause ComputeClause
    | SELECT Restriction TopLegacy ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause ForClause ComputeClause
    | SELECT Restriction ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause RowsetCombineClause ComputeClause
    | SELECT Restriction ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause ForClause ComputeClause
    | SELECT TopLegacy ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause RowsetCombineClause ComputeClause
    | SELECT TopLegacy ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause ForClause ComputeClause
    | SELECT ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause RowsetCombineClause ComputeClause
    | SELECT ColumnItemList IntoClause FromClause WhereClause GroupClause HavingClause OptionalOrderClause ForClause ComputeClause
    | SELECT Restriction TopLegacy ColumnItemList IntoClause WhereClause RowsetCombineClause ComputeClause
    | SELECT Restriction TopLegacy ColumnItemList IntoClause WhereClause ForClause ComputeClause
    | SELECT Restriction ColumnItemList IntoClause WhereClause RowsetCombineClause ComputeClause
    | SELECT Restriction ColumnItemList IntoClause WhereClause ForClause ComputeClause
    | SELECT TopLegacy ColumnItemList IntoClause WhereClause RowsetCombineClause ComputeClause
    | SELECT TopLegacy ColumnItemList IntoClause WhereClause ForClause ComputeClause
    | SELECT ColumnItemList IntoClause WhereClause RowsetCombineClause ComputeClause
    | SELECT ColumnItemList IntoClause WhereClause ForClause ComputeClause;

TopLegacy : TOP IntegerLiteral OptionalPercent
    | Top;

ColumnItemList : ColumnItem ',' ColumnItemList
    | ColumnItem;

ColumnItem : ColumnWildQualified
    | Expression
    | Expression AS AliasName
    | Expression AliasName
    | AliasName ':' Expression
    | VariableName ':' Expression;

Restriction : ALL
    | DISTINCT;

IntoClause : INTO DestinationRowset
    |
;

FromClause : FROM Source JoinChain;

Source : SourceRowset
    | '(' Source JoinChain ')';

JoinChain : Join JoinChain
    |
;

Join : JOIN Source ON Predicate
    | INNER JoinHint JOIN Source ON Predicate
    | LEFT JoinHint JOIN Source ON Predicate
    | LEFT OUTER JoinHint JOIN Source ON Predicate
    | RIGHT JoinHint JOIN Source ON Predicate
    | RIGHT OUTER JoinHint JOIN Source ON Predicate
    | FULL JoinHint JOIN Source ON Predicate
    | FULL OUTER JoinHint JOIN Source ON Predicate
    | CROSS JOIN Source
    | CROSS APPLY Source
    | OUTER APPLY Source;

JoinHint : MERGE
    | HASH
    | LOOP
    |
;

SourceRowset : VariableName RowsetAlias
    | VariableName '.' NamedFunction RowsetAlias // XML nodes() function: http://msdn.microsoft.com/en-us/library/ms188282(v:SQL.90).aspx
    | VariableName '.' ColumnName '.' NamedFunction RowsetAlias // XML nodes() function on a table variable
    | TableNameQualified RowsetAlias TableHintGroup
    | Openxml RowsetAlias
    | TextTableFunction RowsetAlias
    | NamedFunction RowsetAlias
    | SchemaName '.' NamedFunction RowsetAlias
    | SchemaName '.' TableName '.' NamedFunction RowsetAlias // also XML nodes() function; but with shifted names (SchemaName should be TableName, TableName should be ColumnName)
// | SchemaName '.' TableName '.' ColumnName '.' FunctionCall RowsetAlias // also XML nodes() function
    | SchemaName '.' TableName '.' TableName RowsetAlias //Table in a different DB
    | SchemaName '.' TableName '.' SchemaName '.' TableName RowsetAlias //Table in a different DB on a different server
    | '(' VALUES ValuesList ')' RowsetAlias
    | '(' SelectQuery ')' RowsetAlias;

RowsetAlias : AS AliasName '(' ColumnNameList ')'
    | AliasName '(' ColumnNameList ')'
    | AS AliasName
    | AliasName
    |
;

ValuesList : '(' ExpressionList ')' ',' ValuesList
    | '(' ExpressionList ')';

TextTableFunction : CONTAINSTABLE '(' TableNameQualified ',' ColumnName ',' Expression ',' LANGUAGE Literal OptionalContainsTop ')'
    | CONTAINSTABLE '(' TableNameQualified ',' ColumnName ',' Expression OptionalContainsTop ')'
    | CONTAINSTABLE '(' TableNameQualified ',' ColumnWild ',' Expression ',' LANGUAGE Literal OptionalContainsTop ')'
    | CONTAINSTABLE '(' TableNameQualified ',' ColumnWild ',' Expression OptionalContainsTop ')'
    | CONTAINSTABLE '(' TableNameQualified ',' '(' ColumnNameList ')' ',' Expression ',' LANGUAGE Literal OptionalContainsTop ')'
    | CONTAINSTABLE '(' TableNameQualified ',' '(' ColumnNameList ')' ',' Expression OptionalContainsTop ')'
    | FREETEXTTABLE '(' TableNameQualified ',' ColumnName ',' Expression ',' LANGUAGE Literal OptionalContainsTop ')'
    | FREETEXTTABLE '(' TableNameQualified ',' ColumnName ',' Expression OptionalContainsTop ')'
    | FREETEXTTABLE '(' TableNameQualified ',' ColumnWild ',' Expression ',' LANGUAGE Literal OptionalContainsTop ')'
    | FREETEXTTABLE '(' TableNameQualified ',' ColumnWild ',' Expression OptionalContainsTop ')'
    | FREETEXTTABLE '(' TableNameQualified ',' '(' ColumnNameList ')' ',' Expression ',' LANGUAGE Literal OptionalContainsTop ')'
    | FREETEXTTABLE '(' TableNameQualified ',' '(' ColumnNameList ')' ',' Expression OptionalContainsTop ')';

OptionalContainsTop : ',' IntegerLiteral
    |
;

TableHintGroup : WITH '(' TableHintList ')'
    | '(NOLOCK)'
    | '(READUNCOMMITTED)'
    | '(UPDLOCK)'
    | '(REPEATABLEREAD)'
    | '(SERIALIZABLE)'
    | '(READCOMMITTED)'
    | '(TABLOCK)'
    | '(TABLOCKX)'
 //   | '(PAGLOCK)'
    | '(ROWLOCK)'
    | '(NOWAIT)'
    | '(READPAST)'
    | '(XLOCK)'
    | '(NOEXPAND)'
    |
;

TableHintList : TableHint ',' TableHintList
    | TableHint;

TableHint : INDEX '(' IndexValueList ')'
    | HOLDLOCK
    | Id
    | NOLOCK
    | NOWAIT
//    | PAGLOCK
    | READCOMMITTED
    | READCOMMITTEDLOCK
    | READPAST
    | READUNCOMMITTED
    | REPEATABLEREAD
    | ROWLOCK
    | SERIALIZABLE
    | TABLOCK
    | TABLOCKX
    | UPDLOCK
    | XLOCK;

IndexValueList : IntegerLiteral ',' IndexValueList
    | IntegerLiteral;

WhereClause : WHERE Predicate
    |
;

GroupClause : GROUP BY ExpressionList
    |
;

OrderClause : ORDER BY OrderList;

OptionalOrderClause : OrderClause
    |
;

OrderList : Order ',' OrderList
    | Order;

Order : Expression OrderType;

OrderType : ASC
    | DESC
    |
;

HavingClause : HAVING Predicate
    |
;

ComputeClause : COMPUTE ColumnItemList
    | COMPUTE ColumnItemList BY ColumnItemList
    |
;

RowsetCombineClause : UNION SelectQuery
    | UNION ALL SelectQuery
    | EXCEPT SelectQuery
    | INTERSECT SelectQuery;

ForClause : FOR BROWSE
    | FOR XML AUTO XmlDirectiveList
    | FOR XML RAW OptionalElementName XmlDirectiveList
    | FOR XML EXPLICIT XmlDirectiveList
    | FOR XML PATH OptionalElementName XmlDirectiveList
    | FOR READ ONLY
    |
;

OptionalElementName : '(' StringLiteral ')'
    |
;

XmlDirectiveList : ',' XmlDirective XmlDirectiveList
    |
;

XmlDirective : Id OptionalElementName
    | Id Id;

// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Pedicates and Expressions
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

Predicate : PredicateOr;

PredicateOr : PredicateAnd OR PredicateOr
    | PredicateAnd;

// support for SOME/ANY/ALL comparisons on sets is missing: http://msdn.microsoft.com/en-US/library/ms175064(v:SQL.90).aspx;

PredicateAnd : PredicateNot AND PredicateAnd
    | PredicateNot;

PredicateNot : NOT PredicateCompare
    | PredicateCompare;

PredicateCompare : Expression ':' Expression
    | Expression '' Expression
    | Expression '' Expression
    | Expression ':' Expression
    | Expression ':' Expression
    | Expression '' Expression
    | Expression '//:' Expression
    | Expression '//' Expression
    | Expression '//' Expression
    | Expression BETWEEN Expression AND Expression
    | Expression NOT BETWEEN Expression AND Expression
    | Expression IS NULL
    | Expression IS NOT NULL
    | Expression LIKE Expression
    | Expression LIKE Expression ESCAPE StringLiteral
    | Expression NOT LIKE Expression
    | Expression NOT LIKE Expression ESCAPE StringLiteral
    | Expression IN Tuple
    | Expression NOT IN Tuple
    | PredicateFunction;

Tuple : '(' SelectQuery ')'
    | '(' ExpressionList ')';

ExpressionList : Expression ',' ExpressionList
    | Expression;

PredicateFunction : EXISTS '(' SelectQuery ')'
    | UPDATE '(' ColumnName ')'
    | CONTAINS '(' ColumnWildNameQualified ',' Expression ',' LANGUAGE Literal ')'
    | CONTAINS '(' ColumnWildNameQualified ',' Expression ')'
    | CONTAINS '(' '(' ColumnNameQualifiedList ')' ',' Expression ',' LANGUAGE Literal ')'
    | CONTAINS '(' '(' ColumnNameQualifiedList ')' ',' Expression ')'
    | FREETEXT '(' ColumnWildNameQualified ',' Expression ',' LANGUAGE Literal ')'
    | FREETEXT '(' ColumnWildNameQualified ',' Expression ')'
    | FREETEXT '(' '(' ColumnNameQualifiedList ')' ',' Expression ',' LANGUAGE Literal ')'
    | FREETEXT '(' '(' ColumnNameQualifiedList ')' ',' Expression ')'
    | PredicateParens;

PredicateParens : '(' Predicate ')';

Expression : ExpressionAdd;

ExpressionAdd : ExpressionMult '+' ExpressionAdd
    | ExpressionMult '-' ExpressionAdd
    | ExpressionMult '&' ExpressionAdd
    | ExpressionMult '|' ExpressionAdd
    | ExpressionMult '^' ExpressionAdd
    | ExpressionMult;

ExpressionMult : ExpressionMult '*' ExpressionNegate
    | ExpressionMult '/' ExpressionNegate
    | ExpressionMult '%' ExpressionNegate
    | ExpressionNegate;

ExpressionNegate : '-' ExpressionCase
    | '+' ExpressionCase // the "unary plus" also belongs somewhere here
    | '~' ExpressionCase
    | ExpressionCase;

RankingArguments : PARTITION BY ExpressionList OptionalOrderClause
    | OrderClause;

ExpressionCase : CASE Expression CaseWhenExpressionList ELSE Expression END
    | CASE Expression CaseWhenExpressionList END
    | CASE CaseWhenPredicateList ELSE Expression END
    | CASE CaseWhenPredicateList END
    | CollatedValue;

CaseWhenExpressionList : CaseWhenExpression CaseWhenExpressionList
    | CaseWhenExpression;

CaseWhenExpression : WHEN Expression THEN Expression;

CaseWhenPredicateList : CaseWhenPredicate CaseWhenPredicateList
    | CaseWhenPredicate;

CaseWhenPredicate : WHEN Predicate THEN Expression;

CollatedValue : Value COLLATE CollationName
    | Value
    | Literal;

FunctionCall : CAST '(' Expression AS TypeName ')'
    | COALESCE '(' ExpressionList ')'
    | NULLIF '(' Expression ',' Expression ')'
    | LEFT '(' Expression ',' Expression ')'
    | RIGHT '(' Expression ',' Expression ')'
    | CONVERT '(' TypeName ',' Expression ')'
    | CONVERT '(' TypeName ',' Expression ',' IntegerLiteral ')'
    | COUNT '(' ColumnWild ')'
    | COUNT '(' Expression ')'
    | COUNT '(' Restriction ColumnWild ')'
    | COUNT '(' Restriction Expression ')'
    | IDENTITY '(' TypeName ')'
    | IDENTITY '(' TypeName ',' IntegerLiteral ',' IntegerLiteral ')'
    | CURRENT_TIMESTAMP
    | CURRENT_USER
    | SESSION_USER
    | SYSTEM_USER
    | USER
    | NamedFunction;

NamedFunction : FunctionName '(' ')'
    | FunctionName '(' ExpressionList ')';

NamedFunctionList : NamedFunction '.' NamedFunctionList
    | NamedFunction;

Value : SystemVariableName
    | ColumnNameQualified
    | VariableName // CLR UDT property, field and methods are not yet implemented
    | ExpressionParens
    | ExpressionParens '.' NamedFunctionList
    | FunctionCall
    | FunctionCall '.' NamedFunctionList
    | TableName '.' NamedFunctionList // should be SchemaName '.' FunctionCall - but that gives a reduce-reduce error
    | TableName '.' ColumnName '.' NamedFunctionList // for functions such as .query()
    | FunctionCall OVER '(' RankingArguments ')';

ExpressionParens : '(' SelectQuery ')'
    | '(' Expression ')';
