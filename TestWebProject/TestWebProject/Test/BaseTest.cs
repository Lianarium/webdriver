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
  
        protected static IBrowser Browser = BrowserFactory.GetBrowser();//non-static !!! 
        protected static string Projname;
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
           
		    if (IsLoginRequired)//if we need to log in before performing test
		    {
			    User user = new User(TestData.UserLogin, TestData.UserPassword);
				CheckLogInSteps step = new CheckLogInSteps();
		        step.LogIn(user);
		        Projname = TestData.ProjectName + Randomiser.GetRandomString(5);
	        }

      }

        [OneTimeTearDown]
        public virtual void CleanTest()
        {
            Browser.Quit();
        }

    }
}
