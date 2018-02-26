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

namespace TestWebLibrary.PageObjects
{
	class NewProjectPage : BasePage
	{
		private static readonly By newproject = By.XPath("//h2");
		private readonly BaseElement namefield = new BaseElement(By.Id("project_name"));
		private readonly BaseElement identifierfield = new BaseElement(By.Id("project_name"));
		private readonly BaseElement createbutton = new BaseElement(By.XPath("//*[@name = 'create']"));
		private readonly BaseElement createandcontinuebutton = new BaseElement(By.XPath("//*[@name = 'continue']"));

		public NewProjectPage():base(newproject,"New Project Page")
		{
			 
		}

		 

		public void EnterProjectName()
		{
			 
		}

		public void EnterProjectIdentifier()
		{
			 
		}


		public void Create()
		{
			 
		}

		public void CreateProjectAndContinue()
		{
			 
		}

		 

		 
	}
}
