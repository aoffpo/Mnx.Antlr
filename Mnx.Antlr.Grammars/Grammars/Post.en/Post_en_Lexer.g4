lexer grammar Post_en_Lexer;

YESTERDAY : Y E S T E R D A Y ;
TODAY : T O D A Y ;
TOMORROW : T O M O R R O W ;
TONIGHT : T O N I G H T 
	|  N I G H T
	;
MORNING : M O R N I N G ;
AFTERNOON : A F T E R N O O N ;
EVENING : E V E N I N G ;

DAY : D A Y ;
SUNDAY : S U N DAY ;
MONDAY : M O N DAY ;
TUESDAY : T U E S DAY ;
WEDNESDAY : W E D N E S DAY ;
THURSDAY : T H U R S DAY ;
FRIDAY : F R I DAY ;
SATURDAY : S A T U R DAY ;


DIGIT : [0-9] ;

WS
	:	' ' -> channel(HIDDEN)
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