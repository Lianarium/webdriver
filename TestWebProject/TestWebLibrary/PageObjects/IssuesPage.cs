using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestWebLibrary.PageObjects
{
	public class IssuesPage:BasePage
	{
	    private static readonly By issueslabel = By.XPath("//h2");

	    private readonly BaseElement newissuelink = new BaseElement(By.XPath("//*[@class='icon icon-add new-issue']"));

	    protected List SubjectColumn = new List();

	    private readonly BaseElement subjects = new BaseElement(By.XPath("//*[@class='subject']"));

        public IssuesPage() : base(issueslabel, "Issues")
	    {


	    }

	    public  NewIssuePage ClickToCreateNewIssuePage()
	    {
            this.newissuelink.Click();
            return new NewIssuePage();
	    }

	    
    }
}
