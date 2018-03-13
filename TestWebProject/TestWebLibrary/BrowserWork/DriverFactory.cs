using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
          

        public static IWebDriver GetDriver(string type, int timeoutsec)
        {
            IWebDriver driver = null;
            switch (type)
            {
                case "Chrome":
                {
                    var service = ChromeDriverService.CreateDefaultService();
                    var option = new ChromeOptions();
                    option.AddArgument("disable-infobars");
                    driver = new ChromeDriver(service);
                    break;

                }
                case "Firefox":
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

     
