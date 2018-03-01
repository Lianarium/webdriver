﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using NUnit.Framework;
using TestWebLibrary.BrowserWork;
using TestWebLibrary.Steps;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    public class BaseTest
    {
        protected static Browser Browser = Browser.Instance;
        protected static string projname;

        [OneTimeSetUp]
        public virtual void InitializeTest()
        {
	        XmlConfigurator.Configure();//Logging!
			Browser = Browser.Instance;
            Browser.WindowMaximize();
            Browser.NavigateTo(ConfigManager.ConfigUrl);
        }

	    [SetUp]
		public void LogIn()
	    {
			 LogInPageSteps.LogIn(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
	         projname = ConfigManager.ProjectName + Randomiser.GetRandomString(5);
	    }

        [OneTimeTearDown]
        public virtual void CleanTest()
        {
            Browser.Quit();
        }

    }
}
