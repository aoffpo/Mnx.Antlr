parser grammar Post_en_Parser;
options { tokenVocab=Post_en_Lexer; } 
@parser::header {#pragma warning disable 3021}

post
	: statement EOF
	;

statement 
	: phrase+ //hashtags //user_references //hyperlink
	;

phrase 
	: subject+ predicate? object?
	;
subject
    : PRONOUN
	| DAYOFWEEK
    ;
predicate
    : verb
    ;
object
    : PREPOSITION IDENTIFIER   # LocationLookup
	| PREPOSITION DAYOFWEEK    # DayOfWeek 
	| PREPOSITION TIMEOFDAY    # TimeOfDay
    ;

verb:
	TO_BE
	;
