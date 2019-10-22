using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShivaFramework.ObjectRepository
{
    class TestCaseOne
    {
        public static void Main(String[] args)
        {

            IWebDriver driver = new FirefoxDriver();

            driver.Url = "https://www.linkedin.com/";

            HomePageRepository hpo = new HomePageRepository();

            //IWebElement jn, sn, sj;

        //    hpo.joinNow_Button(driver, "nav__button-tertiary");

          //  hpo.joinNow_click();

            hpo.userAgreement_Liknk(driver); //identify the element
            hpo.useragreement_click(); //perform the action

         /*   driver.Url = "https://www.linkedin.com/";

            hpo.signIN_Button(driver, "nav__button-secondary");
            hpo.signIN_click();


            driver.Url = "https://www.linkedin.com/";

           // sj = hpo.searchJobs_Button(driver, "search__button");
           // sj.Click();
            //driver.Url = "https://www.linkedin.com/";


            // on which browser you are trying to identify element
            // locator type and its value
            // return type should be element

            driver.Url = "https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin";

            SignInPageObject spo = new SignInPageObject();
            PageFactory.InitElements(driver, spo);
            spo.username.SendKeys("Lankesh");

            spo.password.SendKeys("lankesh");

            spo.signIn.Click();*/
           

        }
    }

    class screenshotEx
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.google.co.in";

           ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("D://Test//sampleOne.Jpg",ScreenshotImageFormat.Jpeg);

        }
    }

    class switchEx
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();
           /* driver.Url = "http://demo.automationtesting.in/Alerts.html";
            driver.FindElement(By.XPath("//button[@class='btn btn-danger']")).Click();

            IAlert a = driver.SwitchTo().Alert();

            Console.WriteLine(a.Text);
            a.Accept();


            driver.FindElement(By.XPath("//a[contains(text(),'Alert with Textbox')]")).Click();

            driver.FindElement(By.XPath("//button[@class='btn btn-info']")).Click();

            IAlert a2 = driver.SwitchTo().Alert();
            a2.SendKeys("Lankesh");
            a2.Dismiss();*/


            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Windows.html");

         //   driver.FindElement(By.XPath("//div[@id='Tabbed']//button[@class='btn btn-info'][contains(text(),'click')]")).Click();

           // Console.WriteLine(driver.Title);

           /* WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(d => d.FindElement(By.XPath("skjdflksdj")).Selected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            String str = driver.CurrentWindowHandle;
 */
      //      driver.SwitchTo().Window(str);

            Console.WriteLine(driver.Title);

            Stopwatch sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < 1000)
            {
                try
                {
                  //  driver.FindElement(By.ClassName("btn-info")).Click();
                    Console.WriteLine(" time stamp " + Stopwatch.GetTimestamp());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            sw.Reset();
            sw.Start();
            Console.WriteLine(sw.ElapsedTicks);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            driver.Url = "http://demo.automationtesting.in/Windows.html";
            Console.WriteLine(sw.ElapsedTicks);

            
        }



        public IWebDriver setBrowser(String browser, String url)
        {
            IWebDriver driver;

            switch (browser)
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Url = url;
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    driver.Url = url;
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Url = url;
                    break;
                case "Opera":
                    driver = new OperaDriver();
                    driver.Url = url;
                    break;
                default:
                    Console.WriteLine("Browser not assigned ");
                    driver = null;
                    break;
            }


            return driver;

        }

        public void closeBrowser(IWebDriver driver)
        {
            driver.Close();
        }

        public void quitBrowser(IWebDriver driver)
        {
            driver.Quit();
        }

        public String getDriverinfo(String str, IWebDriver driver)
        {
            String value = null;
            if (str.Equals("url"))
                value = driver.Url;
            if (str.Equals("title"))
                value = driver.Title;
            if (str.Equals("windowhandle"))
                value = driver.CurrentWindowHandle;

            
            return value;

        }

        public IWebElement getElement(String LocatorType, String LocatorValue, IWebDriver driver)
        {
            IWebElement element = null;
            switch (LocatorType)
            {
                case "id":
                    element = driver.FindElement(By.Id(LocatorValue));
                    break;
                case "name":
                    element = driver.FindElement(By.Name(LocatorValue));
                    break;
                case "class":
                    element = driver.FindElement(By.ClassName(LocatorValue));
                    break;
                case "link":
                    element = driver.FindElement(By.LinkText(LocatorValue));
                    break;
                case "partial":
                    element = driver.FindElement(By.PartialLinkText(LocatorValue));
                    break;
                case "tag":
                    element = driver.FindElement(By.TagName(LocatorValue));
                    break;
                case "css":
                    element = driver.FindElement(By.CssSelector(LocatorValue));
                    break;
                case "xpath":
                    element = driver.FindElement(By.XPath(LocatorValue));
                    break;
                default:
                    throw new Exception("Element locator type doesn't match");
                    
            }
        return element;
            
        }

        public void windowOperation(String operate, IWebDriver driver)
        {
            switch(operate)
            {
               case "back":
                driver.Navigate().Back();
                break;
                case "forward":
                    driver.Navigate().Forward();
                    break;
                case "refresh":
                    driver.Navigate().Refresh();
                    break;
                default:
                    driver.Navigate().Refresh();
                    break;
            }
        }
        
    }

}
