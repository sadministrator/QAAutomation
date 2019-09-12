using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Interactions;

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

                var state = WebDriver.FindElementById("RESULT_RadioButton-7");
                var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(state);
                selectElement.SelectByText("Texas");

                var zipCode = WebDriver.FindElementById("RESULT_TextField-8");
                zipCode.SendKeys("77777");

                var phone = WebDriver.FindElementById("RESULT_TextField-9");
                phone.SendKeys("5557771234");

                var email = WebDriver.FindElementById("RESULT_TextField-10");
                email.SendKeys("marco@marco.com");

                OpenQA.Selenium.Interactions.Actions actions = new Actions(WebDriver);
                actions.MoveToElement(email);
                actions.Perform();

                var membership = WebDriver.FindElementByXPath("//div[@id='q16']/table/tbody/tr/td/label");
                membership.Click();
                membership = WebDriver.FindElementByXPath("//div[@id='q16']/table/tbody/tr/td[1]/label");
                membership.Click();
                membership = WebDriver.FindElementByXPath("//div[@id='q16']/table/tbody/tr/td[2]/label");
                membership.Click();

                var contact = WebDriver.FindElementByXPath("//div[@id='q21']/table/tbody/tr/td/label");
                contact.Click();
                contact = WebDriver.FindElementByXPath("//div[@id='q21']/table/tbody/tr/td[2]/label");
                contact.Click();
                contact = WebDriver.FindElementByXPath("//div[@id='q21']/table/tbody/tr/td[3]/label");            //contact.Click();
                contact.Click();

                var terms = WebDriver.FindElementByXPath("//div[@id='q30']/table/tbody/tr/td/label");
                terms.Click();

                var submit = WebDriver.FindElementById("FSsubmit");
                submit.Submit();

                Thread.Sleep(5000);

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

                var state = WebDriver.FindElementById("RESULT_RadioButton-7");
                var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(state);
                selectElement.SelectByText("Texas");

                var zipCode = WebDriver.FindElementById("RESULT_TextField-8");
                zipCode.SendKeys("77777");

                var phone = WebDriver.FindElementById("RESULT_TextField-9");
                phone.SendKeys("5557771234");

                var email = WebDriver.FindElementById("RESULT_TextField-10");
                email.SendKeys("marco@marco.com");

                OpenQA.Selenium.Interactions.Actions actions = new Actions(WebDriver);
                actions.MoveToElement(email);
                actions.Perform();

                var membership = WebDriver.FindElementByXPath("//div[@id='q16']/table/tbody/tr/td/label");
                membership.Click();
                membership = WebDriver.FindElementByXPath("//div[@id='q16']/table/tbody/tr/td[1]/label");
                membership.Click();
                membership = WebDriver.FindElementByXPath("//div[@id='q16']/table/tbody/tr/td[2]/label");
                membership.Click();

                var contact = WebDriver.FindElementByXPath("//div[@id='q21']/table/tbody/tr/td/label");
                contact.Click();
                contact = WebDriver.FindElementByXPath("//div[@id='q21']/table/tbody/tr/td[2]/label");
                contact.Click();
                contact = WebDriver.FindElementByXPath("//div[@id='q21']/table/tbody/tr/td[3]/label");            //contact.Click();
                contact.Click();

                var terms = WebDriver.FindElementByXPath("//div[@id='q30']/table/tbody/tr/td/label");
                terms.Click();

                var submit = WebDriver.FindElementById("FSsubmit");
                submit.Submit();

                Thread.Sleep(5000);

                WebDriver.Close();
            }
        }
    }
}
