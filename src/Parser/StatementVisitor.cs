// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;

using SwishDiagram.Models;

namespace SwishDiagram.Parser
{
    internal class StatementVisitor : PicishParserBaseVisitor<GraphicObject>
    {
        public override GraphicObject VisitStatement(PicishParser.StatementContext context)
        {
            // TODO - this isn't quite right - need another abstraction for non-shape statements

            if (context.shape() != null)
            {
                var visitor = new ShapeVisitor();

                return context.shape().Accept(visitor);
            }
            else if (context.direction() != null)
            {
                var visitor = new DirectionVisitor();

                context.direction().Accept(visitor);

                // TODO - is this right?
                return null;
            }
            else
            {
                Console.WriteLine("Statement is neither shape nor direction!");

                // TODO - is this right?
                return null;
            }
        }
    }
}
