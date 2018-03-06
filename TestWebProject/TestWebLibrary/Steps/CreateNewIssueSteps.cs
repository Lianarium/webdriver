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
	public class CreateNewIssueSteps:BaseStep
	{

	    public void GoToProjectsPage()//create navigation manager
	    {

	        ProjectsPage = HomePage.ClickProjectLink();

	    }

        public void GoToIssuesPage()
		{
			IssuesPage = ProjectsPage.ClickToViewIssues();
		}

		public void CreateNewIssue(Issue issue)
		{

			NewIssuePage = IssuesPage.ClickToCreateNewIssuePage().EnterSubject(issue.Subject).ChooseProject();
			string prj =  NewIssuePage.prjname;
			NewIssuePage = NewIssuePage.CreateTracker().ChooseIssuePriority().ChooseIssueStatus().CreateProjectAndContinue();
			//return ActivityPage.ReturnNewIssueNote();

		}

	    public string GetIssueNote()
	    {

	        ActivityPage = NewIssuePage.GoToProjectsPage().ViewOverallactivity();
	        string text =  ActivityPage.ReturnNewIssueNote();
	        return text;

	    }
	}
}
