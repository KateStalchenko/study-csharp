using OpenQA.Selenium;

namespace GitHubAutomation.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "http://www.github.com/";
        
        private By buttonCreateNew = By.XPath("//summary[@aria-label='Create new…']");
        
        private By linkNewRepository = By.XPath("//a[contains(text(), 'New repository')]");

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickOnCreateNewRepositoryButton()
        {
            driver.FindElement(buttonCreateNew).Click();
            driver.FindElement(linkNewRepository).Click();
        }

    }
}
