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
using TestWebLibrary.Models;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Utils;

namespace TestWebProject 
{
	public class HomePage : BasePage
	{
		 
		private static readonly By homelabel = By.XPath("//h2");//unique element to check the page
		private readonly BaseElement projectelement = new BaseElement(By.XPath("//*[@class='projects']"));
	


		public HomePage():base(homelabel, "Home")
		{
			 
		}

		
		public ProjectsPage ClickProjectLink()
		{
			this.projectelement.Click();
		    return new ProjectsPage();
		}

	
		 
	}
}
 
