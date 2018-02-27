using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Utils;
using TestWebProject;

namespace TestWebLibrary.Steps
{
	public class Steps//PageObjects Wrapper
	{
		public static HomePage LogIn(string login, string password)
		{
			LogInPage loginpage = new LogInPage();
			HomePage homepage = loginpage.FillLoginField(login).FillPasswordField(password).ClickToLogIn();
			return homepage;  
		}

		public static void GoToProjectsPage()
		{
			 
		}
	}
}
