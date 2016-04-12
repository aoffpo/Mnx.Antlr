parser grammar Post_en_Parser;
options { tokenVocab=Post_en_Lexer; } 
//@parser::header {#pragma warning disable 3021}

post
	: statement EOF
	;

statement 
	: (phrase)+ //hashtags //user_references //hyperlink
	;

phrase 
	: auxiliary_verb_phrase 
	| transitive_verb_phrase
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
	: (pronoun | meal) aux_verb preposition street_address  # PhraseWithAddress
	| (pronoun | meal) aux_verb preposition IDENTIFIER  # PhraseWithLocationLookup
	| pronoun aux_verb ON DAYOFWEEK # PhraseWithDayOfWeek
	| pronoun aux_verb IDENTIFIER TIMEOFDAY # PhraseWithTimeOfDay
	;
transitive_verb_phrase
	: TRANSITIVE_VERB pronoun //begin island to capture location
	;
street_address : digits street_name preposition? city ;
//time_range
// : date_time
// | date
// ;
pronoun : WE | YOU | OUR | US ;
aux_verb : TO_BE | TO_HAVE ; 
preposition : COMMA | TO | FROM | IN | ON | AT | OF | WITH ;
meal : LUNCH | DINNER | BREAKFAST ;

street_name : IDENTIFIER+ (STREETDESIGNATOR PERIOD? | STREETDESIGNATORLONG)?;
city : IDENTIFIER+ punctuation? ;
digits
 : DIGIT DIGIT*
 ;
punctuation
    : PERIOD
    | EXCLAMATIONPOINT ;
 unknowns : UNKNOWN+ ; 