using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWebLibrary.PageObjects;

namespace TestWebLibrary.BrowserWork
{
	public interface IBrowser
	{

		void InitParameters();

		IWebDriver GetDriver();

	    //Browser GetBrowser();

		void WindowMaximize();

		void NavigateTo(string url);

		void Quit();

	}
}
