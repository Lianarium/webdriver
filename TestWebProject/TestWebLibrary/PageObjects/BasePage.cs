using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.Models;

namespace TestWebLibrary.PageObjects
{
	public abstract class BasePage
	{
        protected By TitleLocator;
        protected string Title;
	    public static string TitlePage;
		//private IWebDriver driver;
		protected readonly BaseElement titlelement = new BaseElement(By.XPath("//h2"));//TITLE ELEMENT OF THE PAGE

		protected BasePage(By TitleLocator, string title)
		{
		    this.TitleLocator = TitleLocator;
		    this.Title = TitlePage = title;
			Logger.Log.Info(title + " was opened");
		}

	    public void AssertIsOpened()
	    {
          var label = new BaseElement(this.TitleLocator, this.Title);
	      label.WaitForElementIsVisible();

	    }

		public PageTitle GetTitle()
		{
			PageTitle pageTitle = new PageTitle(titlelement.GetText());
			return pageTitle;
		}

		public void isElementVisible(IWebDriver driver,By element, int timeoutSecs = 10)
		{ 
			new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
	}
}
