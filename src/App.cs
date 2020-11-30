// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System.IO;

using Antlr4.Runtime;
using SwishDiagram.Parser;

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

            var lexer = new PicishLexer(new AntlrInputStream(content));

            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowingErrorListener<int>());

            var parser = new PicishParser(new CommonTokenStream(lexer));

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowingErrorListener<IToken>());

            // TODO - clean this up!

            // var result = new PicishVisitor().Visit(parser.file());
            var result = new FileVisitor().Visit(parser.file());

            // TODO - dump/render the diagram

            // Console.WriteLine("Run is not yet implemented: {0} -> {1}.", options.InputPath, outputPath);
            // Console.WriteLine("Result: {0}", result);
        }
    }
}
