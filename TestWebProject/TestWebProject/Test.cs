using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace TestWebProject
{
	[TestClass]
    public class Test
    {

		private IWebDriver driver;
		private string baseUrl;
		private By signUp = By.XPath("//a[text()='sign up']");
		private By userName = By.Name("newinfo[name]");
		private string configValue = ConfigurationSettings.AppSettings["browser"];

		[TestInitialize]
		public void setupTest()
		{

			if ("ff".Equals(this.configValue))
			{
				var service = FirefoxDriverService.CreateDefaultService();
				this.driver = new FirefoxDriver(service);
			}


			else
			{
				ChromeOptions option = new ChromeOptions();
				option.AddArgument("disable-infobars");
				this.driver = new ChromeDriver(option);


			}

			this.baseUrl = "https://www.myfonts.com/";
			this.driver.Navigate().GoToUrl(baseUrl);
			this.driver.Manage().Window.Maximize();
		}
	 
		[TestMethod]
		public void TestLogin()
		{
			this.driver.FindElement(By.Id("headerLoginUsername")).Click();
			this.driver.SwitchTo().Frame(this.driver.FindElement(By.ClassName("dropdownLoginFrame")));
			isElementVisible(signUp);//check if signup element is visible
			this.driver.FindElement(signUp).Click();//click signup element

			this.driver.SwitchTo().DefaultContent();

			isElementVisible(userName);
			this.driver.FindElement(userName).SendKeys("Lianarium");

			this.driver.FindElement(By.Name("newinfo[emailAddress]")).SendKeys("alyapine@gmail.com");
			this.driver.FindElement(By.Name("newinfo[password]")).SendKeys("homegrowndoll1");
			this.driver.FindElement(By.Name("newinfo[confirmPassword]")).SendKeys("homegrowndoll1");

			this.driver.FindElement(By.XPath("//input[@value='Create Account']")).Click();

			//isElementVisible(By.XPath("//h1[contains(text(), 'Your Acc']"));

		}

		[TestCleanup]
		public void cleanUp()
		{
			this.driver.Close();//close window
			this.driver.Quit();//exit browser
		}

		public void isElementVisible(By element, int timeoutSecs = 10)
		{
			new WebDriverWait(this.driver,TimeSpan.FromSeconds(timeoutSecs)).Until(ExpectedConditions.ElementIsVisible(element));
		}
    }
}
