// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

using Antlr4.Runtime.Tree;

namespace SwishDiagram
{
    internal class CalculatorVisitor : CalculatorBaseVisitor<int>
    {
        private readonly Dictionary<string, Func<int, int, int>> funcMap =
            new Dictionary<string, Func<int, int, int>>
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => a - b },
                { "*", (a, b) => a * b },
                { "/", (a, b) => a / b }
            };


        public override int VisitExpression(CalculatorParser.ExpressionContext context)
        {
            return HandleGroup(context.operand(), context.OPERATOR());
        }


        public override int VisitOperand(CalculatorParser.OperandContext context)
        {
            ITerminalNode digit = context.DIGIT();

            return digit != null
                ? int.Parse(digit.GetText())
                : HandleGroup(context.operand(), context.OPERATOR());
        }


        private int HandleGroup(CalculatorParser.OperandContext[] operandCtxs, ITerminalNode[] operatorNodes)
        {
            List<int> operands = operandCtxs.Select(Visit).ToList();
            Queue<string> operators = new Queue<string>(operatorNodes.Select(o => o.GetText()));

            return operands.Aggregate((a, c) => funcMap[operators.Dequeue()](a, c));
        }
    }
}
