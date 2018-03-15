using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebLibrary;
using TestWebLibrary.Models;
using TestWebLibrary.Steps;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class IssueTests : BaseTest
    {
        [Test]
        public void NewIssuePresenceTest()
        {
			//arrange
            string IssueSubj = TestData.IssueSubject + Randomiser.GetRandomString(5);
            Issue issue = new Issue(IssueSubj, null);//model of issue to be created
			Note note = new Note(null);//model of created issue note on activity page
            CreateNewIssueSteps testcase = new CreateNewIssueSteps();

			//act
            BaseStep.Navmanager.GoToProjectsPage();
            BaseStep.Navmanager.GoToIssuesPage();
	        issue.Number = testcase.CreateNewIssue(issue).GetIssueNumber();      
	        Logger.Log.Info("NEW ISSUE NUMBER: " + issue.Number);
			BaseStep.Navmanager.GoToProjectsPage();
	        note = BaseStep.Navmanager.GoToActivityPage().GetCreatedIssueNote(issue.Number);

			//assert
			Assert.IsTrue(note.Text.Contains(IssueSubj)); 
	
		}
/*
        [Test]
        public void ActivityTest()
        {
            ViewActivitySteps testcase = new ViewActivitySteps();
            BaseStep.Navmanager.GoToProjectsPage();
            Assert.AreEqual(null, BaseStep.Navmanager.GoToActivityPage().Notetext());
	        Assert.IsTrue(BaseStep.Navmanager.GoToActivityPage().Notetext().Contains());
		}*/
    }
}
