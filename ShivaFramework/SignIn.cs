using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ShivaFramework
{
    class SignInPageObject
    {
        [FindsBy(How=How.Id, Using="username")]
        public IWebElement username;


        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "btn__primary--large")]
        public IWebElement signIn;


    }
}
