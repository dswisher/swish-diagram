// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;

using Antlr4.Runtime;
using FluentAssertions;
using SwishDiagram.Models;
using SwishDiagram.Parser;
using Xunit;

namespace SwishDiagram.Tests.Parser
{
    public class SimpleParserTests
    {
        [Theory]
        [InlineData("box;", typeof(Box))]
        [InlineData("circle;", typeof(Circle))]
        public void CanParseSimpleShape(string content, Type expectedShape)
        {
            // Arrange
            var parser = CreateParser(content);

            // Act
            var diagram = new FileVisitor().Visit(parser.file());

            // Assert
            diagram.Should().NotBeNull();
            diagram.Objects.Should().HaveCount(1);

            var shape = diagram.Objects[0];

            shape.Should().BeOfType(expectedShape);

            shape.Center.X.Should().Be(0.0);
            shape.Center.Y.Should().Be(0.0);

            // TODO - verify width and height
        }



        private PicishParser CreateParser(string content)
        {
            var lexer = new PicishLexer(new AntlrInputStream(content));

            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowingErrorListener<int>());

            var parser = new PicishParser(new CommonTokenStream(lexer));

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowingErrorListener<IToken>());

            return parser;
        }
    }
}
