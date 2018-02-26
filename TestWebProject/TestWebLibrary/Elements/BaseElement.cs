using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestWebLibrary.BrowserWork;

namespace TestWebLibrary.PageObjects
{
   public class BaseElement:IWebElement
   {
       protected string Name;
       protected By Locator;
       protected IWebElement Element;
       public string TagName { get; }
       public string Text { get; }
       public bool Enabled { get; }
       public bool Selected { get; }
       public Point Location { get; }
       public Size Size { get; }
       public bool Displayed { get; }

	   private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	    
		public BaseElement(By locator)
       {
           this.Locator = locator;
       }
       
       public BaseElement(By locator, string name)
       {
           this.Locator = locator;
           this.Name = name == "" ? this.GetText() : name;
       }

       public IWebElement GetElement()
       {
           this.Element = Browser.GetDriver().FindElement(this.Locator);
           return this.Element;
       }

        private string GetText()
        {
            this.WaitForElementIsVisible();
            return this.Element.Text;
        }

       public void WaitForElementIsVisible()
       {
           new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(Browser.TimeoutForElement)).Until(ExpectedConditions.ElementIsVisible(this.Locator));
        }

       public IWebElement FindElement(By @by)
       {
           throw new NotImplementedException();
       }

       public ReadOnlyCollection<IWebElement> FindElements(By @by)
       {
           throw new NotImplementedException();
       }

       public void Clear()
       {
           throw new NotImplementedException();
       }

       public void SendKeys(string text)
       {
			this.WaitForElementIsVisible();
	        Browser.GetDriver().FindElement(this.Locator).SendKeys(text);
	        this.log.Info("Text input: "  + text);
       }

       public void Submit()
       {
           throw new NotImplementedException();
       }

       public void Click()
       {
            this.WaitForElementIsVisible();
		    Browser.GetDriver().FindElement(this.Locator).Click();
            this.log.Info("Clicked " + " element");
       }

       public string GetAttribute(string attributeName)
       {
           throw new NotImplementedException();
       }

       public string GetProperty(string propertyName)
       {
           throw new NotImplementedException();
       }

       public string GetCssValue(string propertyName)
       {
           throw new NotImplementedException();
       }

       
   }
}

