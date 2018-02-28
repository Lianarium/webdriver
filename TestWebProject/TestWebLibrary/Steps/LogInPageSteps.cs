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
	public class LogInPageSteps//PageObjects Wrapper
	{
	    private static LogInPage _loginPage = new LogInPage();
	    private static HomePage _homePage = new HomePage();
	    private static ProjectsPage _projectsPage = new ProjectsPage();
	    private static NewProjectPage _newprojectPage = new NewProjectPage();
	    private static IssuesPage _issuesPage = new IssuesPage();
		private static NewIssuePage _newissuePage = new NewIssuePage();
		private static ActivityPage _activityPage = new ActivityPage();


        public static HomePage LogIn(string login, string password)
		{
		    _homePage = _loginPage.FillLoginField(login).FillPasswordField(password).ClickToLogIn();
			return _homePage;  
		}

		public static void GoToProjectsPage()
		{

		   _projectsPage =  _homePage.ClickProjectLink();

		}

	    public static void CreateNewProject(string projectname, string projectid)
	    {
		    _newprojectPage = _projectsPage.ClickToCreateNewProject().EnterProjectName(projectname).CreateProjectAndContinue();
	    }

	    public static void GoToIssuesPage()
	    {
	        _issuesPage = _projectsPage.ClickToViewIssues();
        }

		public static void CreateNewIssue(string subject)
		{
			_newissuePage = _issuesPage.ClickToCreateNewIssuePage().EnterSubject(subject).ChooseProject().CreateTracker()
				.ChooseIssuePriority().ChooseIssueStatus();

		}

	    public static void GoToActivityPage()
	    {
	        _activityPage = _projectsPage.ViewOverallactivity();
	    }

    }
}
