﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Roslynator.Metadata;

public record CodeFixMetadata(string Id, string Identifier, string Title, bool IsEnabledByDefault, bool IsObsolete)
{
    public List<string> FixableDiagnosticIds { get; } = new();
}
