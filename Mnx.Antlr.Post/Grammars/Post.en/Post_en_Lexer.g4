lexer grammar Post_en_Lexer;
@lexer::header {#pragma warning disable 3021}
//------------------------------------
//Time of day
//------------------------------------
YESTERDAY : Y E S T E R D A Y ;
TODAY : T O D A Y ;
TOMORROW : T O M O R R O W ;
TONIGHT : T O N I G H T 
	|  N I G H T
	;
MORNING : M O R N I N G ;
AFTERNOON : A F T E R N O O N ;
EVENING : E V E N I N G ;
AM : A M ;
PM : P M ;
//TIME : 
TIMEOFDAY
	: YESTERDAY  | TODAY | TOMORROW | TONIGHT | MORNING | AFTERNOON | EVENING | AM | PM 
	;
//--------------------------------------
//Meal
//--------------------------------------
LUNCH : L U N C H ;
DINNER : D I N N E R ;  
BREAKFAST : B R E A K F A S T ; 
BRUNCH: B R U N C H ;

//--------------------------------------
//Days of the week
//--------------------------------------
DAY : D A Y ;
SUNDAY : S U N DAY ;
MONDAY : M O N DAY ;
TUESDAY : T U E S DAY ;
WEDNESDAY : W E D N E S DAY ;
THURSDAY : T H U R S DAY ;
FRIDAY : F R I DAY ;
SATURDAY : S A T U R DAY ;
DAYOFWEEK
	: SUNDAY | MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY | SATURDAY
	;
//--------------------------------------
//VERBS  
//--------------------------------------
TO_BE: B E | I S ;
//-------------------------------------- 
//PRONOUNS  
//--------------------------------------
WE : W E ;
YOU : Y O U ;
OUR : O U R ;
US : U S ;
PRONOUN : WE | YOU | OUR | US ;
//--------------------------------------
//PREPOSITIONS  
//--------------------------------------
TO : T O ;
FROM : F R O M ;
IN : I N ;
ON : O N ;
AT : A T ;
OF : O F ;
WITH : W I T H ;
PREPOSITION : TO | FROM | IN | ON | AT | OF | WITH ;
//--------------------------------------
//Common Words
//--------------------------------------
THE : T H E ;
FOR : F O R ; 
AND : A N D ;
//A : A ;

DIGIT : [0-9] ;
STRING
    :   '"' ( ESC | ~[\\"] )*? '"'
    |   '\'' ( ESC | ~[\\'] )*? '\''
    ;
IDENTIFIER : '@'? STRING
	;
WS
	:	' ' -> channel(HIDDEN)
	;

fragment
ESC :   '\\' ([abtnfrv]|'"'|'\'')
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