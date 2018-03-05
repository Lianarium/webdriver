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
	public class CreateNewProjectSteps
	{
		private LogInPage _loginPage = new LogInPage();
		private HomePage _homePage = new HomePage();
		private ProjectsPage _projectsPage = new ProjectsPage();
		private NewProjectPage _newprojectPage = new NewProjectPage();
		private IssuesPage _issuesPage = new IssuesPage();
		private NewIssuePage _newissuePage = new NewIssuePage();
		private ActivityPage _activityPage = new ActivityPage();


		public void GoToProjectsPage()
		{

			_projectsPage = _homePage.ClickProjectLink();

		}

		public void CreateNewProject(Project project)
		{
			_newprojectPage = _projectsPage.ClickToCreateNewProject().EnterProjectName(project.Name).CreateProjectAndContinue();
		}


	}
}
