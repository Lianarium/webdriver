
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
    [Parallelizable(ParallelScope.All)]
    public class SmokeTests : BaseTest
    {


        [Test]
        public void LogInTest()
        {
	        SetUp.LoginCondition = true;
			LogInSteps step = new LogInSteps();
            step.LogIn(ConfigManager.ConfigLogin, ConfigManager.ConfigPassword);
        }

     

        [Test]
        public void NewProjectTest()
        {
	        string projectname = ConfigManager.ProjectName + Randomiser.GetRandomString(5);
			Project project = new Project(projectname);
	        CreateNewProjectSteps testcase = new CreateNewProjectSteps();
			testcase.GoToProjectsPage();
            testcase.CreateNewProject(project);
        }

       
        
    }
}
