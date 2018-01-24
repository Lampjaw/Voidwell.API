﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Voidwell.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:5000")
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.Sources.Clear();
                    config.AddJsonFile("appsettings.json", true);
                    config.AddJsonFile("testsettings.json", true, true);
                    config.AddEnvironmentVariables();
                })
                .ConfigureLogging(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Information);
                    builder.AddFilter("Microsoft.AspNetCore.Mvc", LogLevel.Error);
                    builder.AddDebug();
                })
                .Build();
    }
}
