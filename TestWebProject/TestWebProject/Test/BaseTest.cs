using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using NUnit.Framework;
using TestWebLibrary.BrowserWork;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    public class BaseTest
    {
        protected static Browser Browser = Browser.Instance;

        [OneTimeSetUp]
        public virtual void InitializeTest()
        {
	        XmlConfigurator.Configure();//Logging!
			Browser = Browser.Instance;
            Browser.WindowMaximize();
            Browser.NavigateTo(ConfigManager.ConfigUrl);
        }

        [OneTimeTearDown]
        public virtual void CleanTest()
        {
            Browser.Quit();
        }

    }
}
