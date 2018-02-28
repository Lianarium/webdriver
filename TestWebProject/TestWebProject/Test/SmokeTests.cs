
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
            LogInPageSteps.LogIn(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
        }

        [Test]
        public void HomePageTest()
        {
            LogInPageSteps.GoToProjectsPage();
        }

        [Test]
        public void NewProjectTest()
        {
            LogInPageSteps.GoToProjectsPage();
            LogInPageSteps.CreateNewProject(ConfigManager.ProjectName+Randomiser.GetRandomString(5), ConfigManager.ProjectIdentifier);
        }

        [Test]
        public void NewIssueTest()

        {

            LogInPageSteps.GoToProjectsPage();
			LogInPageSteps.GoToIssuesPage();
			LogInPageSteps.CreateNewIssue(ConfigManager.IssueSubject+Randomiser.GetRandomString(5));

        }

        [Test]
        public void ActivityTest()
        {
             
        }
    }
}
