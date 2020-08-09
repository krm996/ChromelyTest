using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;
using Chromely.Core.Defaults;
using Chromely.Core.Network;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChrTet
{
    public class CustomConfiguraton : DefaultConfiguration
    {
        public CustomConfiguraton()
        {
            var appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            StartUrl = $"file:///{appDirectory}app/asdasd.html";
            AppName = "Test";
        }
    }

    public class IronBirdChromelyApp : ChromelyBasicApp
    {
        public override void Configure(IChromelyContainer container)
        {
            base.Configure(container);
            container.RegisterSingleton(typeof(ChromelyController), Guid.NewGuid().ToString(), typeof(DemoController));

        }
    }
}
