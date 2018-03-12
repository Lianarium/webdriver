
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
    public class ProjectTests : BaseTest
    {

	    protected string Projectname;
	    protected const string SuccessMessage = "Successful creation.";
	    protected const string ErrorMessage = "Name cannot be blank";

		public ProjectTests()
	    {
		    IsLoginRequired = true;
	    }


	    [SetUp]
	    public void setName()
	    {
		    Projectname = ConfigManager.ProjectName + Randomiser.GetRandomString(5);
		}

        [Test]
        public void NewProjectTestValidProjname()
        {
	        Project project = new Project(Projectname);
	        CreateNewProjectSteps testcase = new CreateNewProjectSteps();
			BaseStep.Navmanager.GoToProjectsPage();
            Assert.AreEqual(testcase.CreateNewProject(project).GetSuccessMessage(), SuccessMessage);
        }

		[Test]
	    public void NewProjectTestEmptyProjname()
	    {
		    Project project = new Project("");
	        CreateNewProjectSteps testcase = new CreateNewProjectSteps();
			BaseStep.Navmanager.GoToProjectsPage();
			Assert.AreEqual(testcase.CreateNewProject(project).GetErrorMessage(),ErrorMessage);
		}



	}
}
