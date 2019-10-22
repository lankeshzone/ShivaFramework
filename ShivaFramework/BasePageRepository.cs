using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaFramework
{
    class BasePageRepository
    {
        IWebElement userageement, privacy;

        public void userAgreement_Liknk(IWebDriver driver)
        {
            By uaLocator = By.ClassName("li-footer__item-link");
            userageement = driver.FindElement(uaLocator);
        }

        public void useragreement_click()
        {
            userageement.Click();
        }
    }
}
