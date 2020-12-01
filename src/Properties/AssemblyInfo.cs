// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyCompany("swish-diagram")]
[assembly: AssemblyVersion("0.1.0.0")]

// TODO - add remaining attributes

// The Antlr generated files issue a warning without this; see:
//   https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3021
//   https://stackoverflow.com/questions/42138418/equivalent-to-assemblyinfo-in-dotnet-core-csproj
[assembly: CLSCompliant(true)]

// Allow the unit tests to access our internals
[assembly: InternalsVisibleTo("SwishDiagram.Tests")]
