using Microsoft.VisualStudio.TestTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace AppliToolsProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Admin\source\repos\AppliToolsProject\AppliToolsProject\bin\Debug\net6.0\chromedriver");
            driver.Navigate().GoToUrl("https://ultimateqa.com/automation");
            driver.Quit();
        }
    }
}