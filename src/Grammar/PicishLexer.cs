//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PicishLexer.g4 by ANTLR 4.9

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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class PicishLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BOX=1, CIRCLE=2, LINE=3, DOWN=4, LEFT=5, RIGHT=6, UP=7, MOVE=8, SEMI=9, 
		WS=10, LINE_COMMENT=11;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"BOX", "CIRCLE", "LINE", "DOWN", "LEFT", "RIGHT", "UP", "MOVE", "SEMI", 
		"WS", "LINE_COMMENT"
	};


	public PicishLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public PicishLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string GrammarFileName { get { return "PicishLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PicishLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\r', 'U', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', 
		'\v', '\x4', '\f', '\t', '\f', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x6', '\v', '\x45', '\n', 
		'\v', '\r', '\v', '\xE', '\v', '\x46', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\a', '\f', 'O', '\n', '\f', 
		'\f', '\f', '\xE', '\f', 'R', '\v', '\f', '\x3', '\f', '\x3', '\f', '\x2', 
		'\x2', '\r', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x3', '\x2', '\x4', '\x5', '\x2', '\v', '\f', '\xF', '\xF', 
		'\"', '\"', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x2', 'V', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x19', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\a', '$', '\x3', '\x2', '\x2', '\x2', 
		'\t', ')', '\x3', '\x2', '\x2', '\x2', '\v', '.', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x33', '\x3', '\x2', '\x2', '\x2', '\xF', '\x39', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '<', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x41', '\x3', '\x2', '\x2', '\x2', '\x15', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\x17', 'J', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\a', 
		'\x64', '\x2', '\x2', '\x1A', '\x1B', '\a', 'q', '\x2', '\x2', '\x1B', 
		'\x1C', '\a', 'z', '\x2', '\x2', '\x1C', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x1E', '\a', '\x65', '\x2', '\x2', '\x1E', '\x1F', '\a', 'k', 
		'\x2', '\x2', '\x1F', ' ', '\a', 't', '\x2', '\x2', ' ', '!', '\a', '\x65', 
		'\x2', '\x2', '!', '\"', '\a', 'n', '\x2', '\x2', '\"', '#', '\a', 'g', 
		'\x2', '\x2', '#', '\x6', '\x3', '\x2', '\x2', '\x2', '$', '%', '\a', 
		'n', '\x2', '\x2', '%', '&', '\a', 'k', '\x2', '\x2', '&', '\'', '\a', 
		'p', '\x2', '\x2', '\'', '(', '\a', 'g', '\x2', '\x2', '(', '\b', '\x3', 
		'\x2', '\x2', '\x2', ')', '*', '\a', '\x66', '\x2', '\x2', '*', '+', '\a', 
		'q', '\x2', '\x2', '+', ',', '\a', 'y', '\x2', '\x2', ',', '-', '\a', 
		'p', '\x2', '\x2', '-', '\n', '\x3', '\x2', '\x2', '\x2', '.', '/', '\a', 
		'n', '\x2', '\x2', '/', '\x30', '\a', 'g', '\x2', '\x2', '\x30', '\x31', 
		'\a', 'h', '\x2', '\x2', '\x31', '\x32', '\a', 'v', '\x2', '\x2', '\x32', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\a', 't', '\x2', '\x2', 
		'\x34', '\x35', '\a', 'k', '\x2', '\x2', '\x35', '\x36', '\a', 'i', '\x2', 
		'\x2', '\x36', '\x37', '\a', 'j', '\x2', '\x2', '\x37', '\x38', '\a', 
		'v', '\x2', '\x2', '\x38', '\xE', '\x3', '\x2', '\x2', '\x2', '\x39', 
		':', '\a', 'w', '\x2', '\x2', ':', ';', '\a', 'r', '\x2', '\x2', ';', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '<', '=', '\a', 'o', '\x2', '\x2', 
		'=', '>', '\a', 'q', '\x2', '\x2', '>', '?', '\a', 'x', '\x2', '\x2', 
		'?', '@', '\a', 'g', '\x2', '\x2', '@', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\x41', '\x42', '\a', '=', '\x2', '\x2', '\x42', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x43', '\x45', '\t', '\x2', '\x2', '\x2', '\x44', '\x43', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x46', '\x44', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\x3', '\x2', 
		'\x2', '\x2', 'G', 'H', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\b', '\v', 
		'\x2', '\x2', 'I', '\x16', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', 
		'\x31', '\x2', '\x2', 'K', 'L', '\a', '\x31', '\x2', '\x2', 'L', 'P', 
		'\x3', '\x2', '\x2', '\x2', 'M', 'O', '\n', '\x3', '\x2', '\x2', 'N', 
		'M', '\x3', '\x2', '\x2', '\x2', 'O', 'R', '\x3', '\x2', '\x2', '\x2', 
		'P', 'N', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'Q', 'S', '\x3', '\x2', '\x2', '\x2', 'R', 'P', '\x3', '\x2', '\x2', '\x2', 
		'S', 'T', '\b', '\f', '\x2', '\x2', 'T', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '\x2', '\x46', 'P', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
