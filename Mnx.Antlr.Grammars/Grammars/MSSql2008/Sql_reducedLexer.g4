lexer grammar Sql_reducedLexer;
@lexer::header {#pragma warning disable 3021}


Single_Line_Comment : '--' ~[\r\n]* -> channel(HIDDEN);
Multiline_Comment : '/*' .*? ( '*/' | EOF ) -> channel(HIDDEN);

COMMA : ',' ;
DOT : '.';
ASTERISK : '*';
LPAREN : '(' ;
RPAREN : ')' ;
LBRACKET : '[' ;
RBRACKET : ']' ;
POUND : '#' ;

STRING_LITERAL
 : '\'' ( ~'\'' | '\'\'' )* '\''
 ;

ACTION : A C T I O N ;
AS : A S ;
BIT : B I T ;
CHAR : C H A R ;
CREATE : C R E A T E ;
DATETIME : D A T E T I M E ;
DECIMAL : D E C I M A L ;
FLOAT : F L O A T ;
FOR: F O R ;
FROM : F R O M ;
IDENTITY : I D E N T I T Y ; 
INT : I N T ;
NCHAR : N CHAR ;
NOT : N O T ;
NULL : N U L L ;
NVARCHAR : N V A R CHAR ;
SELECT : S E L E C T ;
TABLE : T A B L E ;
VARCHAR : V A R CHAR ;
WHERE : W H E R E ;

IDENTIFIER 
	 : '"' (~'"' | '""')* '"'
	 | '`' (~'`' | '``')* '`'
	 | '[' ~']'* ']'
	 | [a-zA-Z_] [a-zA-Z_0-9]* // TODO check: needs more chars in set
	 ;

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