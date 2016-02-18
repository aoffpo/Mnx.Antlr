lexer grammar Sql_reducedLexer;
@lexer::header {#pragma warning disable 3021}


Single_Line_Comment : '--' ~[\r\n]* -> channel(HIDDEN);
Multiline_Comment : '/*' .*? ( '*/' | EOF ) -> channel(HIDDEN);

ASTERISK : '*';
AMPERSAND : '@' ;
COMMA : ',' ;
DOT : '.';
EQ : '=' ;
LPAREN : '(' ;
RPAREN : ')' ;
LBRACKET : '[' ;
RBRACKET : ']' ;
//SINGLEQUOTE : '\'' ; 
POUND : '#' ;
SEMICOLON : ';' ;
UNDERSCORE : '_' ;
COLON : ':' ;

ACTION : A C T I O N ;
ALL : A L L ;
AND : A N D ;
AS : A S ;
BIT : B I T ;
CHAR : C H A R ;
CREATE : C R E A T E ;
DATETIME : D A T E T I M E ;
DECIMAL : D E C I M A L ;
DECLARE : D E C L A R E ;
DROP : D R O P ;
FLOAT : F L O A T ;
FOR: F O R ;
FROM : F R O M ;
IDENTITY : I D E N T I T Y ; 
IF : I F ;
INT : I N T ;
IS : I S ;
INSERT : I N S E R T ;
LONG : L O N G ;
NCHAR : N CHAR ;
NOCOUNT : N O C O U N T ;
NOT : N O T ;
NULL : N U L L ;
OBJECT_ID : O B J E C T UNDERSCORE I D ;
ON : O N ;
OFF : O F F ;
NVARCHAR : N V A R CHAR ;
SELECT : S E L E C T ;
SET : S E T ;
TABLE : T A B L E ;
TEMPDB : T E M P D B DOT DOT ;
UNION : U N I O N ;
VARCHAR : V A R CHAR ;
WHERE : W H E R E ;

//QUOTED IDENTIFIER

IDENTIFIER 
	 : '"' (~'"' | '""')* '"'
	 | '\'' (~'\'' | '\'\'')* '\''
	 | '`' (~'`' | '``')* '`'
	 | '[' ~']'* ']'
	 | [a-zA-Z_\.] [a-zA-Z_0-9\.]* // TODO check: needs more chars in set
	 ;
LITERAL : N IDENTIFIER ;
DIGIT : [0-9] ;
LETTER : [A-Za-z] ;
ALPHANUMERIC:LETTER | DIGIT;

WS
	: [ \t\r\n] -> channel(HIDDEN)
	;

fragment A : [aA];
fragment B : [bB];
fragment C : [cC];
fragment D : [dD];
fragment E : [eE];
fragment F : [fF];
fragment G : [gG];
fragment H : [hH];
fragment I : [iI];
fragment J : [jJ];
fragment K : [kK];
fragment L : [lL];
fragment M : [mM];
fragment N : [nN];
fragment O : [oO];
fragment P : [pP];
fragment Q : [qQ];
fragment R : [rR];
fragment S : [sS];
fragment T : [tT];
fragment U : [uU];
fragment V : [vV];
fragment W : [wW];
fragment X : [xX];
fragment Y : [yY];
fragment Z : [zZ];