using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace StudentGradingSystem
{
    public class Program
    {
        private static System.Threading.CancellationTokenSource cancelTokenSource = new System.Threading.CancellationTokenSource();
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
        public static void Shutdown()
        {
            
            cancelTokenSource.Cancel();
        }
    }
}
