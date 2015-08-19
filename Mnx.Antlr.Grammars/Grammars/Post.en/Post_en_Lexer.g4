lexer grammar Post_en_Lexer;

WS
	:	' ' -> channel(HIDDEN)
	;
DIGIT : [0-9] ;
