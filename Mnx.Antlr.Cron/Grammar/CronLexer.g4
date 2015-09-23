lexer grammar CronLexer;
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
//Calendar Units
//--------------------------------------
DAY : D A Y S?;
WEEK : W E E K S?;
MONTH : M O N T H S?;
YEAR : Y E A R S?;
WEEKEND : W E E K E N D ;
WEEKDAY : W E E K D A Y ;
//--------------------------------------
//Days of the week
//--------------------------------------
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
//Months
//--------------------------------------
JANUARY : J A N U A R Y ;
FEBRUARY : F E B R U A R Y ;
MARCH : M A R C H ;
APRIL : A P R I L ;
MAY : M A Y ;
JUNE : J U N E ;
JULY : J U L Y ;
AUGUST : A U G U S T ;
SEPTEMBER : S E P T E M B E R ;
OCTOBER : O C T O B E R ;
NOVEMBER : N O V E M B E R ;
DECEMBER : D E C E M B E R ;
MONTHOFYEAR : JANUARY | FEBRUARY | MARCH | APRIL | MAY | JUNE | JULY | AUGUST | SEPTEMBER | OCTOBER | NOVEMBER | DECEMBER ;
//--------------------------------------
//Ordinals
//--------------------------------------
FIRST : F I R S T | '1' S T ;
SECOND : S E C O N D | '2' N D ;
THIRD : T H I R D | '3' R D ;
FOURTH : F O U R T H | '4' T H ;
FIFTH : F I F T H | '5' T H ;
LAST : L A S T ;
ORDINAL : FIRST | SECOND | THIRD | FOURTH | FIFTH | LAST ;
//--------------------------------------
// MODIFIERS
//--------------------------------------
EVERY : E V E R Y ;
THE : T H E ;
ON : O N ;
OF : O F ;
COMMA : ',' ;
AND : A N D ;

DIGIT : [0-9] ;
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
