parser grammar CronParser;
options { tokenVocab=CronLexer; } 
@parser::header {#pragma warning disable 3021}
compileUnit
	:	EOF
	;
