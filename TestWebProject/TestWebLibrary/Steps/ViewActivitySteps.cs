using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.PageObjects;

namespace TestWebLibrary.Steps
{
	public class ViewActivitySteps:BaseStep
	{

	    public void GoToProjectsPage()
	    {

	        ProjectsPage = HomePage.ClickProjectLink();

	    }

        public void GoToActivityPage()
	    {
	        ActivityPage = ProjectsPage.ViewOverallactivity();
	    }


    }
}
