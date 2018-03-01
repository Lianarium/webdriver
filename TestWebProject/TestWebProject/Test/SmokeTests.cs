
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using log4net.Config;
using TestWebProject;
using NUnit.Framework;
using TestWebLibrary.Models;
using TestWebLibrary.PageObjects;
using TestWebLibrary.Steps;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    [TestFixture]
    public class SmokeTests : BaseTest
    {


        [Test]
        public void LogInTest()
        {
			LogInPageSteps step = new LogInPageSteps();
            step.LogIn(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
        }

        [Test]
        public void HomePageTest()
        {
			LogInPageSteps step = new LogInPageSteps();
            step.GoToProjectsPage();
			Assert.AreEqual();
        }

        [Test]
        public void NewProjectTest()
        {
	        string projectname = ConfigManager.ProjectName + Randomiser.GetRandomString(5);
			Project project = new Project(projectname);
	        LogInPageSteps step = new LogInPageSteps();
			step.GoToProjectsPage();
            step.CreateNewProject(project);
        }

        [Test]
        public void NewIssueTest()

        {
			
            string IssueSubj = ConfigManager.IssueSubject + Randomiser.GetRandomString(5);
	        Issue issue = new Issue(IssueSubj);
			LogInPageSteps.GoToProjectsPage();
			LogInPageSteps.GoToIssuesPage();
			LogInPageSteps.CreateNewIssue(issue);

        }

        [Test]
        public void ActivityTest()
        {
			LogInPageSteps.GoToProjectsPage();
	        LogInPageSteps.GoToActivityPage();
        }
    }
}
