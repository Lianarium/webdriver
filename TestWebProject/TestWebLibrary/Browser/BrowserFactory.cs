using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestWebLibrary.Browser
{
    public class BrowserFactory//the newest one
    {
        private static IWebDriver driver;

        public enum BrowserType
        {
            Chrome,
            Firefox
        }

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
                    driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeoutsec));
                    break;

                }
                case BrowserType.Firefox:
                {
                    var service = FirefoxDriverService.CreateDefaultService();
                    var option = new FirefoxOptions();
                    driver = new FirefoxDriver(service, option, TimeSpan.FromSeconds(timeoutsec));
                    break;
                }

            }

            return driver;
        }
    }
}

     
