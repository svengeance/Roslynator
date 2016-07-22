﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactoring
{
    internal class WrapStatementsInIfStatementRefactoring : WrapStatementsRefactoring<IfStatementSyntax>
    {
        public override IfStatementSyntax CreateStatement(ImmutableArray<StatementSyntax> statements)
        {
            return IfStatement(ParseExpression(""), Block(statements));
        }
    }
}
