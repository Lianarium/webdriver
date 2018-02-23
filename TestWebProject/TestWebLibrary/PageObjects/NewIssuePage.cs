using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.PageObjects
{
	public class NewIssuePage : BasePage
	{
		private IWebDriver driver;
		private string baseUrl = "http://icerow.com/issues/new";
		private By issueprojectelement = By.Id("issue_project_id");
		private By trackerelement = By.Id("issue_tracker_id");
        private By issuesubjectfield = By.Id("issue_subject");
		private By issuestatus = By.Id("issue_status_id");
		private By issuepriority = By.Id("issue_priority_id");

		public NewIssuePage(IWebDriver driver)
		{
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}

		public void GoToNewIssuePage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void ChooseProject()
		{
			isElementVisible(this.driver, issueprojectelement);
			this.driver.FindElement(issueprojectelement).Click();
		}

		public void CreateTracker()
		{
			isElementVisible(this.driver, trackerelement);
			this.driver.FindElement(trackerelement).Click();
		}

		public void EnterSubject()
		{
			isElementVisible(this.driver, issuesubjectfield);
			this.driver.FindElement(issuesubjectfield).Click();
			this.driver.FindElement(issuesubjectfield).SendKeys("some_subject");//remove harcode!
		}

		public void ChooseIssueStatus()
		{
			isElementVisible(this.driver, issuestatus);
			this.driver.FindElement(issuestatus).Click();
		}

		public void ChooseIssuePriority()
		{
			isElementVisible(this.driver, issuepriority);
			this.driver.FindElement(issuepriority).Click();
		}


		public void Validate()
		{

			Assert.AreEqual(2, 2);
		}

 
	}
}
