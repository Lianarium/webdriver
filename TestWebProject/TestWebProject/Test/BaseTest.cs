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
        protected static Browser Browser = Browser.Instance;
        protected static IBrowser Ibrowser = new BrowserFactory();
        protected static string projname;
	    protected bool IsLoginReuired = true;
         
        [OneTimeSetUp]
        public virtual void InitializeTest()
        {   

	        Logger.InitLogger();
			Browser = Ibrowser.GetBrowser();
           
            Browser.WindowMaximize();
            Browser.NavigateTo(ConfigManager.ConfigUrl);
	        
		}

	    [SetUp]
	    public void LogIn()
        { 
            SetUp.LoginCondition = Convert.ToBoolean(ConfigManager.SetUpLogin);
		    if (IsLoginReuired)//if we need to log in before performing test
		    {
			    User user = new User(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
				LogInSteps step = new LogInSteps();
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
