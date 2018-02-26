using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebLibrary.PageObjects
{
	public class ActivityPage : BasePage
	{
		private static readonly By activitylabel = By.XPath("//h2"); //unique element to check the page

		public ActivityPage():base(activitylabel, "Activity Page")
		{


		}



	}
}
