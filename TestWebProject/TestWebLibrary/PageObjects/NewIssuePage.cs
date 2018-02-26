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
	 
		private static readonly By issueprojectelement = By.Id("issue_project_id");
		private readonly BaseElement trackerelement = new BaseElement(By.Id("issue_tracker_id")); 
        private readonly BaseElement issuesubjectfield = new BaseElement(By.Id("issue_subject")); 
		private readonly BaseElement issuestatus = new BaseElement(By.Id("issue_status_id")); 
		private readonly BaseElement issuepriority = new BaseElement(By.Id("issue_priority_id")); 

		public NewIssuePage():base (issueprojectelement, "New Issue Page")
		{
			 
		}

		public void GoToNewIssuePage()
		{
			 
		}

		public void ChooseProject()
		{
			 
		}

		public void CreateTracker()
		{
		 
		}

		public void EnterSubject()
		{
			 
		}

		public void ChooseIssueStatus()
		{
			 
		}

		public void ChooseIssuePriority()
		{
			 
		}


		public void Validate()
		{

			Assert.AreEqual(2, 2);
		}

 
	}
}
