grammar MSSql2008;
options{ language=CSharp5;} 
parse
 : ( Any_Ch  )* EOF
 ;
Single_Line_Comment : '--' ~[\r\n]* -> channel(HIDDEN);
Multiline_Comment : '/*' .*? ( '*/' | EOF ) -> channel(HIDDEN);
All_Valid:[\x01-\xFF];
Alphanumeric:[\x30-\x39\x41-\x5A\x61-\x7A];
Control_Codes:[\0-\x1F\x7F-\x9F];
Digit:[\x30-\x39];
Letter:[\x41-\x5A\x61-\x7A];
Whitespace:[\x09-\x0D\x20\xA0];
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Terminals
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;

Any_Ch : All_Valid  Control_Codes;	//{Any Ch} : {All Valid} - {Control Codes}
String_Ch : Any_Ch + Whitespace;//{String Ch} : {Any Ch} + {Whitespace} - ['']
Id_Ch_Standard : Alphanumeric+[_];//{Id Ch Standard} :{Alphanumeric} + [_]
Id_Ch_Delimited_Bracket : Any_Ch [ '[','\]' ];//{Id Ch Delimited Bracket} : {Any Ch} - ['['']']
Id_Ch_Delimited_Bracket_Start : Id_Ch_Delimited_Bracket  [#];	//{Id Ch Delimited Bracket Start} : {Id Ch Delimited Bracket} - [#]
Id_Ch_Delimited_Quote : Any_Ch ["#];	//{Id Ch Delimited Quote} : {Any Ch} - ["#]
Id_Ch_Delimited_Quote_Start : Id_Ch_Delimited_Quote  [#"];//{Id Ch Delimited Quote Start} : {Id Ch Delimited Quote} - [#]
Hex_Ch : [0123456789ABCDEF];	//{Hex Ch} : [0123456789ABCDEF]
Nonspace_Ch : Any_Ch Whitespace;	//{Nonspace Ch} : {Any Ch} - {Whitespace};

//StringLiteral : N?(String_Ch*)+  //StringLiteral : N?(String_Ch*)+
IntegerLiteral : Digit+;   //IntegerLiteral : {Digit}+
RealLiteral : Digit+'.'+Digit+;	   //RealLiteral : {Digit}+'.'{Digit}+
HexLiteral : '0x'Hex_Ch+;   //HexLiteral : 0x{Hex Ch}+;

// We use a simplified name convention, which does not allow user/schema, database or server to be specified
////Id : {Letter}{Id Ch Standard}*
////QuotedId : '['{Id Ch Delimited Bracket Start}{Id Ch Delimited Bracket}*']'
////         | '"'{Id Ch Delimited Quote Start}{Id Ch Delimited Quote}*'"'
////LocalId : '@'{Letter}{Id Ch Standard}*
////SystemVarId : '@@'{Letter}{Id Ch Standard}*
////SystemFuncId : '::'{Letter}{Id Ch Standard}*
////TempTableId : '#'{Letter}{Id Ch Standard}* | '[#'{Id Ch Delimited Bracket}+']' | '"#'{Id Ch Delimited Quote}+'"';

Id : Letter Id_Ch_Standard*;
QuotedId : '[' Id_Ch_Delimited_Bracket_Start  Id_Ch_Delimited_Bracket *']'
         | '"' Id_Ch_Delimited_Quote_Start  Id_Ch_Delimited_Quote *'"';
LocalId : '@' Letter  Id_Ch_Standard *;
SingleQuotedId : QuotedId;
SystemVarId : '@@' Letter  Id_Ch_Standard *;
SystemFuncId : '::' Letter  Id_Ch_Standard *;
TempTableId : '#' Letter  Id_Ch_Standard * | '[#' Id_Ch_Delimited_Bracket +']' | '"#' Id_Ch_Delimited_Quote +'"';
