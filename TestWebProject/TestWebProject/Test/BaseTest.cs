using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestWebLibrary.BrowserWork;
using TestWebLibrary.Models;
using TestWebLibrary.Steps;
using TestWebLibrary.Utils;
using Logger = TestWebLibrary.Logger;


namespace TestWebProject.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        //protected static Browser Browser = Browser.Instance;
        protected static IBrowser Browser = BrowserFactory.GetBrowser();
        protected static string projname;
	    protected bool IsLoginRequired = true;
         
        [OneTimeSetUp]
        public virtual void InitializeTest()
        {   

	        Logger.InitLogger();
            Browser.WindowMaximize();
            Browser.NavigateTo(ConfigManager.ConfigUrl);
	        
		}

	    [SetUp]
	    public void LogIn()
        { 
            SetUp.LoginCondition = Convert.ToBoolean(ConfigManager.SetUpLogin);
		    if (IsLoginRequired)//if we need to log in before performing test
		    {
			    User user = new User(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
				CheckLogInSteps step = new CheckLogInSteps();
		        step.LogIn(user);
		        projname = ConfigManager.ProjectName + Randomiser.GetRandomString(5);
	        }

      }

        [OneTimeTearDown]
        public virtual void CleanTest()
        {
            Browser.Quit();
        }

    }
}
