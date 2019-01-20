using OpenQA.Selenium;

namespace GitHubAutomation.Pages
{
    public class NewRepoPage
    {
        private IWebDriver driver;

        public NewRepoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By creatingNewFile = By.XPath("//div[@class = 'application-main ']//a[text() ='creating a new file']");


        public bool CanCreateNewFile()
        {
            return driver.FindElement(creatingNewFile).Displayed;
        }

        public void CreateNewFile()
        {
            driver.FindElement(creatingNewFile).Click();
        }

        public bool IsExistCreateNewFile()
        {
            return driver.FindElements(creatingNewFile).Count > 0;
        }

    }
}
