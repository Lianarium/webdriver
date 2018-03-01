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
		public ActivityPage():base(activitylabel, "Activity Page")
		{


		}


	    public void CheckIsProjectNotePresent()
	    {
		    string projectnote = issueprojectnote.GetText();
            Assert.AreEqual(projectnote, ConfigManager.ProjectName);
	    }

		public void CheckIsNewIssueNoteIsPresent(string name)
		{
		    var attribute = issueprojectnote.GetText();
		    Assert.AreEqual(attribute,name);
		}


	}
}
