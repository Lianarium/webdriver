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
	public class CreateNewProjectSteps:BaseStep
	{
		 
		public void GoToProjectsPage()
		{

			ProjectsPage = HomePage.ClickProjectLink();

		}

		public void CreateNewProject(Project project)
		{
			NewProjectPage = ProjectsPage.ClickToCreateNewProject().EnterProjectName(project.Name).CreateProjectAndContinue();
		}


	}
}
