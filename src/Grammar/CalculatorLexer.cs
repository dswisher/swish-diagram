//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calculator.g4 by ANTLR 4.9

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
public partial class CalculatorLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LPAREN=1, RPAREN=2, OPERATOR=3, ADD=4, SUBTRACT=5, MULTIPLY=6, DIVIDE=7, 
		DIGIT=8, WS=9;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LPAREN", "RPAREN", "OPERATOR", "ADD", "SUBTRACT", "MULTIPLY", "DIVIDE", 
		"DIGIT", "WS"
	};


	public CalculatorLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CalculatorLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", null, "'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LPAREN", "RPAREN", "OPERATOR", "ADD", "SUBTRACT", "MULTIPLY", "DIVIDE", 
		"DIGIT", "WS"
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

	public override string GrammarFileName { get { return "Calculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CalculatorLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\v', '\x33', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\x1E', '\n', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x6', '\t', ')', '\n', '\t', '\r', 
		'\t', '\xE', '\t', '*', '\x3', '\n', '\x6', '\n', '.', '\n', '\n', '\r', 
		'\n', '\xE', '\n', '/', '\x3', '\n', '\x3', '\n', '\x2', '\x2', '\v', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x3', '\x2', '\x4', '\x3', 
		'\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', 
		'\x2', '\x37', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x15', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\a', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\t', '\x1F', '\x3', '\x2', '\x2', '\x2', '\v', '!', '\x3', '\x2', 
		'\x2', '\x2', '\r', '#', '\x3', '\x2', '\x2', '\x2', '\xF', '%', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '(', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'-', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\a', '*', '\x2', '\x2', 
		'\x16', '\x4', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', '+', 
		'\x2', '\x2', '\x18', '\x6', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1E', 
		'\x5', '\t', '\x5', '\x2', '\x1A', '\x1E', '\x5', '\v', '\x6', '\x2', 
		'\x1B', '\x1E', '\x5', '\r', '\a', '\x2', '\x1C', '\x1E', '\x5', '\xF', 
		'\b', '\x2', '\x1D', '\x19', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x1D', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', '\b', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', ' ', '\a', '-', '\x2', '\x2', ' ', '\n', '\x3', 
		'\x2', '\x2', '\x2', '!', '\"', '\a', '/', '\x2', '\x2', '\"', '\f', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\a', ',', '\x2', '\x2', '$', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '%', '&', '\a', '\x31', '\x2', '\x2', '&', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\'', ')', '\t', '\x2', '\x2', '\x2', '(', 
		'\'', '\x3', '\x2', '\x2', '\x2', ')', '*', '\x3', '\x2', '\x2', '\x2', 
		'*', '(', '\x3', '\x2', '\x2', '\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', 
		'+', '\x12', '\x3', '\x2', '\x2', '\x2', ',', '.', '\t', '\x3', '\x2', 
		'\x2', '-', ',', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', '\x2', 
		'\x2', '/', '-', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\x30', '\x31', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', 
		'\b', '\n', '\x2', '\x2', '\x32', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '\x2', '\x1D', '*', '/', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
