
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
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {


        [Test]
        public void LogInTest()
        {

            LogInPage loginpage = new LogInPage();
            loginpage.FillLoginField();
            loginpage.FillPasswordField();
            HomePage homepage = loginpage.ClickToLogIn();
            homepage.ClickProjectLink();
            ProjectsPage projectspage = homepage.ClickProjectLink();
            NewProjectPage newprojectpage = projectspage.ClickToCreateNewProject();
        }

        [Test]
        public void HomePageTest()
        {
            LogInPage loginpage = new LogInPage();
            loginpage.FillLoginField();
            loginpage.FillPasswordField();
            HomePage homepage = loginpage.ClickToLogIn();
            homepage.ClickProjectLink();
            ProjectsPage projectspage = homepage.ClickProjectLink();
            IssuesPage issuesPage = projectspage.ClickToViewIssues();
        }


        [Test]
        public void NewIssueTest()

        {
            LogInPage loginpage = new LogInPage();
            loginpage.FillLoginField();
            loginpage.FillPasswordField();
            HomePage homepage = loginpage.ClickToLogIn();
            //homepage.ClickProjectLink();
            ProjectsPage projectspage = homepage.ClickProjectLink();
            IssuesPage issuesPage = projectspage.ClickToViewIssues();
            NewIssuePage newissuepage = issuesPage.ClickToCreateNewIssuePage();
            newissuepage.ChooseProject();
            newissuepage.CreateTracker();
            newissuepage.EnterSubject();
            newissuepage.ChooseIssueStatus();
            newissuepage.ChooseIssuePriority();

        }

        [Test]
        public void ActivityTest()
        {
            LogInPage loginpage = new LogInPage();
            loginpage.FillLoginField();
            loginpage.FillPasswordField();
            HomePage homepage = loginpage.ClickToLogIn();
            ProjectsPage projectspage = homepage.ClickProjectLink();
            ActivityPage activityPage = projectspage.ViewOverallactivity();
            activityPage.CheckIsNewIssueNotePresent();
        }
    }
}
