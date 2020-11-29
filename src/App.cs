// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;
using System.IO;

using Antlr4.Runtime;

namespace SwishDiagram
{
    internal class App
    {
        private readonly Options options;

        public App(Options options)
        {
            this.options = options;
        }



        public void Run()
        {
            // Determine the output file.
            // TODO - make options.InputPath non-required, and set things up to be able to read from stdin
            // TODO - base the output extension on the file type
            string outputPath = Path.ChangeExtension(options.InputPath, ".svg");

            // TODO - figure out how to lex a stream!
            string content;
            using (var reader = new StreamReader(options.InputPath))
            {
                content = reader.ReadToEnd();
            }

            CalculatorLexer lexer = new CalculatorLexer(new AntlrInputStream(content));

            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowingErrorListener<int>());

            CalculatorParser parser = new CalculatorParser(new CommonTokenStream(lexer));

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowingErrorListener<IToken>());

            // TODO - clean this up!

            var result = new CalculatorVisitor().Visit(parser.expression());

            // Console.WriteLine("Run is not yet implemented: {0} -> {1}.", options.InputPath, outputPath);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
