
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
            Steps.LogIn(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
        }

        [Test]
        public void HomePageTest()
        {
            Steps.GoToProjectsPage();
        }

        [Test]
        public void NewProjectTest()
        {
            Steps.GoToProjectsPage();
            Steps.CreateNewProject();
        }

        [Test]
        public void NewIssueTest()

        {

            Steps.GoToProjectsPage();
            Steps.GoToIssuesPage();

        }

        [Test]
        public void ActivityTest()
        {
            /*LogInPage loginpage = new LogInPage();
            loginpage.FillLoginField();
            loginpage.FillPasswordField();
            HomePage homepage = loginpage.ClickToLogIn();
            ProjectsPage projectspage = homepage.ClickProjectLink();
            ActivityPage activityPage = projectspage.ViewOverallactivity();
            activityPage.CheckIsProjectNotePresent();*/
        }
    }
}
