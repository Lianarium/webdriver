using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebLibrary.Utils;

namespace TestWebLibrary.PageObjects
{
	public class ActivityPage : BasePage
	{
		private static readonly By activitylabel = By.XPath("//h2"); //unique element to check the page
	    private readonly BaseElement issueprojectnote = new BaseElement(By.XPath("//*[@class='project']"));
		public ActivityPage():base(activitylabel, "Activity")
		{


		}

	    public string ReturnNewIssueNote()
		{
		    var attribute = issueprojectnote.Text;
		    return attribute;
		}


	}
}
