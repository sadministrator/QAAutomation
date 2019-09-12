using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace QA_hw2
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver WebDriver;
        public static string baseURL = "https://fs19.formsite.com/vTUJhX/upkauxsphd/index.html";

        [TestMethod]
        public void FirefoxTest()
        {
            using (var WebDriver = new FirefoxDriver())
            {
                WebDriver.Manage().Window.Maximize();

                WebDriver.Navigate().GoToUrl(baseURL);

                var firstName = WebDriver.FindElementById("RESULT_TextField-2");

                firstName.SendKeys("Marco");

                var lastName = WebDriver.FindElementById("RESULT_TextField-3");

                lastName.SendKeys("Serrano");

                var address = WebDriver.FindElementById("RESULT_TextField-4");

                address.SendKeys("123 Street St.");

                var address2 = WebDriver.FindElementById("RESULT_TextField-5");

                address2.SendKeys("Apt 123");

                var city = WebDriver.FindElementById("RESULT_TextField-6");

                city.SendKeys("Townsville");

                // State/Province
                var state = WebDriver.FindElementById("RESULT_RadioButton-7");

                // do

                var zipCode = WebDriver.FindElementById("RESULT_TextField-8");

                zipCode.SendKeys("77777");

                var phone = WebDriver.FindElementById("RESULT_TextField-9");

                phone.SendKeys("5557771234");

                var email = WebDriver.FindElementById("RESULT_TextField-10");

                email.SendKeys("marco@marco.com");

                var search = WebDriver.FindElementById("FSsubmit");

                search.Submit();

                //WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                
               // var searchResults = WebDriver.FindElementById("resultStats");

                WebDriver.Close();
            }
        }

        [TestMethod]
        public void ChromeTest()
        {
            using (var WebDriver = new ChromeDriver())
            {
                WebDriver.Manage().Window.Maximize();

                WebDriver.Navigate().GoToUrl(baseURL);

                var firstName = WebDriver.FindElementById("RESULT_TextField-2");

                firstName.SendKeys("Marco");

                var lastName = WebDriver.FindElementById("RESULT_TextField-3");

                lastName.SendKeys("Serrano");

                var address = WebDriver.FindElementById("RESULT_TextField-4");

                address.SendKeys("123 Street St.");

                var address2 = WebDriver.FindElementById("RESULT_TextField-5");

                address2.SendKeys("Apt 123");

                var city = WebDriver.FindElementById("RESULT_TextField-6");

                city.SendKeys("Townsville");

                // State/Province
                var state = WebDriver.FindElementById("RESULT_RadioButton-7");

                // do

                var zipCode = WebDriver.FindElementById("RESULT_TextField-8");

                zipCode.SendKeys("77777");

                var phone = WebDriver.FindElementById("RESULT_TextField-9");

                phone.SendKeys("5557771234");

                var email = WebDriver.FindElementById("RESULT_TextField-10");

                email.SendKeys("marco@marco.com");

                var search = WebDriver.FindElementById("FSsubmit");

                search.Submit();

                //WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                // var searchResults = WebDriver.FindElementById("resultStats");

                WebDriver.Close();
            }
        }
    }
}
