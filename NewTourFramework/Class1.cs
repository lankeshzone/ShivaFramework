using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTourFramework
{
    [TestFixture]
    class RegistrationModuleTestSuite
    {
        static HomePageObject hpo;
        static RegistePageObject rpo;
        static IWebDriver driver;

        [SetUp]
        public void setupTest()
        {
            driver = new FirefoxDriver();
            hpo = new HomePageObject(driver);
            rpo = new RegistePageObject(driver);

            driver.Url = "http://newtours.demoaut.com/mercurywelcome.php";

            String ExpectedTitle = "Welcome: Mercury Tours";
            String ActualTitle = driver.Title;

            Assert.AreEqual(ExpectedTitle, ActualTitle);

            hpo.register_Click("REGISTER");

            register_User();
        }

        [Test]
        public static void register_User()
        {
            String ExpectedTitle = "Register: Mercury Tours";
            String ActualTitle = driver.Title;

            Assert.AreEqual(ExpectedTitle, ActualTitle);

            rpo.fname_enterText("firstName", "Shiva");
            rpo.lname_enterText("lastName", "Shankar");
            rpo.phone_enterText("phone", "9999999999");
            rpo.email_enterText("userName", "shivashankar123@test.com");

            rpo.address1_enterText("address1", "block-3");
            rpo.address2_enterText("address2", "Malleswaram");
            rpo.city_enterText("city", "Bangalore");
            rpo.state_enterText("state", "Karnataka");
            rpo.phone_enterText("postalCode", "560001");

            rpo.username_enterText("email", "Shiva123");
            rpo.password_enterText("password", "Shiva1234");
            rpo.confirmpassword_enterText("confirmPassword", "Shiva1234");

            rpo.submit_click("register");
        }

        [Test]
        [Ignore("This is omitted from Execution")]
        public void testTwo()
        {
            Console.WriteLine("Hello Iam test Two");
        }

        [Test]
        public void testThree()
        {
            Console.WriteLine("Hello Iam test Three");

        }

        [Test]
        public void testFour()
        {
            Console.WriteLine("Hello Iam test Four");

        }

        [TearDown]
        public void exitCode()
        {
            //driver.Quit();
        }

    }

    [TestFixture]
    [Ignore("Iam ignoring signoff")]
    class signOff
    {

        static IWebDriver driver;
        [SetUp]
        public void signoffSetup()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://newtours.demoaut.com/mercurywelcome.php";

            driver.FindElement(By.LinkText("SIGN-ON")).Click();

        }

        [Test]
        public void loginTest()
        {
            driver.FindElement(By.Name("userName")).SendKeys("Shiva123");
            driver.FindElement(By.Name("password")).SendKeys("Shiva1234");
            driver.FindElement(By.Name("login")).Click();
        }

    }
}
