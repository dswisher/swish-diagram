// Copyright (c) Doug Swisher. All Rights Reserved.
// Licensed under the MIT License. See LICENSE.md in the project root for license information.

using System;

using CommandLine;
using Microsoft.Extensions.DependencyInjection;

namespace SwishDiagram
{
    internal sealed class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddSingleton<App>();

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    services.AddSingleton<Options>(o);

                    using (var serviceProvider = services.BuildServiceProvider())
                    {
                        var app = serviceProvider.GetRequiredService<App>();

                        try
                        {
                            app.Run();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unhandled exception in main:\n{0}", ex.ToString());
                        }
                    }
                });
        }
    }
}
