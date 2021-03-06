﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace PubSubJobs.Publisher
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls("http://localhost:8000/")
                .Build();

            await webHost.RunAsync();
        }
    }
}