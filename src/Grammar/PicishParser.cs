//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PicishParser.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class PicishParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BOX=1, LINE=2, SEMI=3, WS=4;
	public const int
		RULE_file = 0, RULE_statement = 1, RULE_shape = 2;
	public static readonly string[] ruleNames = {
		"file", "statement", "shape"
	};

	private static readonly string[] _LiteralNames = {
		null, "'box'", "'line'", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "BOX", "LINE", "SEMI", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PicishParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PicishParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public PicishParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public PicishParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(PicishParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPicishParserVisitor<TResult> typedVisitor = visitor as IPicishParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 9;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==BOX || _la==LINE) {
				{
				{
				State = 6; statement();
				}
				}
				State = 11;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 12; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ShapeContext shape() {
			return GetRuleContext<ShapeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(PicishParser.SEMI, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPicishParserVisitor<TResult> typedVisitor = visitor as IPicishParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_statement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; shape();
			State = 15; Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ShapeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOX() { return GetToken(PicishParser.BOX, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LINE() { return GetToken(PicishParser.LINE, 0); }
		public ShapeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_shape; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPicishParserVisitor<TResult> typedVisitor = visitor as IPicishParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShape(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ShapeContext shape() {
		ShapeContext _localctx = new ShapeContext(Context, State);
		EnterRule(_localctx, 4, RULE_shape);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17;
			_la = TokenStream.LA(1);
			if ( !(_la==BOX || _la==LINE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x6', '\x16', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x3', '\x2', '\a', '\x2', '\n', 
		'\n', '\x2', '\f', '\x2', '\xE', '\x2', '\r', '\v', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x2', '\x2', '\x5', '\x2', '\x4', '\x6', 
		'\x2', '\x3', '\x3', '\x2', '\x3', '\x4', '\x2', '\x13', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '\x13', '\x3', '\x2', '\x2', '\x2', '\b', '\n', '\x5', '\x4', '\x3', 
		'\x2', '\t', '\b', '\x3', '\x2', '\x2', '\x2', '\n', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\t', '\x3', '\x2', '\x2', '\x2', '\v', '\f', '\x3', 
		'\x2', '\x2', '\x2', '\f', '\xE', '\x3', '\x2', '\x2', '\x2', '\r', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\a', '\x2', '\x2', '\x3', '\xF', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\x5', '\x6', '\x4', 
		'\x2', '\x11', '\x12', '\a', '\x5', '\x2', '\x2', '\x12', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x13', '\x14', '\t', '\x2', '\x2', '\x2', '\x14', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x3', '\v',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
