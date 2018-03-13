using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.Models;
using TestWebLibrary.Utils;

namespace TestWebLibrary.PageObjects
{
	public class NewIssuePage : BasePage
	{

	    private static readonly By newissuelabel = By.XPath("//h2");
        private readonly BaseElement issueprojectelement = new BaseElement(By.XPath("//*[@id='issue_project_id']/option[2]"));
		private readonly BaseElement trackerelement = new BaseElement(By.XPath("//*[@id='issue_tracker_id']/option[1]")); 
        private readonly BaseElement issuesubjectfield = new BaseElement(By.XPath("//*[@id='issue_subject']")); 
		private readonly BaseElement issuestatus = new BaseElement(By.XPath("//*[@id='issue_status_id']/option[1]")); 
		private readonly BaseElement issuepriority = new BaseElement(By.XPath("//*[@id='issue_priority_id']/option[3]"));
	    private readonly BaseElement createbutton = new BaseElement(By.XPath("//*[@name = 'commit']"));
	    private readonly BaseElement createandcontinuebutton = new BaseElement(By.XPath("//*[@name = 'continue']"));
	    private readonly BaseElement projectelement = new BaseElement(By.XPath("//*[@class='projects']"));
		private readonly BaseElement issuewascreated = new BaseElement(By.XPath("//*[@class='flash notice']//*"));

		//private readonly BaseElement flashnotice = new BaseElement(By.XPath("//*[@id='flash_notice']//*[@title='some_valid_subj1']"));
		public string prjname;

		 
		 
        //private readonly string newissuesubject = ConfigManager.IssueSubject;
        
        public NewIssuePage():base (newissuelabel, "New issue")
		{
			 
		}

		 
		public NewIssuePage ChooseProject()
		{
			 this.issueprojectelement.Click();
             prjname = this.issueprojectelement.GetText();
             return new NewIssuePage();
              
		}



	    public string GetProjectName()
	    {
            return  this.issueprojectelement.GetText();
	    }

		public NewIssuePage CreateTracker()
		{
		   this.trackerelement.Click();
		   return  new NewIssuePage();

		}

		public NewIssuePage EnterSubject(string subject)
		{        
			 this.issuesubjectfield.Click();
             this.issuesubjectfield.SendKeys(subject);
			 return new NewIssuePage();
		}

		public NewIssuePage ChooseIssueStatus()
		{
			 this.issuestatus.Click();
			 return new NewIssuePage();
		}

		public NewIssuePage ChooseIssuePriority()
		{
			 this.issuepriority.Click();
			 return new NewIssuePage();
		}


	    public void Create()
	    {
	        this.createbutton.Click();
	    }

	    public NewIssuePage CreateProjectAndContinue()
	    {
	        this.createandcontinuebutton.Click();
	        return new NewIssuePage();
	    }

	    public ProjectsPage GoToProjectsPage()
	    {
            this.projectelement.Click();
	        return new ProjectsPage();
	    }

		public string GetIssueNumber()
		{
			string issuenumbersharp = issuewascreated.GetText();
			string issuenumber = issuenumbersharp.Trim(new Char[] {' ', '#'});
			return issuenumber;
		}

	    public void CheckIsFlashNoticeDisplayed(string title)
	    {
            
	    }

    }
}
