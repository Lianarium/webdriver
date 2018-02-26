
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
using log4net.Config;
using TestWebProject;
using NUnit.Framework;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
	[TestFixture]
    public class LoginTest : BaseTest
	{
		 

		[Test]
		public void Test1()
		{
			
			var loginpage = new LogInPage();
			loginpage.FillLoginField();
			loginpage.FillPasswordField();
			HomePage homepage = loginpage.ClickToLogIn();
			homepage.ClickProjectLink();
			homepage.ClickToCreateNewProject();
		}

		[Test]
		public void Test2()
		{
		  
		}
	}
}
