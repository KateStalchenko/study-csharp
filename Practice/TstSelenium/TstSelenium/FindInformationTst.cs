using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TstSelenium
{
    [TestFixture]
    class FindInformationTst
    {
         IWebDriver driver;

        [Test]
        public void search()
        {
            driver = new ChromeDriver("E:\\Apps\\chromedriver");
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchForm = driver.FindElement(By.XPath("//div[@id='searchform']//input[contains(@class, 'gLFyf gsfi')]"));
            searchForm.SendKeys("EPAM history");
            searchForm.SendKeys(Keys.Enter);
            IWebElement firstResult = driver.FindElement(By.XPath("//div[@class='r']//a[@href ='https://www.epam.com/about/who-we-are/history']"));
            firstResult.Click();
            StringAssert.Contains("Evolution & Transformation Since 1993 | EPAM History", driver.Title);
            driver.Quit();

        }
    }
}
