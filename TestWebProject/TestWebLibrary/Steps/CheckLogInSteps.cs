using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebLibrary.Models;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Utils;
using TestWebProject;

namespace TestWebLibrary.Steps
{
	public class CheckLogInSteps : BaseStep//PageObjects Wrapper
	{
	     

        public HomePage LogIn(User user)
		{
		    HomePage = LoginPage.FillLoginField(user.Login).FillPasswordField(user.Password).ClickToLogIn();
			return HomePage;  
		}

		
		public HomePage GetExpectedHomePage()
		{
			 HomePage homepage = new HomePage();
			 return homepage;
		}
    }
}
