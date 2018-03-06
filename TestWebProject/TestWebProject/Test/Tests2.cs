using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebLibrary.Models;
using TestWebLibrary.Steps;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Tests2 : BaseTest
    {
        [Test]
        public void NewIssueTest()

        {
            string IssueSubj = ConfigManager.IssueSubject + Randomiser.GetRandomString(5);
            Issue issue = new Issue(IssueSubj);
            CreateNewIssueSteps testcase = new CreateNewIssueSteps();
            testcase.GoToProjectsPage();
            testcase.GoToIssuesPage();
            testcase.CreateNewIssue(issue);
            
            Assert.AreEqual(ConfigManager.ProjectName, testcase.GetIssueNote());

        }

        [Test]
        public void ActivityTest()
        {
            ViewActivitySteps testcase = new ViewActivitySteps();
            testcase.GoToProjectsPage();
            testcase.GoToActivityPage();
             
        }
    }
}
