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
		 
		
		private static readonly By login = By.Id("username"); //unique element to check the page
		private readonly BaseElement loginfield = new BaseElement(By.XPath("//*[@id='username']"));
		private readonly BaseElement passwordfield = new BaseElement(By.XPath("//*[@id='password']"));
		private readonly BaseElement loginbutton = new BaseElement(By.XPath("//*[@name='login']"));

		//private readonly string loginkey = ConfigManager.ConfigLogin;
        //private readonly string passwordkey = ConfigManager.ConfigPassword;
         
		

		public LogInPage():base(login, "Log in page")
		{

			
		}

		 public LogInPage FillLoginField(string loginkey)
		{
			this.loginfield.WaitForElementIsVisible();
			this.loginfield.Click();
			this.loginfield.SendKeys(loginkey);
			return new LogInPage();
		}

		public LogInPage FillPasswordField(string passwordkey)
		{
			this.passwordfield.WaitForElementIsVisible();
			this.passwordfield.Click();
			this.passwordfield.SendKeys(passwordkey);
			return new LogInPage();
		}

		public HomePage ClickToLogIn()
		{
			this.loginbutton.WaitForElementIsVisible();
			this.loginbutton.Click();
			return new HomePage();
		}



		
	}
}
