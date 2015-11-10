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
//BRUNCH : B R U N C H ;
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
//AUX VERBS  
//--------------------------------------
TO_BE: B E 
	| A M
	| A R E 
	| I S 
	| W I L L B E //figure out helper verbs (future tense)
	;
TO_HAVE : H A S
	| H A V E  
	;

//--------------------------------------
// TRANSITIVE VERBS
//--------------------------------------
CATCH : C A T C H ;
FIND : F I N D ;

TRANSITIVE_VERB : CATCH
	| FIND
	;
//--------------------------------------
// 
//--------------------------------------

//-------------------------------------- 
//PRONOUNS  
//--------------------------------------
WE : W E ;
YOU : Y O U ;
OUR : O U R ;
US : U S ;

//--------------------------------------
//PREPOSITIONS  
//--------------------------------------
TO : T O ;
FROM : F R O M ;
IN : I N ;
ON : O N ;
AT : A T | '@';
OF : O F ;
WITH : W I T H ;
//--------------------------------------
//Common Words
//--------------------------------------
THE : T H E ;
FOR : F O R ; 
AND : A N D ;
//A : A ;
//--------------------------------------
//Addresses
//--------------------------------------

//--------------------------------------
COMMA : ',' ;
PERIOD: '.' ;
DIGIT : [0-9] ;

IDENTIFIER 
    : ('a'..'z' | 'A'..'Z'|'@'|'#')('a'..'z' | 'A'..'Z'|'@'|'#')*
    ;
WS
	: ' ' -> channel(HIDDEN)
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

STREETDESIGNATOR:
 'ALY' |
  'ANX' |
  'ARC' |
  'AVE' |
  'BCH' |
  'BG' |
  'BGS' |
  'BLF' |
  'BLFS' |
  'BLVD' |
  'BND' |
  'BR' |
  'BRG' |
  'BRK' |
  'BRKS' |
  'BTM' |
  'BYP' |
  'BYU' |
  'CIR' |
  'CIRS' |
  'CLB' |
  'CLF' |
  'CLFS' |
  'CMN' |
  'COR' |
  'CORS' |
  'CP' |
  'CPE' |
  'CRES' |
  'CRK' |
  'CRSE' |
  'CRST' |
  'CSWY' |
  'CT' |
  'CTR' |
  'CTRS' |
  'CTS' |
  'CURV' |
  'CV' |
  'CVS' |
  'CYN' |
  'DL' |
  'DM' |
  'DR' |
  'DRS' |
  'DV' |
  'EST' |
  'ESTS' |
  'EXPY' |
  'EXT' |
  'EXTS' |
  'FALL' |
  'FLD' |
  'FLDS' |
  'FLS' |
  'FLT' |
  'FLTS' |
  'FRD' |
  'FRDS' |
  'FRG' |
  'FRGS' |
  'FRK' |
  'FRKS' |
  'FRST' |
  'FRY' |
  'FT' |
  'FWY' |
  'GDN' |
  'GDNS' |
  'GLN' |
  'GLNS' |
  'GRN' |
  'GRNS' |
  'GRV' |
  'GRVS' |
  'GTWY' |
  'HBR' |
  'HBRS' |
  'HL' |
  'HLS' |
  'HOLW' |
  'HTS' |
  'HVN' |
  'HWY' |
  'INLT' |
  'IS' |
  'ISLE' |
  'ISS' |
  'JCT' |
  'JCTS' |
  'KNL' |
  'KNLS' |
  'KY' |
  'KYS' |
  'LAND' |
  'LCK' |
  'LCKS' |
  'LDG' |
  'LF' |
  'LGT' |
  'LGTS' |
  'LK' |
  'LKS' |
  'LN' |
  'LNDG' |
  'LOOP' |
  'MALL' |
  'MDW' |
  'MDWS' |
  'MEWS' |
  'ML' |
  'MLS' |
  'MNR' |
  'MNRS' |
  'MSN' |
  'MT' |
  'MTN' |
  'MTNS' |
  'MTWY' |
  'NCK' |
  'OPAS' |
  'ORCH' |
  'OVAL' |
  'PARK' |
  'PASS' |
  'PATH' |
  'PIKE' |
  'PKWY' |
  'PL' |
  'PLN' |
  'PLNS' |
  'PLZ' |
  'PNE' |
  'PNES' |
  'PR' |
  'PRT' |
  'PRTS' |
  'PSGE' |
  'PT' |
  'PTS' |
  'RADL' |
  'RAMP' |
  'RD' |
  'RDG' |
  'RDGS' |
  'RDS' |
  'RIV' |
  'RNCH' |
  'ROW' |
  'RPD' |
  'RPDS' |
  'RR' |
  'RST' |
  'RTE' |
  'RUE' |
  'RUN' |
  'SHL' |
  'SHLS' |
  'SHR' |
  'SHRS' |
  'SKWY' |
  'SMT' |
  'SPG' |
  'SPGS' |
  'SPUR' |
  'SQ' |
  'SQS' |
  'ST' |
  'STA' |
  'STRA' |
  'STRM' |
  'STS' |
  'TER' |
  'TPKE' |
  'TRAK' |
  'TRCE' |
  'TRFY' |
  'TRL' |
  'TRWY' |
  'TUNL' |
  'UN' |
  'UNS' |
  'UPAS' |
  'VIA' |
  'VIS' |
  'VL' |
  'VLG' |
  'VLGS' |
  'VLY' |
  'VLYS' |
  'VW' |
  'VWS' |
  'WALK' |
  'WALL' |
  'WAY' |
  'WAYS' |
  'WL' |
  'WLS' |
  'XING' |
  'XRD' 
	;
STREETDESIGNATORLONG:
 'ALLEY' |
  'ANNEX' |
  'ARCADE' |
  'AVENUE' |
  'BEACH' |
  'BURG' |
  'BURGS' |
  'BLUFF' |
  'BLUFFS' |
  'BOULEVARD' |
  'BEND' |
  'BRANCH' |
  'BRIDGE' |
  'BROOK' |
  'BROOKS' |
  'BOTTOM' |
  'BYPASS' |
  'BAYOU' |
  'BAYOO' |
  'CIRCLE' |
  'CIRCLES' |
  'CLUB' |
  'CLIFF' |
  'CLIFFS' |
  'COMMON' |
  'CORNER' |
  'CORNERS' |
  'CAMP' |
  'CAPE' |
  'CRESCENT' |
  'CREEK' |
  'COURSE' |
  'CREST' |
  'CAUSEWAY' |
  'COURT' |
  'CENTER' |
  'CENTERS' |
  'COURTS' |
  'CURVE' |
  'COVE' |
  'COVES' |
  'CANYON' |
  'DALE' |
  'DAM' |
  'DRIVE' |
  'DRIVES' |
  'DIVIDE' |
  'ESTATE' |
  'ESTATES' |
  'EXPRESSWAY' |
  'EXTENSION' |
  'EXTENSIONS' |
  'FIELD' |
  'FIELDS' |
  'FALLS' |
  'FLAT' |
  'FLATS' |
  'FORD' |
  'FORDS' |
  'FORGE' |
  'FORGES' |
  'FORK' |
  'FORKS' |
  'FOREST' |
  'FERRY' |
  'FORT' |
  'FREEWAY' |
  'GARDEN' |
  'GARDENS' |
  'GLEN' |
  'GLENS' |
  'GREEN' |
  'GREENS' |
  'GROVE' |
  'GROVES' |
  'GATEWAY' |
  'HARBOR' |
  'HARBORS' |
  'HILL' |
  'HILLS' |
  'HOLLOW' |
  'HEIGHTS' |
  'HAVEN' |
  'HIGHWAY' |
  'INLET' |
  'ISLAND' |
  'ISLANDS' |
  'JUNCTION' |
  'JUNCTIONS' |
  'KNOLL' |
  'KNOLLS' |
  'KEY' |
  'KEYS' |
  'LOCK' |
  'LOCKS' |
  'LODGE' |
  'LOAF' |
  'LIGHT' |
  'LIGHTS' |
  'LAKE' |
  'LAKES' |
  'LANE' |
  'LANDING' |
  'MEADOW' |
  'MEADOWS' |
  'MILL' |
  'MILLS' |
  'MANOR' |
  'MANORS' |
  'MISSION' |
  'MOUNT' |
  'MOUNTAIN' |
  'MOUNTAINS' |
  'MOTORWAY' |
  'NECK' |
  'OVERPASS' |
  'ORCHARD' |
  'PARKS' |
  'PARKWAY' |
  'PARKWAYS' |
  'PLACE' |
  'PLAIN' |
  'PLAINS' |
  'PLAZA' |
  'PINE' |
  'PINES' |
  'PRAIRIE' |
  'PORT' |
  'PORTS' |
  'PASSAGE' |
  'POINT' |
  'POINTS' |
  'RADIAL' |
  'ROAD' |
  'RIDGE' |
  'RIDGES' |
  'ROADS' |
  'RIVER' |
  'RANCH' |
  'RAPID' |
  'RAPIDS' |
  'RURAL ROUTE' |
  'REST' |
  'ROUTE' |
  'SHOAL' |
  'SHOALS' |
  'SHORE' |
  'SHORES' |
  'SKYWAY' |
  'SUMMIT' |
  'SPRING' |
  'SPRINGS' |
  'SPUR(S)' |
  'SQUARE' |
  'SQUARES' |
  'STREET' |
  'STATION' |
  'STRAVENUE' |
  'STREAM' |
  'STREETS' |
  'TERRACE' |
  'TURNPIKE' |
  'TRACK' |
  'TRACE' |
  'TRAFFICWAY' |
  'TRAIL' |
  'THROUGHWAY' |
  'TUNNEL' |
  'UNION' |
  'UNIONS' |
  'UNDERPASS' |
  'VIADUCT' |
  'VISTA' |
  'VILLE' |
  'VILLAGE' |
  'VILLAGES' |
  'VALLEY' |
  'VALLEYS' |
  'VIEW' |
  'VIEWS' |
  'WELL' |
  'WELLS' |
  'CROSSING'
  ;

UNKNOWN  : . ; 