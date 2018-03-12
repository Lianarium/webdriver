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

		public NewProjectPage CreateNewProject(Project project)
		{
			NewProjectPage = ProjectsPage.ClickToCreateNewProject().EnterProjectName(project.Name).CreateProjectAndContinue();
			return NewProjectPage;
		}
 

		public NewProjectPage GetExpectedNewProjectPage()
		{
			NewProjectPage newprojpage = new NewProjectPage();
			return newprojpage;
		}

	}
}
