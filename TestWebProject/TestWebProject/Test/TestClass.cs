
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TestWebProject;
using NUnit.Framework;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Test;
using TestWebLibrary.Utils;

namespace TestWebProject
{
	[TestFixture]
    public class TestClass : BaseTest
    {

		[Test]
		public void Test1()
		{

		    var loginpage = new LogInPage();
            //loginpage.GoToLogInPage();
		    /*LogInPage loginpage = new LogInPage(this.Driver);
            loginpage.GoToLogInPage();
             loginpage.FillLoginField(ConfigManager.ConfigLogin);
            loginpage.FillPasswordField(ConfigManager.ConfigPassword);

            HomePage homepage = loginpage.ClickToLogIn();
            homepage.ValidateHomePage();
            homepage.ClickprojectsLink();
            homepage.CreateNewProject();*/


		}

		[Test]
		public void Test2()
		{
		  
		}
	}
}
