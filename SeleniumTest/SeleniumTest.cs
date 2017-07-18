using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class SeleniumTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http:www.wykop.pl");
            IWebElement search = driver.FindElement(By.Name("nsQ"));
        }
    }
}
