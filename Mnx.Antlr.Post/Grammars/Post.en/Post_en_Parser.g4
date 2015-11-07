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
	: (PRONOUN | MEAL) AUX_VERB PREPOSITION street_address  # PhraseWithAddress
	| (PRONOUN | MEAL) AUX_VERB PREPOSITION IDENTIFIER  # PhraseWithLocationLookup
	| PRONOUN AUX_VERB ON DAYOFWEEK # PhraseWithDayOfWeek
	| PRONOUN AUX_VERB IDENTIFIER TIMEOFDAY # PhraseWithTimeOfDay
	;
transitive_verb_phrase
	: TRANSITIVE_VERB PRONOUN //begin island to capture location
	;
street_address : DIGIT+ IDENTIFIER+ COMMA? (STREETDESIGNATOR PERIOD? | STREETDESIGNATORLONG) (COMMA CITY)? ;
//time_range
// : date_time
// | date
// ;
 digits
 : DIGIT DIGIT?
 ;
 unknowns : UNKNOWN+ ; 