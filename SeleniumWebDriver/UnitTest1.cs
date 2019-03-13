using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    public class UITests
    {
        [Test]
        public void TestWebDriverMethods()
        {
            IWebDriver driver = new ChromeDriver();
        }
    }
}
