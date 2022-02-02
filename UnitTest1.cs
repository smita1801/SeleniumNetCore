using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumNetCore
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            IWebDriver Driver = new ChromeDriver(@"C:\driver\");
            
            Driver.Navigate().GoToUrl("https://google.com");
            string title = Driver.Title;
            Console.WriteLine("Executing test");
            Assert.IsTrue(title == "Google");
            Driver.Close();
            Driver.Quit();
        }
    }
}