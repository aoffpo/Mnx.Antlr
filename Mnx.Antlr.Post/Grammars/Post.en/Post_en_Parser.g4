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
	: auxiliary_verb_phrase
	| transitive_verb_phrase
	;
subject
    : PRONOUN
	| DAYOFWEEK
    ;
//predicate
//    : verb
//    ;
//object
//    : PREPOSITION IDENTIFIER   # LocationLookup
//	| PREPOSITION DAYOFWEEK    # DayOfWeek 
//	| PREPOSITION TIMEOFDAY    # TimeOfDay
//    ;

auxiliary_verb_phrase
	: PRONOUN AUX_VERB PREPOSITION IDENTIFIER  # LocationLookup
	| PRONOUN AUX_VERB ON DAYOFWEEK # DayOfWeek
	| PRONOUN AUX_VERB IDENTIFIER TIMEOFDAY # TimeOfDay
	;
transitive_verb_phrase
	: TRANSITIVE_VERB PRONOUN //begin island to capture location or identifier
	;
//time_range
// : date_time
// | date
// ;
 digits
 : DIGIT DIGIT?
 ;