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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPost_en_ParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class Post_en_ParserBaseListener : IPost_en_ParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.DayOfWeek"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDayOfWeek([NotNull] Post_en_Parser.DayOfWeekContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.DayOfWeek"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDayOfWeek([NotNull] Post_en_Parser.DayOfWeekContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.TimeOfDay"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTimeOfDay([NotNull] Post_en_Parser.TimeOfDayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.TimeOfDay"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTimeOfDay([NotNull] Post_en_Parser.TimeOfDayContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.LocationLookup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocationLookup([NotNull] Post_en_Parser.LocationLookupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.LocationLookup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocationLookup([NotNull] Post_en_Parser.LocationLookupContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.post"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPost([NotNull] Post_en_Parser.PostContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.post"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPost([NotNull] Post_en_Parser.PostContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] Post_en_Parser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] Post_en_Parser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.phrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPhrase([NotNull] Post_en_Parser.PhraseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.phrase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPhrase([NotNull] Post_en_Parser.PhraseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.subject"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubject([NotNull] Post_en_Parser.SubjectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.subject"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubject([NotNull] Post_en_Parser.SubjectContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicate([NotNull] Post_en_Parser.PredicateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicate([NotNull] Post_en_Parser.PredicateContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.@object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject([NotNull] Post_en_Parser.ObjectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.@object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject([NotNull] Post_en_Parser.ObjectContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="Post_en_Parser.verb"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVerb([NotNull] Post_en_Parser.VerbContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Post_en_Parser.verb"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVerb([NotNull] Post_en_Parser.VerbContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Mnx.Antlr.Grammars.Grammars.Post.en