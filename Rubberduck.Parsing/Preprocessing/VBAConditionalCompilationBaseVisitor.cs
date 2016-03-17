//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Splinter\Documents\Visual Studio 2015\Projects\TestProj\TestProj\VBAConditionalCompilation.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Parsing.Preprocessing
{
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;
    using IToken = Antlr4.Runtime.IToken;
    using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

    /// <summary>
    /// This class provides an empty implementation of <see cref="IVBAConditionalCompilationVisitor{Result}"/>,
    /// which can be extended to create a visitor which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
    [System.CLSCompliant(false)]
    public partial class VBAConditionalCompilationBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IVBAConditionalCompilationVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccBlock"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcBlock([NotNull] VBAConditionalCompilationParser.CcBlockContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccEndIf"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcEndIf([NotNull] VBAConditionalCompilationParser.CcEndIfContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.logicalLine"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitLogicalLine([NotNull] VBAConditionalCompilationParser.LogicalLineContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccEol"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcEol([NotNull] VBAConditionalCompilationParser.CcEolContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccIfBlock"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcIfBlock([NotNull] VBAConditionalCompilationParser.CcIfBlockContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.intrinsicFunction"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitIntrinsicFunction([NotNull] VBAConditionalCompilationParser.IntrinsicFunctionContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccExpression"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcExpression([NotNull] VBAConditionalCompilationParser.CcExpressionContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseIfBlock"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcElseIfBlock([NotNull] VBAConditionalCompilationParser.CcElseIfBlockContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.extendedLine"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitExtendedLine([NotNull] VBAConditionalCompilationParser.ExtendedLineContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.literal"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitLiteral([NotNull] VBAConditionalCompilationParser.LiteralContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.typeSuffix"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitTypeSuffix([NotNull] VBAConditionalCompilationParser.TypeSuffixContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.compilationUnit"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCompilationUnit([NotNull] VBAConditionalCompilationParser.CompilationUnitContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccIf"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcIf([NotNull] VBAConditionalCompilationParser.CcIfContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseIf"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcElseIf([NotNull] VBAConditionalCompilationParser.CcElseIfContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.lineContinuation"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitLineContinuation([NotNull] VBAConditionalCompilationParser.LineContinuationContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElseBlock"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcElseBlock([NotNull] VBAConditionalCompilationParser.CcElseBlockContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.name"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitName([NotNull] VBAConditionalCompilationParser.NameContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccVarLhs"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcVarLhs([NotNull] VBAConditionalCompilationParser.CcVarLhsContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.intrinsicFunctionName"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitIntrinsicFunctionName([NotNull] VBAConditionalCompilationParser.IntrinsicFunctionNameContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccElse"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcElse([NotNull] VBAConditionalCompilationParser.CcElseContext context) { return VisitChildren(context); }

        /// <summary>
        /// Visit a parse tree produced by <see cref="VBAConditionalCompilationParser.ccConst"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitCcConst([NotNull] VBAConditionalCompilationParser.CcConstContext context) { return VisitChildren(context); }
    }
} // namespace Rubberduck.Parsing.Preprocessing
