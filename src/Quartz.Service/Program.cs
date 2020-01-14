using Quartz.Service.Server;
using System;
using System.IO;
using Topshelf;

namespace Quartz.Service
{
    public static class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        public static void Main(string[] args)
        {
            // change from service account's dir to more logical one
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            // TODO: Add DI config
            // TODO: Add Logger Config

            HostFactory.Run(x => {
                x.RunAsLocalSystem();

                x.SetDescription(Configuration.ServiceDescription);
                x.SetDisplayName(Configuration.ServiceDisplayName);
                x.SetServiceName(Configuration.ServiceName);

                x.Service(factory => {
                    QuartzServer server = QuartzServerFactory.CreateServer();
                    server.Initialize().GetAwaiter().GetResult();
                    return server;
                });
            });
        }
    }
}
