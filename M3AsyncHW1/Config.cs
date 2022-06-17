using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using M3AsyncHW1.Interfaces;
using M3AsyncHW1.Services;

namespace M3AsyncHW1
{
    public class Config
    {
        public static void ConfigureContainer()
        {
            ContainerBuilder builder = new();
            builder.RegisterType<FileReaderService>().As<IFileReader>();
            var container = builder.Build();
        }
    }
}
