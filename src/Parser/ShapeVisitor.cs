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
            Console.WriteLine("Visit Shape: {0}", context.GetText());

            GraphicObject shape = null;
            if (context.BOX() != null)
            {
                shape = new Box();
            }
            else if (context.CIRCLE() != null)
            {
                shape = new Circle();
            }

            if (shape != null)
            {
                shape.Center = new Point();
            }

            // TODO - set width, height, color, etc.

            return shape;
        }
    }
}
