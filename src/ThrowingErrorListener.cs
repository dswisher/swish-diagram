// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;
using System.IO;

using Antlr4.Runtime;

namespace SwishDiagram
{
    internal class ThrowingErrorListener<TSymbol> : IAntlrErrorListener<TSymbol>
    {
        public void SyntaxError(TextWriter output, IRecognizer recognizer, TSymbol offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new Exception($"line {line}:{charPositionInLine} {msg}");
        }
    }
}
