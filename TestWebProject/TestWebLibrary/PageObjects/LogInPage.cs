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
		private readonly BaseElement loginfield = new BaseElement(By.Id("username"));
		private readonly BaseElement passwordfield = new BaseElement(By.Id("password"));
		private readonly BaseElement loginbutton = new BaseElement(By.Name("login"));

		private readonly string loginkey = ConfigManager.ConfigLogin;
        private readonly string passwordkey = ConfigManager.ConfigPassword;
        //private static readonly BaseElement projectselement = new BaseElement(By.ClassName("projects")); 
		//private static readonly By newprojectelement = By.LinkText("New project");
		

		public LogInPage():base(login, "Log in page")
		{

			
		}

		 public void FillLoginField()
		{
			this.loginfield.Click();
			this.loginfield.SendKeys(loginkey);
		}

		public void FillPasswordField()
		{
			this.passwordfield.Click();
			this.passwordfield.SendKeys(passwordkey);
		}

		public HomePage ClickToLogIn()
		{
			this.loginbutton.Click();
			return new HomePage();
		}

		
	}
}
