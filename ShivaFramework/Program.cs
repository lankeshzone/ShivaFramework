using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShivaFramework
{
    class BaseUtils
    {
        //use for scrolling the page when we have scroll bar, using the java script executor method
        public static void ScrollPageTo(int xPixel, int yPixel, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(" + xPixel + "," + yPixel + ")");
        }

        public static void PageUp(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,0);");
        }

        public static void PageDown(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000);");
        }

        // making your code sleep for a particular duration in seconds
        public static void WaitFor(double timeoutInSecond)
        {
            Thread.Sleep(TimeSpan.FromSeconds(timeoutInSecond));
        }

        //explicitly wait for a element to be displayed
        public static bool WaitForDisplayed(By locator, int timeoutInSecond, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSecond));
            try
            {
                wait.Until(d => d.FindElement(locator).Displayed);
                return true;
                //test 123
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

    class TestCase
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "https://www.deccanherald.com";

            BaseUtils.ScrollPageTo(0, 2000, driver);
         //   BaseUtils.WaitFor(5);

            BaseUtils.PageUp(driver);
           // BaseUtils.WaitFor(7);

            BaseUtils.PageDown(driver);
            By locator = By.LinkText("sadgadgdf");

            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(8));

            w.Until(driver2 => driver2.FindElement(By.XPath("//test")).Enabled);

           Console.WriteLine("Home link found: " + BaseUtils.WaitForDisplayed(locator, 10, driver));


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver web) =>
            {
                Console.WriteLine(web.FindElement(By.Id("target")).GetAttribute("innerHTML"));
                return true;
            });
            wait.Until(waitForElement);
            

        }

    }
}
