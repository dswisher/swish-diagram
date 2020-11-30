// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;

using SwishDiagram.Models;

namespace SwishDiagram.Parser
{
    internal class ShapeVisitor : PicishParserBaseVisitor<GraphicObject>
    {
        public override GraphicObject VisitShape(PicishParser.ShapeContext context)
        {
            // TODO - this isn't quite right - need another abstraction for non-shape statements

            Console.WriteLine("Visit Shape: {0}", context.GetText());

            return VisitChildren(context);
        }
    }
}
