// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;

using SwishDiagram.Models;

namespace SwishDiagram.Parser
{
    // TODO - this should return a directive object?
    internal class DirectiveVisitor : PicishParserBaseVisitor<GraphicObject>
    {
        public override GraphicObject VisitDirective(PicishParser.DirectiveContext context)
        {
            Console.WriteLine("Visit Directive: {0}", context.GetText());

            return VisitChildren(context);
        }
    }
}
