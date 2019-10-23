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

    class RegistrationModuleTestCases
    {
        static HomePageObject hpo;
        static RegistePageObject rpo;
        static IWebDriver driver;

       
        public static void Main(String[] args)
        {
            driver = new FirefoxDriver();
            hpo = new HomePageObject(driver);
            rpo = new RegistePageObject(driver);

            driver.Url = "http://newtours.demoaut.com/mercurywelcome.php";

            hpo.register_Click("REGISTER");

            register_User();
        }

       
        public static void register_User()
        {
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


    }
}
