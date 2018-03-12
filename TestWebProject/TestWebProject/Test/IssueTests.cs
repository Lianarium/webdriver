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
        public void NewIssueTest()

        {

            string IssueSubj = ConfigManager.IssueSubject + Randomiser.GetRandomString(5);
            Issue issue = new Issue(IssueSubj);
            CreateNewIssueSteps testcase = new CreateNewIssueSteps();
            BaseStep.Navmanager.GoToProjectsPage();
            BaseStep.Navmanager.GoToIssuesPage();

            testcase.CreateNewIssue(issue);
			BaseStep.Navmanager.GoToProjectsPage();
			// Assert.AreEqual(null, BaseStep.Navmanager.GoToActivityPage().Notetext());
			Assert.IsTrue(BaseStep.Navmanager.GoToActivityPage().Notetext().Contains(IssueSubj));
	        //Assert.AreEqual(IssueSubj, BaseStep.Navmanager.GoToActivityPage().Notetext());

			//Assert.AreEqual(ConfigManager.ProjectName, testcase.GetIssueNote().Subject);


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
