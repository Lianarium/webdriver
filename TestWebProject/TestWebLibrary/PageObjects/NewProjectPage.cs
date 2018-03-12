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
		private readonly BaseElement createbutton = new BaseElement(By.XPath("//*[@name = 'commit']"));
		private readonly BaseElement successelement = new BaseElement(By.XPath("//*[@id = 'flash_notice']"));
		private readonly BaseElement errorelementname = new BaseElement(By.XPath("//*[@id = 'errorExplanation']//ul//li"));
		private readonly BaseElement createandcontinuebutton = new BaseElement(By.XPath("//*[@value = 'Create and continue']"));
	    

        public NewProjectPage():base(newproject,"New Project Page")
		{
			 
		}


		public string GetSuccessMessage()
		{
			string message = successelement.GetText();
			return message;
		}

		public string GetErrorMessage()
		{
			string message = errorelementname.GetText();
			return message;
		}

		public bool CheckErrorName()
		{
			return this.errorelementname.Displayed;
		}

		public NewProjectPage EnterProjectName(string projectname)
		{
		    this.namefield.Click();
		    this.namefield.SendKeys(projectname);
			return new NewProjectPage();
        }

	
		public void Create()
		{
		    this.createbutton.Click();
	    }

		public NewProjectPage CreateProjectAndContinue()
		{
			 this.createandcontinuebutton.Click();
			 return new NewProjectPage();
		}

		
		

		 
	}
}
