using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.Utils;

namespace TestWebLibrary.PageObjects
{
	public class NewProjectPage : BasePage
	{
		private static readonly By newproject = By.XPath("//h2");
		private readonly BaseElement namefield = new BaseElement(By.XPath("//*[@id='project_name']"));

        private readonly BaseElement identifierfield = new BaseElement(By.Id("//*[@id='project_identifier']"));
		private readonly BaseElement createbutton = new BaseElement(By.XPath("//*[@name = 'create']"));
		private readonly BaseElement createandcontinuebutton = new BaseElement(By.XPath("//*[@name = 'continue']"));
	    private readonly string projectname = ConfigManager.ProjectName;
	    private readonly string projectid = ConfigManager.ProjectIdentifier;
        public NewProjectPage():base(newproject,"New Project Page")
		{
			 
		}

		 

		public void EnterProjectName()
		{
		    this.namefield.Click();
		    this.namefield.SendKeys(projectname);
        }

		public void EnterProjectIdentifier()
		{
		    this.identifierfield.Click();
		    this.identifierfield.SendKeys(projectid);
        }


		public void Create()
		{
		    this.createbutton.Click();
	    }

		public void CreateProjectAndContinue()
		{
			 this.createandcontinuebutton.Click();
		}

		 

		 
	}
}
