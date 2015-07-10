lexer grammar Sql_reducedLexer;
@lexer::header {#pragma warning disable 3021}


Single_Line_Comment : '--' ~[\r\n]* -> channel(HIDDEN);
Multiline_Comment : '/*' .*? ( '*/' | EOF ) -> channel(HIDDEN);

COMMA : ',' ;

STRING_LITERAL
 : '\'' ( ~'\'' | '\'\'' )* '\''
 ;

ACTION : 'ACTION';
SELECT : 'select' ;
FROM : 'from' ;
WHERE : 'where';
FOR: 'for';
WITH: 'with';
CHECK : 'check';
OPTION : 'option';
UPDATE : 'update';

IDENTIFIER : 
		SELECT |
		FROM | 
		ALPHANUMERIC+ ;

DIGIT : [0-9] ;
LETTER : [A-Za-z] ;
ALPHANUMERIC:LETTER | DIGIT;
WS
	:	' ' -> channel(HIDDEN)
	;