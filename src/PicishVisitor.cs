// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

using Antlr4.Runtime.Tree;

namespace SwishDiagram
{
    // TODO - what type to use here?? <int> is certainly wrong.
    internal class PicishVisitor : PicishParserBaseVisitor<int>
    {
        public override int VisitStatement(PicishParser.StatementContext context)
        {
            Console.WriteLine("Statement: {0}", context.GetText());

            return VisitChildren(context);
        }


        public override int VisitShape(PicishParser.ShapeContext context)
        {
            Console.WriteLine("Shape: {0}", context.GetText());

            return VisitChildren(context);
        }
    }
}
