﻿using System;
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
	public class LogInSteps : BaseStep//PageObjects Wrapper
	{
	     

	    public LogInSteps() : base()
	    {

	    }

        public HomePage LogIn(string login, string password)
		{
		    HomePage = LoginPage.FillLoginField(login).FillPasswordField(password).ClickToLogIn();
			return HomePage;  
		}

    }
}
