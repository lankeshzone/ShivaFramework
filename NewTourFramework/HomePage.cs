using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTourFramework
{
    class HomePageObject
    {
        static IWebElement register;
        static IWebDriver driver;

        public void register_link(String locatorvalue)
        {
            register = driver.FindElement(By.LinkText(locatorvalue));
        }

        public void register_Click(String locatorValue)
        {
            register_link(locatorValue);
            Assert.True(register.Enabled);
            register.Click();
        }

        public HomePageObject(IWebDriver d)
        {
            driver = d;
        }

    }

    class RegistePageObject
    {
        static IWebDriver driver;
        static IWebElement fname, lname, phone, email;

        static IWebElement address1, address2, city, state, postal, country;

        static IWebElement username, password, confirmpassword, submit;

        public RegistePageObject(IWebDriver d)
        {
            driver = d;
        }

        public void fnameIdentify(String locatorValue)
        {
            fname = driver.FindElement(By.Name(locatorValue));
        }

        public void lnameIdentify(String locatorValue)
        {
            lname = driver.FindElement(By.Name(locatorValue));
        }

        public void phoneIdentify(String locatorValue)
        {
            phone = driver.FindElement(By.Name(locatorValue));
        }

        public void emailIdentify(String locatorValue)
        {
            email = driver.FindElement(By.Id(locatorValue));
        }



        public void fname_enterText(String locatorValue, String str)
        {
            fnameIdentify(locatorValue);
            Assert.True(fname.Enabled);
            fname.SendKeys(str);
        }

        public void lname_enterText(String locatorValue, String str)
        {
            lnameIdentify(locatorValue);
            Assert.True(lname.Enabled);
            lname.SendKeys(str);
        }

        public void phone_enterText(String locatorValue, String str)
        {
            phoneIdentify(locatorValue);
            Assert.True(phone.Enabled);
            phone.SendKeys(str);
        }

        public void email_enterText(String locatorValue, String str)
        {
            emailIdentify(locatorValue);
            Assert.True(email.Enabled);
            email.SendKeys(str);
        }



        public void address1Identify(String locatorValue)
        {
            address1 = driver.FindElement(By.Name(locatorValue));
        }

        public void address2Identify(String locatorValue)
        {
            address2 = driver.FindElement(By.Name(locatorValue));
        }


        public void cityIdentify(String locatorValue)
        {
            city = driver.FindElement(By.Name(locatorValue));
        }


        public void stateIdentify(String locatorValue)
        {
            state = driver.FindElement(By.Name(locatorValue));
        }

        public void postalIdentify(String locatorValue)
        {
            postal = driver.FindElement(By.Name(locatorValue));
        }


        public void countryIdentify(String locatorValue)
        {
            country = driver.FindElement(By.Name(locatorValue));
        }

        public void address1_enterText(String locatorValue, String str)
        {
            address1Identify(locatorValue);
            Assert.True(address1.Enabled);
            address1.SendKeys(str);
        }

        public void address2_enterText(String locatorValue, String str)
        {
            address2Identify(locatorValue);
            Assert.True(address2.Enabled);
            address2.SendKeys(str);
        }


        public void city_enterText(String locatorValue, String str)
        {
            cityIdentify(locatorValue);
            Assert.True(city.Enabled);
            city.SendKeys(str);
        }
        public void state_enterText(String locatorValue, String str)
        {
            stateIdentify(locatorValue);
            Assert.True(state.Enabled);
            state.SendKeys(str);
        }

        public void postal_enterText(String locatorValue, String str)
        {
            postalIdentify(locatorValue);
            Assert.True(postal.Enabled);
            postal.SendKeys(str);
        }

        public void usernameIdentify(String locatorValue)
        {
            username = driver.FindElement(By.Id(locatorValue));
        }

        public void passwordIdentify(String locatorValue)
        {
            password = driver.FindElement(By.Name(locatorValue));
        }

        public void confirmpasswordIdentify(String locatorValue)
        {
            confirmpassword = driver.FindElement(By.Name(locatorValue));
        }


        public void username_enterText(String locatorValue, String str)
        {
            usernameIdentify(locatorValue);
            Assert.True(username.Enabled);
            username.SendKeys(str);
        }

        public void password_enterText(String locatorValue, String str)
        {
            passwordIdentify(locatorValue);
            Assert.True(password.Enabled);
            password.SendKeys(str);
        }

        public void confirmpassword_enterText(String locatorValue, String str)
        {
            confirmpasswordIdentify(locatorValue);
            confirmpassword.SendKeys(str);
        }

        public void submitIdentify(String locatorValue)
        {
            submit = driver.FindElement(By.Name(locatorValue));
        }

        public void submit_click(String locatorValue)
        {
            submitIdentify(locatorValue);
            Assert.True(submit.Enabled);
            submit.Click();
        }

    }


}
