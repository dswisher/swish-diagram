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
		BOX=1, CIRCLE=2, LINE=3, DOWN=4, LEFT=5, RIGHT=6, UP=7, MOVE=8, SEMI=9, 
		WS=10, LINE_COMMENT=11;
	public const int
		RULE_file = 0, RULE_statement = 1, RULE_direction = 2, RULE_shape = 3;
	public static readonly string[] ruleNames = {
		"file", "statement", "direction", "shape"
	};

	private static readonly string[] _LiteralNames = {
		null, "'box'", "'circle'", "'line'", "'down'", "'left'", "'right'", "'up'", 
		"'move'", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "BOX", "CIRCLE", "LINE", "DOWN", "LEFT", "RIGHT", "UP", "MOVE", 
		"SEMI", "WS", "LINE_COMMENT"
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
			State = 11;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOX) | (1L << CIRCLE) | (1L << LINE) | (1L << DOWN) | (1L << LEFT) | (1L << RIGHT) | (1L << UP) | (1L << MOVE))) != 0)) {
				{
				{
				State = 8; statement();
				}
				}
				State = 13;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 14; Match(Eof);
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
		[System.Diagnostics.DebuggerNonUserCode] public DirectionContext direction() {
			return GetRuleContext<DirectionContext>(0);
		}
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
			State = 22;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOX:
			case CIRCLE:
			case LINE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 16; shape();
				State = 17; Match(SEMI);
				}
				break;
			case DOWN:
			case LEFT:
			case RIGHT:
			case UP:
			case MOVE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 19; direction();
				State = 20; Match(SEMI);
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class DirectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UP() { return GetToken(PicishParser.UP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOWN() { return GetToken(PicishParser.DOWN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEFT() { return GetToken(PicishParser.LEFT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RIGHT() { return GetToken(PicishParser.RIGHT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MOVE() { return GetToken(PicishParser.MOVE, 0); }
		public DirectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_direction; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPicishParserVisitor<TResult> typedVisitor = visitor as IPicishParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DirectionContext direction() {
		DirectionContext _localctx = new DirectionContext(Context, State);
		EnterRule(_localctx, 4, RULE_direction);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << DOWN) | (1L << LEFT) | (1L << RIGHT) | (1L << UP) | (1L << MOVE))) != 0)) ) {
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

	public partial class ShapeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOX() { return GetToken(PicishParser.BOX, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CIRCLE() { return GetToken(PicishParser.CIRCLE, 0); }
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
		EnterRule(_localctx, 6, RULE_shape);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOX) | (1L << CIRCLE) | (1L << LINE))) != 0)) ) {
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
		'\x5964', '\x3', '\r', '\x1F', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\a', '\x2', '\f', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\xF', 
		'\v', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x19', 
		'\n', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x2', '\x2', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x4', '\x3', 
		'\x2', '\x6', '\n', '\x3', '\x2', '\x3', '\x5', '\x2', '\x1C', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x4', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x6', '\x1A', '\x3', '\x2', '\x2', '\x2', '\b', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\n', '\f', '\x5', '\x4', '\x3', '\x2', '\v', '\n', 
		'\x3', '\x2', '\x2', '\x2', '\f', '\xF', '\x3', '\x2', '\x2', '\x2', '\r', 
		'\v', '\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\xE', '\x10', '\x3', '\x2', '\x2', '\x2', '\xF', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '\x11', '\a', '\x2', '\x2', '\x3', '\x11', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x12', '\x13', '\x5', '\b', '\x5', '\x2', 
		'\x13', '\x14', '\a', '\v', '\x2', '\x2', '\x14', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x16', '\x5', '\x6', '\x4', '\x2', '\x16', '\x17', 
		'\a', '\v', '\x2', '\x2', '\x17', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x18', '\x12', '\x3', '\x2', '\x2', '\x2', '\x18', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', 
		'\t', '\x2', '\x2', '\x2', '\x1B', '\a', '\x3', '\x2', '\x2', '\x2', '\x1C', 
		'\x1D', '\t', '\x3', '\x2', '\x2', '\x1D', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\x4', '\r', '\x18',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
