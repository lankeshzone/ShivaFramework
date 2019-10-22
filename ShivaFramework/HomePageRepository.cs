using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaFramework.ObjectRepository
{
    class HomePageRepository : BasePageRepository
    {
        static IWebDriver driver;
        
        //Actions object to perform complex user gestures
       

        //Identify WebElements JoinNOw, SignIN, SearchJobs

        IWebElement JoinNow , signIN, SearchJobs;

      
        public IWebElement joinNow_Button(IWebDriver driver, String locatorvalue)
        {
            By JoinNowLocator = By.ClassName(locatorvalue);

            JoinNow = driver.FindElement(JoinNowLocator);

            return JoinNow;
        }

        public IWebElement signIN_Button(IWebDriver driver, String locatorvalue)
        {
            By signINLocator = By.ClassName(locatorvalue);

            signIN = driver.FindElement(signINLocator);

            return signIN;
        }

        public IWebElement searchJobs_Button(IWebDriver driver, String locatorvalue)
        {
            By searchJobsLocator = By.ClassName(locatorvalue);

            SearchJobs = driver.FindElement(searchJobsLocator);

            return SearchJobs;
        }

        //Actions associated to the different controls
        // userID.clck();...

        public void joinNow_click()
        {
            JoinNow.Click();
        }

        public void joinNow_Mousehover(IWebDriver driver)
        {
            Actions act = new Actions(driver);
            act.Build();
            act.MoveToElement(JoinNow).Perform();
        }

        public void signIN_click()
        {
            signIN.Click();
        }

        public void signIN_mousehover(IWebDriver driver)
        {
            Actions act = new Actions(driver);
            act.Build();
            act.MoveToElement(signIN).Perform();
        }

    }
}
