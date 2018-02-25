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
	 
	public class LogInPage : BasePage
	{
		 
		private string baseUrl = ConfigManager.ConfigUrl;
		private static readonly By loginfield = By.Id("username");
        private static readonly By passwordfield = By.Id("password");
		private static readonly By loginbutton = By.Name("login");
        private static readonly By projectselement = By.ClassName("projects");
		private static readonly By newprojectelement = By.LinkText("New project");
		

		public LogInPage():base(loginfield, "Log in page" )
		{
			 
			 
		}


	
		public void GoToLogInPage()
		{
			 
		}

		/*public void FillLoginField(string login)
		{
			isElementVisible(this.driver, loginfield);
			this.driver.FindElement(loginfield).Click(); 
			this.driver.FindElement(loginfield).SendKeys(login); 
		}

		public void FillPasswordField(string password)
		{
			isElementVisible(this.driver, passwordfield);
			this.driver.FindElement(passwordfield).Click(); 
			this.driver.FindElement(passwordfield).SendKeys(password); 
		}

		public HomePage ClickToLogIn()
		{
			isElementVisible(this.driver, loginbutton);
			this.driver.FindElement(loginbutton).Click();
		    return new HomePage(driver);//go to homepage
		}*/

		
	}
}
