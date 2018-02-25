using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebLibrary.BrowserWork;
using TestWebLibrary.Utils;

namespace TestWebLibrary.Test
{
    public class BaseTest
    {
        protected static Browser browser = Browser.Instance;

        [OneTimeSetUp]
        public virtual void InitializeTest()
        {
            browser = Browser.Instance;
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
