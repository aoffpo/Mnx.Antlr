lexer grammar Post_en_Lexer;

DIGIT : [0-9] ;

WS
	:	' ' -> channel(HIDDEN)
	;

