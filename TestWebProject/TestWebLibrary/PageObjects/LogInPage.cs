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
		private IWebDriver driver;
		private string baseUrl = ConfigManager.ConfigUrl;
		private By loginfield = By.Id("username");
		private By passwordfield = By.Id("password");
		private By loginbutton = By.Name("login");
		private By projectselement = By.ClassName("projects");
		private By newprojectelement = By.LinkText("New project");
		

		public LogInPage(IWebDriver driver) 
		{
			 
			this.driver = driver;
			this.driver.Manage().Window.Maximize();
			PageFactory.InitElements(driver, this);
		}


	
		public void GoToLogInPage()
		{
			driver.Navigate().GoToUrl(baseUrl);
		}

		public void FillLoginField(string login)
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
		}

		
	}
}
