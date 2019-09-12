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
        public static string baseURL = "http://www.google.com.mx/";

        [TestMethod]
        public void FirefoxTest()
        {
            using (var WebDriver = new FirefoxDriver())
            {
                WebDriver.Manage().Window.Maximize();

                WebDriver.Navigate().GoToUrl(baseURL);

                var searchBox = WebDriver.FindElementByName("q");

                searchBox.SendKeys("automation using selenium 3.0 in C#");

                searchBox.Submit();

                WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                
                var searchResults = WebDriver.FindElementById("resultStats");

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

                var searchBox = WebDriver.FindElementByName("q");

                searchBox.SendKeys("Automation using selenium 3.0 in C#");

                searchBox.Submit();

                var searchResults = WebDriver.FindElementById("resultStats");

                WebDriver.Close();
            }
        }
    }
}
