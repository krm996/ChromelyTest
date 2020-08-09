using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;
using System;

namespace ChrTet
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder
            .Create()
            .UseConfiguration<CustomConfiguraton>()
            .UseApp<IronBirdChromelyApp>()
            .Build()
            .Run(args);
        }
    }
}
