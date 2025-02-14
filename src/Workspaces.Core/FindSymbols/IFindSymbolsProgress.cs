﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;

namespace Roslynator.FindSymbols;

internal interface IFindSymbolsProgress
{
    void OnSymbolFound(ISymbol symbol);
}
