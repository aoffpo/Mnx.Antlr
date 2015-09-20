//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Steve\git\Mnx.Antlr\Mnx.Antlr.Grammars\Grammars\Post.en\Post_en_Parser.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Mnx.Antlr.Grammars.Grammars.Post.en {
#pragma warning disable 3021
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Post_en_Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IPost_en_ParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>DayOfWeek</c>
	/// labeled alternative in <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDayOfWeek([NotNull] Post_en_Parser.DayOfWeekContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DayOfWeek</c>
	/// labeled alternative in <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDayOfWeek([NotNull] Post_en_Parser.DayOfWeekContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>TimeOfDay</c>
	/// labeled alternative in <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTimeOfDay([NotNull] Post_en_Parser.TimeOfDayContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TimeOfDay</c>
	/// labeled alternative in <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTimeOfDay([NotNull] Post_en_Parser.TimeOfDayContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>LocationLookup</c>
	/// labeled alternative in <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocationLookup([NotNull] Post_en_Parser.LocationLookupContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LocationLookup</c>
	/// labeled alternative in <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocationLookup([NotNull] Post_en_Parser.LocationLookupContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.post"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPost([NotNull] Post_en_Parser.PostContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.post"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPost([NotNull] Post_en_Parser.PostContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] Post_en_Parser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] Post_en_Parser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.phrase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPhrase([NotNull] Post_en_Parser.PhraseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.phrase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPhrase([NotNull] Post_en_Parser.PhraseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.subject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubject([NotNull] Post_en_Parser.SubjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.subject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubject([NotNull] Post_en_Parser.SubjectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicate([NotNull] Post_en_Parser.PredicateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicate([NotNull] Post_en_Parser.PredicateContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject([NotNull] Post_en_Parser.ObjectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject([NotNull] Post_en_Parser.ObjectContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVerb([NotNull] Post_en_Parser.VerbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.verb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVerb([NotNull] Post_en_Parser.VerbContext context);
}
} // namespace Mnx.Antlr.Grammars.Grammars.Post.en