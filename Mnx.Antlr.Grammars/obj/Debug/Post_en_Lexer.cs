//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Steve\git\Mnx.Antlr\Mnx.Antlr.Grammars\Grammars\Post.en\Post_en_Lexer.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Mnx.Antlr.Grammars.Post.en {
#pragma warning disable 3021
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class Post_en_Lexer : Lexer {
	public const int
		YESTERDAY=1, TODAY=2, TOMORROW=3, TONIGHT=4, MORNING=5, AFTERNOON=6, EVENING=7, 
		AM=8, PM=9, TIMEOFDAY=10, LUNCH=11, DINNER=12, BREAKFAST=13, BRUNCH=14, 
		DAY=15, SUNDAY=16, MONDAY=17, TUESDAY=18, WEDNESDAY=19, THURSDAY=20, FRIDAY=21, 
		SATURDAY=22, DAYOFWEEK=23, TO_BE=24, WE=25, YOU=26, OUR=27, US=28, PRONOUN=29, 
		TO=30, FROM=31, IN=32, ON=33, AT=34, OF=35, WITH=36, PREPOSITION=37, THE=38, 
		FOR=39, AND=40, DIGIT=41, STRING=42, IDENTIFIER=43, WS=44;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"YESTERDAY", "TODAY", "TOMORROW", "TONIGHT", "MORNING", "AFTERNOON", "EVENING", 
		"AM", "PM", "TIMEOFDAY", "LUNCH", "DINNER", "BREAKFAST", "BRUNCH", "DAY", 
		"SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", 
		"DAYOFWEEK", "TO_BE", "WE", "YOU", "OUR", "US", "PRONOUN", "TO", "FROM", 
		"IN", "ON", "AT", "OF", "WITH", "PREPOSITION", "THE", "FOR", "AND", "DIGIT", 
		"STRING", "IDENTIFIER", "WS", "ESC", "A", "B", "C", "D", "E", "F", "G", 
		"H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", 
		"V", "W", "X", "Y", "Z"
	};


	public Post_en_Lexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, "YESTERDAY", "TODAY", "TOMORROW", "TONIGHT", "MORNING", "AFTERNOON", 
		"EVENING", "AM", "PM", "TIMEOFDAY", "LUNCH", "DINNER", "BREAKFAST", "BRUNCH", 
		"DAY", "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", 
		"SATURDAY", "DAYOFWEEK", "TO_BE", "WE", "YOU", "OUR", "US", "PRONOUN", 
		"TO", "FROM", "IN", "ON", "AT", "OF", "WITH", "PREPOSITION", "THE", "FOR", 
		"AND", "DIGIT", "STRING", "IDENTIFIER", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Post_en_Lexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2.\x1DC\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4?\t?\x4"+
		"@\t@\x4\x41\t\x41\x4\x42\t\x42\x4\x43\t\x43\x4\x44\t\x44\x4\x45\t\x45"+
		"\x4\x46\t\x46\x4G\tG\x4H\tH\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5\xB9\n\x5"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x5\v\xE4\n\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r"+
		"\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE"+
		"\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17"+
		"\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18"+
		"\x5\x18\x13A\n\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x5\x19\x142"+
		"\n\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C"+
		"\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x5\x1E"+
		"\x156\n\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!\x3\""+
		"\x3\"\x3\"\x3#\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3"+
		"&\x3&\x3&\x3&\x5&\x178\n&\x3\'\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3(\x3)\x3)"+
		"\x3)\x3)\x3*\x3*\x3+\x3+\x3+\a+\x18B\n+\f+\xE+\x18E\v+\x3+\x3+\x3+\x3"+
		"+\a+\x194\n+\f+\xE+\x197\v+\x3+\x5+\x19A\n+\x3,\x5,\x19D\n,\x3,\x3,\x3"+
		"-\x3-\x3-\x3-\x3.\x3.\x5.\x1A7\n.\x3/\x3/\x3\x30\x3\x30\x3\x31\x3\x31"+
		"\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x3\x35\x3\x36\x3\x36"+
		"\x3\x37\x3\x37\x3\x38\x3\x38\x3\x39\x3\x39\x3:\x3:\x3;\x3;\x3<\x3<\x3"+
		"=\x3=\x3>\x3>\x3?\x3?\x3@\x3@\x3\x41\x3\x41\x3\x42\x3\x42\x3\x43\x3\x43"+
		"\x3\x44\x3\x44\x3\x45\x3\x45\x3\x46\x3\x46\x3G\x3G\x3H\x3H\x4\x18C\x195"+
		"\x2\x2I\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2"+
		"\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11"+
		"!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31"+
		"\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!"+
		"\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2"+
		"-Y\x2.[\x2\x2]\x2\x2_\x2\x2\x61\x2\x2\x63\x2\x2\x65\x2\x2g\x2\x2i\x2\x2"+
		"k\x2\x2m\x2\x2o\x2\x2q\x2\x2s\x2\x2u\x2\x2w\x2\x2y\x2\x2{\x2\x2}\x2\x2"+
		"\x7F\x2\x2\x81\x2\x2\x83\x2\x2\x85\x2\x2\x87\x2\x2\x89\x2\x2\x8B\x2\x2"+
		"\x8D\x2\x2\x8F\x2\x2\x3\x2 \x3\x2\x32;\x4\x2$$^^\x4\x2))^^\n\x2$$))\x63"+
		"\x64hhppttvvxx\x4\x2\x43\x43\x63\x63\x4\x2\x44\x44\x64\x64\x4\x2\x45\x45"+
		"\x65\x65\x4\x2\x46\x46\x66\x66\x4\x2GGgg\x4\x2HHhh\x4\x2IIii\x4\x2JJj"+
		"j\x4\x2KKkk\x4\x2LLll\x4\x2MMmm\x4\x2NNnn\x4\x2OOoo\x4\x2PPpp\x4\x2QQ"+
		"qq\x4\x2RRrr\x4\x2SSss\x4\x2TTtt\x4\x2UUuu\x4\x2VVvv\x4\x2WWww\x4\x2X"+
		"Xxx\x4\x2YYyy\x4\x2ZZzz\x4\x2[[{{\x4\x2\\\\||\x1DF\x2\x3\x3\x2\x2\x2\x2"+
		"\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2"+
		"\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2"+
		"\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2"+
		"\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2"+
		"\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2"+
		"\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2"+
		"\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2"+
		"\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2"+
		"\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2"+
		"\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3"+
		"\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x3\x91\x3\x2\x2\x2\x5\x9B\x3"+
		"\x2\x2\x2\a\xA1\x3\x2\x2\x2\t\xB8\x3\x2\x2\x2\v\xBA\x3\x2\x2\x2\r\xC2"+
		"\x3\x2\x2\x2\xF\xCC\x3\x2\x2\x2\x11\xD4\x3\x2\x2\x2\x13\xD7\x3\x2\x2\x2"+
		"\x15\xE3\x3\x2\x2\x2\x17\xE5\x3\x2\x2\x2\x19\xEB\x3\x2\x2\x2\x1B\xF2\x3"+
		"\x2\x2\x2\x1D\xFC\x3\x2\x2\x2\x1F\x103\x3\x2\x2\x2!\x107\x3\x2\x2\x2#"+
		"\x10C\x3\x2\x2\x2%\x111\x3\x2\x2\x2\'\x117\x3\x2\x2\x2)\x11F\x3\x2\x2"+
		"\x2+\x126\x3\x2\x2\x2-\x12B\x3\x2\x2\x2/\x139\x3\x2\x2\x2\x31\x141\x3"+
		"\x2\x2\x2\x33\x143\x3\x2\x2\x2\x35\x146\x3\x2\x2\x2\x37\x14A\x3\x2\x2"+
		"\x2\x39\x14E\x3\x2\x2\x2;\x155\x3\x2\x2\x2=\x157\x3\x2\x2\x2?\x15A\x3"+
		"\x2\x2\x2\x41\x15F\x3\x2\x2\x2\x43\x162\x3\x2\x2\x2\x45\x165\x3\x2\x2"+
		"\x2G\x168\x3\x2\x2\x2I\x16B\x3\x2\x2\x2K\x177\x3\x2\x2\x2M\x179\x3\x2"+
		"\x2\x2O\x17D\x3\x2\x2\x2Q\x181\x3\x2\x2\x2S\x185\x3\x2\x2\x2U\x199\x3"+
		"\x2\x2\x2W\x19C\x3\x2\x2\x2Y\x1A0\x3\x2\x2\x2[\x1A4\x3\x2\x2\x2]\x1A8"+
		"\x3\x2\x2\x2_\x1AA\x3\x2\x2\x2\x61\x1AC\x3\x2\x2\x2\x63\x1AE\x3\x2\x2"+
		"\x2\x65\x1B0\x3\x2\x2\x2g\x1B2\x3\x2\x2\x2i\x1B4\x3\x2\x2\x2k\x1B6\x3"+
		"\x2\x2\x2m\x1B8\x3\x2\x2\x2o\x1BA\x3\x2\x2\x2q\x1BC\x3\x2\x2\x2s\x1BE"+
		"\x3\x2\x2\x2u\x1C0\x3\x2\x2\x2w\x1C2\x3\x2\x2\x2y\x1C4\x3\x2\x2\x2{\x1C6"+
		"\x3\x2\x2\x2}\x1C8\x3\x2\x2\x2\x7F\x1CA\x3\x2\x2\x2\x81\x1CC\x3\x2\x2"+
		"\x2\x83\x1CE\x3\x2\x2\x2\x85\x1D0\x3\x2\x2\x2\x87\x1D2\x3\x2\x2\x2\x89"+
		"\x1D4\x3\x2\x2\x2\x8B\x1D6\x3\x2\x2\x2\x8D\x1D8\x3\x2\x2\x2\x8F\x1DA\x3"+
		"\x2\x2\x2\x91\x92\x5\x8DG\x2\x92\x93\x5\x65\x33\x2\x93\x94\x5\x81\x41"+
		"\x2\x94\x95\x5\x83\x42\x2\x95\x96\x5\x65\x33\x2\x96\x97\x5\x7F@\x2\x97"+
		"\x98\x5\x63\x32\x2\x98\x99\x5]/\x2\x99\x9A\x5\x8DG\x2\x9A\x4\x3\x2\x2"+
		"\x2\x9B\x9C\x5\x83\x42\x2\x9C\x9D\x5y=\x2\x9D\x9E\x5\x63\x32\x2\x9E\x9F"+
		"\x5]/\x2\x9F\xA0\x5\x8DG\x2\xA0\x6\x3\x2\x2\x2\xA1\xA2\x5\x83\x42\x2\xA2"+
		"\xA3\x5y=\x2\xA3\xA4\x5u;\x2\xA4\xA5\x5y=\x2\xA5\xA6\x5\x7F@\x2\xA6\xA7"+
		"\x5\x7F@\x2\xA7\xA8\x5y=\x2\xA8\xA9\x5\x89\x45\x2\xA9\b\x3\x2\x2\x2\xAA"+
		"\xAB\x5\x83\x42\x2\xAB\xAC\x5y=\x2\xAC\xAD\x5w<\x2\xAD\xAE\x5m\x37\x2"+
		"\xAE\xAF\x5i\x35\x2\xAF\xB0\x5k\x36\x2\xB0\xB1\x5\x83\x42\x2\xB1\xB9\x3"+
		"\x2\x2\x2\xB2\xB3\x5w<\x2\xB3\xB4\x5m\x37\x2\xB4\xB5\x5i\x35\x2\xB5\xB6"+
		"\x5k\x36\x2\xB6\xB7\x5\x83\x42\x2\xB7\xB9\x3\x2\x2\x2\xB8\xAA\x3\x2\x2"+
		"\x2\xB8\xB2\x3\x2\x2\x2\xB9\n\x3\x2\x2\x2\xBA\xBB\x5u;\x2\xBB\xBC\x5y"+
		"=\x2\xBC\xBD\x5\x7F@\x2\xBD\xBE\x5w<\x2\xBE\xBF\x5m\x37\x2\xBF\xC0\x5"+
		"w<\x2\xC0\xC1\x5i\x35\x2\xC1\f\x3\x2\x2\x2\xC2\xC3\x5]/\x2\xC3\xC4\x5"+
		"g\x34\x2\xC4\xC5\x5\x83\x42\x2\xC5\xC6\x5\x65\x33\x2\xC6\xC7\x5\x7F@\x2"+
		"\xC7\xC8\x5w<\x2\xC8\xC9\x5y=\x2\xC9\xCA\x5y=\x2\xCA\xCB\x5w<\x2\xCB\xE"+
		"\x3\x2\x2\x2\xCC\xCD\x5\x65\x33\x2\xCD\xCE\x5\x87\x44\x2\xCE\xCF\x5\x65"+
		"\x33\x2\xCF\xD0\x5w<\x2\xD0\xD1\x5m\x37\x2\xD1\xD2\x5w<\x2\xD2\xD3\x5"+
		"i\x35\x2\xD3\x10\x3\x2\x2\x2\xD4\xD5\x5]/\x2\xD5\xD6\x5u;\x2\xD6\x12\x3"+
		"\x2\x2\x2\xD7\xD8\x5{>\x2\xD8\xD9\x5u;\x2\xD9\x14\x3\x2\x2\x2\xDA\xE4"+
		"\x5\x3\x2\x2\xDB\xE4\x5\x5\x3\x2\xDC\xE4\x5\a\x4\x2\xDD\xE4\x5\t\x5\x2"+
		"\xDE\xE4\x5\v\x6\x2\xDF\xE4\x5\r\a\x2\xE0\xE4\x5\xF\b\x2\xE1\xE4\x5\x11"+
		"\t\x2\xE2\xE4\x5\x13\n\x2\xE3\xDA\x3\x2\x2\x2\xE3\xDB\x3\x2\x2\x2\xE3"+
		"\xDC\x3\x2\x2\x2\xE3\xDD\x3\x2\x2\x2\xE3\xDE\x3\x2\x2\x2\xE3\xDF\x3\x2"+
		"\x2\x2\xE3\xE0\x3\x2\x2\x2\xE3\xE1\x3\x2\x2\x2\xE3\xE2\x3\x2\x2\x2\xE4"+
		"\x16\x3\x2\x2\x2\xE5\xE6\x5s:\x2\xE6\xE7\x5\x85\x43\x2\xE7\xE8\x5w<\x2"+
		"\xE8\xE9\x5\x61\x31\x2\xE9\xEA\x5k\x36\x2\xEA\x18\x3\x2\x2\x2\xEB\xEC"+
		"\x5\x63\x32\x2\xEC\xED\x5m\x37\x2\xED\xEE\x5w<\x2\xEE\xEF\x5w<\x2\xEF"+
		"\xF0\x5\x65\x33\x2\xF0\xF1\x5\x7F@\x2\xF1\x1A\x3\x2\x2\x2\xF2\xF3\x5_"+
		"\x30\x2\xF3\xF4\x5\x7F@\x2\xF4\xF5\x5\x65\x33\x2\xF5\xF6\x5]/\x2\xF6\xF7"+
		"\x5q\x39\x2\xF7\xF8\x5g\x34\x2\xF8\xF9\x5]/\x2\xF9\xFA\x5\x81\x41\x2\xFA"+
		"\xFB\x5\x83\x42\x2\xFB\x1C\x3\x2\x2\x2\xFC\xFD\x5_\x30\x2\xFD\xFE\x5\x7F"+
		"@\x2\xFE\xFF\x5\x85\x43\x2\xFF\x100\x5w<\x2\x100\x101\x5\x61\x31\x2\x101"+
		"\x102\x5k\x36\x2\x102\x1E\x3\x2\x2\x2\x103\x104\x5\x63\x32\x2\x104\x105"+
		"\x5]/\x2\x105\x106\x5\x8DG\x2\x106 \x3\x2\x2\x2\x107\x108\x5\x81\x41\x2"+
		"\x108\x109\x5\x85\x43\x2\x109\x10A\x5w<\x2\x10A\x10B\x5\x1F\x10\x2\x10B"+
		"\"\x3\x2\x2\x2\x10C\x10D\x5u;\x2\x10D\x10E\x5y=\x2\x10E\x10F\x5w<\x2\x10F"+
		"\x110\x5\x1F\x10\x2\x110$\x3\x2\x2\x2\x111\x112\x5\x83\x42\x2\x112\x113"+
		"\x5\x85\x43\x2\x113\x114\x5\x65\x33\x2\x114\x115\x5\x81\x41\x2\x115\x116"+
		"\x5\x1F\x10\x2\x116&\x3\x2\x2\x2\x117\x118\x5\x89\x45\x2\x118\x119\x5"+
		"\x65\x33\x2\x119\x11A\x5\x63\x32\x2\x11A\x11B\x5w<\x2\x11B\x11C\x5\x65"+
		"\x33\x2\x11C\x11D\x5\x81\x41\x2\x11D\x11E\x5\x1F\x10\x2\x11E(\x3\x2\x2"+
		"\x2\x11F\x120\x5\x83\x42\x2\x120\x121\x5k\x36\x2\x121\x122\x5\x85\x43"+
		"\x2\x122\x123\x5\x7F@\x2\x123\x124\x5\x81\x41\x2\x124\x125\x5\x1F\x10"+
		"\x2\x125*\x3\x2\x2\x2\x126\x127\x5g\x34\x2\x127\x128\x5\x7F@\x2\x128\x129"+
		"\x5m\x37\x2\x129\x12A\x5\x1F\x10\x2\x12A,\x3\x2\x2\x2\x12B\x12C\x5\x81"+
		"\x41\x2\x12C\x12D\x5]/\x2\x12D\x12E\x5\x83\x42\x2\x12E\x12F\x5\x85\x43"+
		"\x2\x12F\x130\x5\x7F@\x2\x130\x131\x5\x1F\x10\x2\x131.\x3\x2\x2\x2\x132"+
		"\x13A\x5!\x11\x2\x133\x13A\x5#\x12\x2\x134\x13A\x5%\x13\x2\x135\x13A\x5"+
		"\'\x14\x2\x136\x13A\x5)\x15\x2\x137\x13A\x5+\x16\x2\x138\x13A\x5-\x17"+
		"\x2\x139\x132\x3\x2\x2\x2\x139\x133\x3\x2\x2\x2\x139\x134\x3\x2\x2\x2"+
		"\x139\x135\x3\x2\x2\x2\x139\x136\x3\x2\x2\x2\x139\x137\x3\x2\x2\x2\x139"+
		"\x138\x3\x2\x2\x2\x13A\x30\x3\x2\x2\x2\x13B\x13C\x5_\x30\x2\x13C\x13D"+
		"\x5\x65\x33\x2\x13D\x142\x3\x2\x2\x2\x13E\x13F\x5m\x37\x2\x13F\x140\x5"+
		"\x81\x41\x2\x140\x142\x3\x2\x2\x2\x141\x13B\x3\x2\x2\x2\x141\x13E\x3\x2"+
		"\x2\x2\x142\x32\x3\x2\x2\x2\x143\x144\x5\x89\x45\x2\x144\x145\x5\x65\x33"+
		"\x2\x145\x34\x3\x2\x2\x2\x146\x147\x5\x8DG\x2\x147\x148\x5y=\x2\x148\x149"+
		"\x5\x85\x43\x2\x149\x36\x3\x2\x2\x2\x14A\x14B\x5y=\x2\x14B\x14C\x5\x85"+
		"\x43\x2\x14C\x14D\x5\x7F@\x2\x14D\x38\x3\x2\x2\x2\x14E\x14F\x5\x85\x43"+
		"\x2\x14F\x150\x5\x81\x41\x2\x150:\x3\x2\x2\x2\x151\x156\x5\x33\x1A\x2"+
		"\x152\x156\x5\x35\x1B\x2\x153\x156\x5\x37\x1C\x2\x154\x156\x5\x39\x1D"+
		"\x2\x155\x151\x3\x2\x2\x2\x155\x152\x3\x2\x2\x2\x155\x153\x3\x2\x2\x2"+
		"\x155\x154\x3\x2\x2\x2\x156<\x3\x2\x2\x2\x157\x158\x5\x83\x42\x2\x158"+
		"\x159\x5y=\x2\x159>\x3\x2\x2\x2\x15A\x15B\x5g\x34\x2\x15B\x15C\x5\x7F"+
		"@\x2\x15C\x15D\x5y=\x2\x15D\x15E\x5u;\x2\x15E@\x3\x2\x2\x2\x15F\x160\x5"+
		"m\x37\x2\x160\x161\x5w<\x2\x161\x42\x3\x2\x2\x2\x162\x163\x5y=\x2\x163"+
		"\x164\x5w<\x2\x164\x44\x3\x2\x2\x2\x165\x166\x5]/\x2\x166\x167\x5\x83"+
		"\x42\x2\x167\x46\x3\x2\x2\x2\x168\x169\x5y=\x2\x169\x16A\x5g\x34\x2\x16A"+
		"H\x3\x2\x2\x2\x16B\x16C\x5\x89\x45\x2\x16C\x16D\x5m\x37\x2\x16D\x16E\x5"+
		"\x83\x42\x2\x16E\x16F\x5k\x36\x2\x16FJ\x3\x2\x2\x2\x170\x178\x5=\x1F\x2"+
		"\x171\x178\x5? \x2\x172\x178\x5\x41!\x2\x173\x178\x5\x43\"\x2\x174\x178"+
		"\x5\x45#\x2\x175\x178\x5G$\x2\x176\x178\x5I%\x2\x177\x170\x3\x2\x2\x2"+
		"\x177\x171\x3\x2\x2\x2\x177\x172\x3\x2\x2\x2\x177\x173\x3\x2\x2\x2\x177"+
		"\x174\x3\x2\x2\x2\x177\x175\x3\x2\x2\x2\x177\x176\x3\x2\x2\x2\x178L\x3"+
		"\x2\x2\x2\x179\x17A\x5\x83\x42\x2\x17A\x17B\x5k\x36\x2\x17B\x17C\x5\x65"+
		"\x33\x2\x17CN\x3\x2\x2\x2\x17D\x17E\x5g\x34\x2\x17E\x17F\x5y=\x2\x17F"+
		"\x180\x5\x7F@\x2\x180P\x3\x2\x2\x2\x181\x182\x5]/\x2\x182\x183\x5w<\x2"+
		"\x183\x184\x5\x63\x32\x2\x184R\x3\x2\x2\x2\x185\x186\t\x2\x2\x2\x186T"+
		"\x3\x2\x2\x2\x187\x18C\a$\x2\x2\x188\x18B\x5[.\x2\x189\x18B\n\x3\x2\x2"+
		"\x18A\x188\x3\x2\x2\x2\x18A\x189\x3\x2\x2\x2\x18B\x18E\x3\x2\x2\x2\x18C"+
		"\x18D\x3\x2\x2\x2\x18C\x18A\x3\x2\x2\x2\x18D\x18F\x3\x2\x2\x2\x18E\x18C"+
		"\x3\x2\x2\x2\x18F\x19A\a$\x2\x2\x190\x195\a)\x2\x2\x191\x194\x5[.\x2\x192"+
		"\x194\n\x4\x2\x2\x193\x191\x3\x2\x2\x2\x193\x192\x3\x2\x2\x2\x194\x197"+
		"\x3\x2\x2\x2\x195\x196\x3\x2\x2\x2\x195\x193\x3\x2\x2\x2\x196\x198\x3"+
		"\x2\x2\x2\x197\x195\x3\x2\x2\x2\x198\x19A\a)\x2\x2\x199\x187\x3\x2\x2"+
		"\x2\x199\x190\x3\x2\x2\x2\x19AV\x3\x2\x2\x2\x19B\x19D\a\x42\x2\x2\x19C"+
		"\x19B\x3\x2\x2\x2\x19C\x19D\x3\x2\x2\x2\x19D\x19E\x3\x2\x2\x2\x19E\x19F"+
		"\x5U+\x2\x19FX\x3\x2\x2\x2\x1A0\x1A1\a\"\x2\x2\x1A1\x1A2\x3\x2\x2\x2\x1A2"+
		"\x1A3\b-\x2\x2\x1A3Z\x3\x2\x2\x2\x1A4\x1A6\a^\x2\x2\x1A5\x1A7\t\x5\x2"+
		"\x2\x1A6\x1A5\x3\x2\x2\x2\x1A7\\\x3\x2\x2\x2\x1A8\x1A9\t\x6\x2\x2\x1A9"+
		"^\x3\x2\x2\x2\x1AA\x1AB\t\a\x2\x2\x1AB`\x3\x2\x2\x2\x1AC\x1AD\t\b\x2\x2"+
		"\x1AD\x62\x3\x2\x2\x2\x1AE\x1AF\t\t\x2\x2\x1AF\x64\x3\x2\x2\x2\x1B0\x1B1"+
		"\t\n\x2\x2\x1B1\x66\x3\x2\x2\x2\x1B2\x1B3\t\v\x2\x2\x1B3h\x3\x2\x2\x2"+
		"\x1B4\x1B5\t\f\x2\x2\x1B5j\x3\x2\x2\x2\x1B6\x1B7\t\r\x2\x2\x1B7l\x3\x2"+
		"\x2\x2\x1B8\x1B9\t\xE\x2\x2\x1B9n\x3\x2\x2\x2\x1BA\x1BB\t\xF\x2\x2\x1BB"+
		"p\x3\x2\x2\x2\x1BC\x1BD\t\x10\x2\x2\x1BDr\x3\x2\x2\x2\x1BE\x1BF\t\x11"+
		"\x2\x2\x1BFt\x3\x2\x2\x2\x1C0\x1C1\t\x12\x2\x2\x1C1v\x3\x2\x2\x2\x1C2"+
		"\x1C3\t\x13\x2\x2\x1C3x\x3\x2\x2\x2\x1C4\x1C5\t\x14\x2\x2\x1C5z\x3\x2"+
		"\x2\x2\x1C6\x1C7\t\x15\x2\x2\x1C7|\x3\x2\x2\x2\x1C8\x1C9\t\x16\x2\x2\x1C9"+
		"~\x3\x2\x2\x2\x1CA\x1CB\t\x17\x2\x2\x1CB\x80\x3\x2\x2\x2\x1CC\x1CD\t\x18"+
		"\x2\x2\x1CD\x82\x3\x2\x2\x2\x1CE\x1CF\t\x19\x2\x2\x1CF\x84\x3\x2\x2\x2"+
		"\x1D0\x1D1\t\x1A\x2\x2\x1D1\x86\x3\x2\x2\x2\x1D2\x1D3\t\x1B\x2\x2\x1D3"+
		"\x88\x3\x2\x2\x2\x1D4\x1D5\t\x1C\x2\x2\x1D5\x8A\x3\x2\x2\x2\x1D6\x1D7"+
		"\t\x1D\x2\x2\x1D7\x8C\x3\x2\x2\x2\x1D8\x1D9\t\x1E\x2\x2\x1D9\x8E\x3\x2"+
		"\x2\x2\x1DA\x1DB\t\x1F\x2\x2\x1DB\x90\x3\x2\x2\x2\x10\x2\xB8\xE3\x139"+
		"\x141\x155\x177\x18A\x18C\x193\x195\x199\x19C\x1A6\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Mnx.Antlr.Grammars.Post.en
