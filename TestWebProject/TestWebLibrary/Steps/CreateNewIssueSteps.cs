using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.Models;
using TestWebLibrary.PageObjects;
using TestWebProject;

namespace TestWebLibrary.Steps
{
	public class CreateNewIssueSteps
	{
		private LogInPage _loginPage = new LogInPage();
		private HomePage _homePage = new HomePage();
		private ProjectsPage _projectsPage = new ProjectsPage();
		private NewProjectPage _newprojectPage = new NewProjectPage();
		private IssuesPage _issuesPage = new IssuesPage();
		private NewIssuePage _newissuePage = new NewIssuePage();
		private ActivityPage _activityPage = new ActivityPage();

		public void GoToIssuesPage()
		{
			_issuesPage = _projectsPage.ClickToViewIssues();
		}

		public void CreateNewIssue(Issue issue)
		{

			_newissuePage = _issuesPage.ClickToCreateNewIssuePage().EnterSubject(issue.Subject).ChooseProject();
			string prj = _newissuePage.prjname;
			_activityPage = _newissuePage.CreateTracker().ChooseIssuePriority().ChooseIssueStatus().CreateProjectAndContinue().GoToProjectsPage().ViewOverallactivity();
			_activityPage.CheckIsNewIssueNoteIsPresent(prj);


		}
	}
}
