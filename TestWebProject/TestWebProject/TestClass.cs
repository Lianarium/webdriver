using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace TestWebProject
{
	[TestFixture]
    public class TestClass
    {

		public IWebDriver Driver { get; set; }
		public WebDriverWait Wait { get; set; }
		private string configValue = ConfigurationSettings.AppSettings["browser"];

	    [OneTimeSetUp]
		public void SetupTest()
		{
			if ("ff".Equals(this.configValue))
			{
				var service = FirefoxDriverService.CreateDefaultService();
				this.Driver = new FirefoxDriver(service);
			}


			else
			{
				ChromeOptions option = new ChromeOptions();
				option.AddArgument("disable-infobars");
				this.Driver = new ChromeDriver(option);


			}

			 
		}

		[OneTimeTearDown]
		public void TeardownTest()
		{
			this.Driver.Quit();
		}

		[Test]
		public void Test1()
		{
			LogInPage loginpage = new LogInPage(this.Driver);
			loginpage.GoToLogInPage();
		 	loginpage.FillLoginField("alyapine");
			loginpage.FillPasswordField("3psdpsdpsd3");
			loginpage.ClickToLogIn();
			HomePage homepage = new HomePage(this.Driver);
			homepage.ValidateHomePage();
			homepage.GoToHomePage();
			homepage.ClickprojectsLink();
			homepage.CreateNewProject();
			

		}

		[Test]
		public void Test2()
		{
		  
		}
	}
}
