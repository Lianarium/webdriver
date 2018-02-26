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
using TestWebLibrary.PageObjects;
using TestWebLibrary.Utils;

namespace TestWebProject 
{
	public class HomePage : BasePage
	{
		 
		private static readonly By projects = By.ClassName("projects");//unique element to check the page
		private readonly BaseElement projectelement = new BaseElement(By.ClassName("projects"));
		private readonly BaseElement newprojectelement = new BaseElement(By.LinkText("New project")); 
		private readonly BaseElement viewallissueselement = new BaseElement(By.LinkText("View all issues")); 
		private readonly BaseElement overallactivityelement = new BaseElement(By.LinkText("Overall activity"));
		private readonly BaseElement homepagetitleframe = new BaseElement(By.Id("content")); 

		public HomePage():base(projects, "Home Page")
		{
			 
		}

	

		public void ClickProjectLink()
		{
			this.projectelement.Click();
	    }

		public void ClickToCreateNewProject()
		{
			 this.newprojectelement.Click();
		}

		public void ViewOverallactivity()
		{
			 this.overallactivityelement.Click();
		}

		public void ValidateHomePage()
		{

			Assert.AreEqual(this.homepagetitleframe.Text, "Home");
		}


		 
	}
}
 
