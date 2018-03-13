using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebLibrary.BrowserWork;
using TestWebLibrary.Models;
using TestWebLibrary.Utils;

namespace TestWebLibrary.PageObjects
{
	public class ActivityPage : BasePage
	{
		private static readonly By activitylabel = By.XPath("//h2"); //unique element to check the page
		private string pathtonote;
		private static readonly BaseElement activityFrame = new BaseElement(By.Id("activity"));
		private readonly List<IWebElement> activitiesList = activityFrame.FindElements(By.XPath("//*[@class='issue me']")).ToList();
	    

		public ActivityPage():base(activitylabel, "Activity")
		{


		}

		public int CountNotes()
		{
			return activitiesList.Count;
		}


		public string GetNotes()
		{
			return activityFrame.GetText();
		}

		public Note GetCreatedIssueNote(string number)
		{
			pathtonote = "//*[@href='/issues/" + number + "']";
			BaseElement issueprojectnote = new BaseElement(By.XPath(pathtonote));
			Note note = new Note(issueprojectnote.GetText());
			return note;
		}
		
	}
}
