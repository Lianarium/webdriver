using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestWebLibrary.PageObjects
{
    public class ProjectsPage:BasePage
    {
        private static readonly By projectslabel = By.XPath("//h2");
	    private readonly BaseElement projectslabelElement = new BaseElement(By.XPath("//h2"));
		private readonly BaseElement newprojectelement = new BaseElement(By.XPath("//*[@class='icon icon-add']"));
        private readonly BaseElement viewallissueselement = new BaseElement(By.XPath("//*[@href='/issues']"));
        private readonly BaseElement overallactivityelement = new BaseElement(By.XPath("//*[@href='/activity']"));
        //private readonly BaseElement homepagetitleframe = new BaseElement(By.Id("content"));

        public ProjectsPage( ) : base(projectslabel, "Projects")
        {

        }


	    public string GetProjectsLabelText()
	    {
		    return projectslabelElement.GetText();
	    }

        public NewProjectPage ClickToCreateNewProject()
        {
            this.newprojectelement.Click();
            return new NewProjectPage();
        }

        public IssuesPage ClickToViewIssues()
        {
            this.viewallissueselement.Click();
            return new IssuesPage();

        }

        public ActivityPage ViewOverallactivity()
        {
            this.overallactivityelement.Click();
            return new ActivityPage();
        }

        
    }
}
