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

	     
		public void CreateNewIssue(Issue issue)
		{

			NewIssuePage = IssuesPage.ClickToCreateNewIssuePage().EnterSubject(issue.Subject).ChooseProject();
			string prj =  NewIssuePage.prjname;
			NewIssuePage = NewIssuePage.CreateTracker().ChooseIssuePriority().ChooseIssueStatus().CreateProjectAndContinue();
			 

		}

	    public Issue GetIssueNote()
	    {

			ActivityPage = NewIssuePage.GoToProjectsPage().ViewOverallactivity();
			Issue issue = new Issue("subj");
	        issue =  ActivityPage.ReturnNewIssueNote(issue);
	        return issue;

	    }

		public bool IsTrue()
		{
			return ActivityPage.IsPresentNote();
		}

		public string Text()
		{
			return ActivityPage.Notetext();
		}

		public string IssueNumber()
		{
			return NewIssuePage.GetIssueNumber();
		}
	}

}
