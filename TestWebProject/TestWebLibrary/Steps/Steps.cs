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
	    private static LogInPage loginPage = new LogInPage();
	    private static HomePage homePage = new HomePage();
	    private static ProjectsPage projectsPage = new ProjectsPage();
	    private static NewProjectPage newprojectPage = new NewProjectPage();
	    private static IssuesPage issuesPage = new IssuesPage();
	    private static ActivityPage activityPage = new ActivityPage();


        public static HomePage LogIn(string login, string password)
		{
		    homePage = loginPage.FillLoginField(login).FillPasswordField(password).ClickToLogIn();
			return homePage;  
		}

		public static void GoToProjectsPage()
		{

		   projectsPage =  homePage.ClickProjectLink();

		}

	    public static void CreateNewProject()
	    {
	        newprojectPage = projectsPage.ClickToCreateNewProject();
	    }

	    public static void GoToIssuesPage()
	    {
	        issuesPage = projectsPage.ClickToViewIssues();
        }

	    public static void GoToActivityPage()
	    {
	        activityPage = projectsPage.ViewOverallactivity();
	    }

    }
}
