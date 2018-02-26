using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.Utils;

namespace TestWebLibrary.PageObjects
{
	public class NewIssuePage : BasePage
	{

	    private static readonly By newissuelabel = By.XPath("//h2");
        private readonly BaseElement issueprojectelement = new BaseElement(By.XPath("//*[@id='issue_project_id']"));
		private readonly BaseElement trackerelement = new BaseElement(By.XPath("//*[@id='issue_tracker_id']")); 
        private readonly BaseElement issuesubjectfield = new BaseElement(By.XPath("//*[@id='issue_subject']")); 
		private readonly BaseElement issuestatus = new BaseElement(By.XPath("//*[@id='issue_status_id']")); 
		private readonly BaseElement issuepriority = new BaseElement(By.XPath("//*[@id='issue_priority_id']"));
	    private readonly BaseElement createbutton = new BaseElement(By.XPath("//*[@name = 'commit']"));
	    private readonly BaseElement createandcontinuebutton = new BaseElement(By.XPath("//*[@name = 'continue']"));

        private readonly string newissuesubject = ConfigManager.IssueSubject;

        public NewIssuePage():base (newissuelabel, "New issue")
		{
			 
		}

		 
		public void ChooseProject()
		{
			 this.issueprojectelement.Click();
              
		}

		public void CreateTracker()
		{
		   this.trackerelement.Click();

		}

		public void EnterSubject()
		{
			 this.issuesubjectfield.Click();
             this.issuesubjectfield.SendKeys(newissuesubject);
		}

		public void ChooseIssueStatus()
		{
			 this.issuestatus.Click();
		}

		public void ChooseIssuePriority()
		{
			 this.issuepriority.Click();
		}


		 

 
	}
}
