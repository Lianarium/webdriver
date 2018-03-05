using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestWebLibrary.Utils;

namespace TestWebLibrary.BrowserWork
{
    public class DriverFactory 
    {
        //private static IWebDriver driver;

	   // protected static string BrowserType = ConfigManager.ConfigBrowser;

        public static IWebDriver GetDriver(BrowserType type, int timeoutsec)
        {
            IWebDriver driver = null;
            switch (type)
            {
                case BrowserType.Chrome:
                {
                    var service = ChromeDriverService.CreateDefaultService();
                    var option = new ChromeOptions();
                    option.AddArgument("disable-infobars");
                    driver = new ChromeDriver(service);
                    break;

                }
                case  BrowserType.Firefox:
                {
                    var service = FirefoxDriverService.CreateDefaultService();
                    var option = new FirefoxOptions();
                    driver = new FirefoxDriver(service);
                    break;
                }

            }

            return driver;
        }
    }
}

     
