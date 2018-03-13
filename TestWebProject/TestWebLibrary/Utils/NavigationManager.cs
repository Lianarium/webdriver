using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.PageObjects;
using TestWebProject;

namespace TestWebLibrary.Utils
{
	public class NavigationManager//static
	{

	    protected LogInPage LoginPage = new LogInPage();
	    protected HomePage HomePage = new HomePage();
	    protected ProjectsPage ProjectsPage = new ProjectsPage();
	    protected NewProjectPage NewProjectPage = new NewProjectPage();
	    protected IssuesPage IssuesPage = new IssuesPage();
	    protected NewIssuePage NewIssuePage = new NewIssuePage();
	    protected ActivityPage ActivityPage = new ActivityPage();

        public NavigationManager()
	    {
            
	    }

	    public ProjectsPage GoToProjectsPage( )  
	    {
          //check if we are on the proper page
	        return HomePage.ClickProjectLink();
	    }

	    public IssuesPage GoToIssuesPage()
	    {
	        return ProjectsPage.ClickToViewIssues();
	    }

	    public ActivityPage GoToActivityPage()
	    {
	        return ProjectsPage.ViewOverallactivity();
	    }

    }
}
