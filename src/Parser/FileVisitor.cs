// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

using SwishDiagram.Models;

namespace SwishDiagram.Parser
{
    internal class FileVisitor : PicishParserBaseVisitor<Diagram>
    {
        public override Diagram VisitFile(PicishParser.FileContext context)
        {
            var diagram = new Diagram();

            Console.WriteLine("VisitFile");

            var statementVisitor = new StatementVisitor();

            List<GraphicObject> objects = context.statement().Select(x => x.Accept(statementVisitor)).ToList();

            diagram.Objects.AddRange(objects);

            return diagram;
        }
    }
}
