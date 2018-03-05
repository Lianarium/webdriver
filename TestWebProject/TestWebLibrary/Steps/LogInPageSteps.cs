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
	public class LogInPageSteps//PageObjects Wrapper
	{
	    private  LogInPage _loginPage = new LogInPage();
	    private  HomePage _homePage = new HomePage();
	    private  ProjectsPage _projectsPage = new ProjectsPage();
	    private  NewProjectPage _newprojectPage = new NewProjectPage();
	    private  IssuesPage _issuesPage = new IssuesPage();
		private  NewIssuePage _newissuePage = new NewIssuePage();
		private  ActivityPage _activityPage = new ActivityPage();


	 
        public HomePage LogIn(string login, string password)
		{
		    _homePage = _loginPage.FillLoginField(login).FillPasswordField(password).ClickToLogIn();
			return _homePage;  
		}

		public void GoToProjectsPage()
		{

		   _projectsPage =  _homePage.ClickProjectLink();
			 
		}

		public  string  ProjectsPageTitle()
		{

			_projectsPage = _homePage.ClickProjectLink();
			return _projectsPage.GetProjectsLabelText();

		}

		 


	    public  void GoToActivityPage()
	    {
	        _activityPage = _projectsPage.ViewOverallactivity();
	    }

    }
}
