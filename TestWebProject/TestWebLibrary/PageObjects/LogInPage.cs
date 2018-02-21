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
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace TestWebProject
{
	 
	public class LogInPage
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/";
		private By loginfield = By.Id("username");
		private By passwordfield = By.Id("password");
		private By loginbutton = By.Name("login");
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");
		private string configValue = ConfigurationSettings.AppSettings["browser"];

		public LogInPage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}


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

		public void GoToSignInPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void FillLoginField(string login)
		{
			isElementVisible(loginfield);
			this.driver.FindElement(loginfield).Click(); 
			this.driver.FindElement(loginfield).SendKeys("alyapine");
		}

		public void FillPasswordField(string password)
		{
			isElementVisible(passwordfield);
			this.driver.FindElement(passwordfield).Click(); 
			this.driver.FindElement(passwordfield).SendKeys("3psdpsdpsd3");
		}

		public void ClickToLogIn()
		{
			isElementVisible(loginbutton);
			this.driver.FindElement(loginbutton).Click(); 
		}

		public void Validate()
		{

			Assert.Fail( );
		}

		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
