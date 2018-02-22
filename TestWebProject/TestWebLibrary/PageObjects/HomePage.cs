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
	public class HomePage
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/";
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");
		private By viewallissueselement = By.LinkText("View all issues");
		private By overallactivityelement = By.LinkText("Overall activity");
		private By homepagetitleframe = By.Id("content");

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}

		public void GoToHomePage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void ClickprojectsLink()
		{
			isElementVisible(projectselement);
			this.driver.FindElement(projectselement).Click();
		}

		public void CreateNewProject()
		{
			isElementVisible(newprojectelement);
			this.driver.FindElement(newprojectelement).Click();
		}

		public void ViewAllIssues()
		{
			isElementVisible(viewallissueselement);
			this.driver.FindElement(viewallissueselement).Click();
		}

		public void ViewOverallactivity()
		{
			isElementVisible(overallactivityelement);
			this.driver.FindElement(overallactivityelement).Click();
		}

		public void ValidateHomePage()
		{

			Assert.AreEqual(this.driver.FindElement(homepagetitleframe).Text, "Home");
		}


		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
 
