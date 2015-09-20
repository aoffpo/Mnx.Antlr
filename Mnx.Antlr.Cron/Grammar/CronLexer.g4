lexer grammar CronLexer;
@lexer::header {#pragma warning disable 3021}
WS
	:	' ' -> channel(HIDDEN)
	;
