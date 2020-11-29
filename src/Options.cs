// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using CommandLine;

namespace SwishDiagram
{
    internal class Options
    {
        [Value(0, Required = true, MetaName = "fileName", HelpText = "Input path.")]
        public string InputPath { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }
}
