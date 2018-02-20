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

namespace TestWebProject
{
	[TestClass]
	public class SignInPage
	{
		private IWebDriver driver;
		private string baseUrl;
		private By loginfield = By.Id("username");
		private By passwordfield = By.Id("password");
		private By loginbutton = By.Name("login");
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");
		private string configValue = ConfigurationSettings.AppSettings["browser"];

	 [TestInitialize]
		public void SetUp( )
		{
			this.driver = driver;

			if ("ff".Equals(this.configValue))
			{
				var service = FirefoxDriverService.CreateDefaultService();
				this.driver = new FirefoxDriver(service);
			}


			else
			{
				ChromeOptions option = new ChromeOptions();
				option.AddArgument("disable-infobars");
				this.driver = new ChromeDriver(option);


			}

			this.baseUrl = "http://icerow.com/";
			this.driver.Navigate().GoToUrl(baseUrl);
			this.driver.Manage().Window.Maximize();
		}

		[TestMethod]
		public void SignIn()
		{
			//Assert.AreEqual(driver.Title, "icerow - Redmine");
			isElementVisible(loginfield);
			this.driver.FindElement(loginfield).Click();//click signup element
			this.driver.FindElement(loginfield).SendKeys("alyapine");
			isElementVisible(passwordfield);
			this.driver.FindElement(passwordfield).Click();//click signup element
			this.driver.FindElement(passwordfield).SendKeys("3psdpsdpsd3");
			isElementVisible(loginbutton);
			this.driver.FindElement(loginbutton).Click();//click signup element
			isElementVisible(projectselement);
			this.driver.FindElement(projectselement).Click();//click signup element
			isElementVisible(newprojectelement);
			this.driver.FindElement(newprojectelement).Click();//click signup element

		}


		 

		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
