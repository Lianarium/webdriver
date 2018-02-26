using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestWebLibrary.PageObjects
{
	public class IssuesPage:BasePage
	{
	    private static readonly By issueslabel = By.XPath("//h2");

	    private readonly BaseElement newissuelink = new BaseElement(By.XPath("//*[@class='icon icon-add new-issue']"));

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
