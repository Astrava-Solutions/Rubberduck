//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Splinter\Documents\Visual Studio 2015\Projects\RubberduckParserTest\RubberduckParserTest\VBAConditionalCompilationParser.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Parsing.Preprocessing {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="VBAConditionalCompilationParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IVBAConditionalCompilationParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcBlock([NotNull] VBAConditionalCompilationParser.CcBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcBlock([NotNull] VBAConditionalCompilationParser.CcBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccEndIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcEndIf([NotNull] VBAConditionalCompilationParser.CcEndIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccEndIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcEndIf([NotNull] VBAConditionalCompilationParser.CcEndIfContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.logicalLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalLine([NotNull] VBAConditionalCompilationParser.LogicalLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.logicalLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalLine([NotNull] VBAConditionalCompilationParser.LogicalLineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccEol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcEol([NotNull] VBAConditionalCompilationParser.CcEolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccEol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcEol([NotNull] VBAConditionalCompilationParser.CcEolContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcIfBlock([NotNull] VBAConditionalCompilationParser.CcIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcIfBlock([NotNull] VBAConditionalCompilationParser.CcIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.intrinsicFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntrinsicFunction([NotNull] VBAConditionalCompilationParser.IntrinsicFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.intrinsicFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntrinsicFunction([NotNull] VBAConditionalCompilationParser.IntrinsicFunctionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcExpression([NotNull] VBAConditionalCompilationParser.CcExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcExpression([NotNull] VBAConditionalCompilationParser.CcExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcElseIfBlock([NotNull] VBAConditionalCompilationParser.CcElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcElseIfBlock([NotNull] VBAConditionalCompilationParser.CcElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.typeHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeHint([NotNull] VBAConditionalCompilationParser.TypeHintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.typeHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeHint([NotNull] VBAConditionalCompilationParser.TypeHintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] VBAConditionalCompilationParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] VBAConditionalCompilationParser.LiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] VBAConditionalCompilationParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] VBAConditionalCompilationParser.CompilationUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcIf([NotNull] VBAConditionalCompilationParser.CcIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcIf([NotNull] VBAConditionalCompilationParser.CcIfContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcElseIf([NotNull] VBAConditionalCompilationParser.CcElseIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcElseIf([NotNull] VBAConditionalCompilationParser.CcElseIfContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcElseBlock([NotNull] VBAConditionalCompilationParser.CcElseBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcElseBlock([NotNull] VBAConditionalCompilationParser.CcElseBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] VBAConditionalCompilationParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] VBAConditionalCompilationParser.NameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccVarLhs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcVarLhs([NotNull] VBAConditionalCompilationParser.CcVarLhsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccVarLhs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcVarLhs([NotNull] VBAConditionalCompilationParser.CcVarLhsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.intrinsicFunctionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntrinsicFunctionName([NotNull] VBAConditionalCompilationParser.IntrinsicFunctionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.intrinsicFunctionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntrinsicFunctionName([NotNull] VBAConditionalCompilationParser.IntrinsicFunctionNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcElse([NotNull] VBAConditionalCompilationParser.CcElseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcElse([NotNull] VBAConditionalCompilationParser.CcElseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment([NotNull] VBAConditionalCompilationParser.CommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment([NotNull] VBAConditionalCompilationParser.CommentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VBAConditionalCompilationParser.ccConst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCcConst([NotNull] VBAConditionalCompilationParser.CcConstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccConst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCcConst([NotNull] VBAConditionalCompilationParser.CcConstContext context);
}
} // namespace Rubberduck.Parsing.Preprocessing
