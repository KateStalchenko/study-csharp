using OpenQA.Selenium;

namespace GitHubAutomation.Pages
{
    public class CreateNewRepositoryPage
    {
        private const string BASE_URL = "http://www.github.com/new";
        private IWebDriver driver;

        private By inputRepositoryName = By.Id("repository_name");

        private By inputRepositoryDescription = By.Id("repository_description");

        private By butttonCreate = By.XPath("//form[@id='new_repository']//button[@type='submit']");

        private By labelEmptyRepoRecommendations = By.ClassName("//h3/strong[text()='Quick setup']");
        
        private By linkCurrentRepository = By.XPath("//a[@data-pjax='#js-repo-pjax-container']");


        public CreateNewRepositoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void CreateNewRepository(string repositoryName, string repositoryDescription)
        {
            driver.FindElement(inputRepositoryName).SendKeys(repositoryName);
            driver.FindElement(inputRepositoryDescription).SendKeys(repositoryDescription);
            driver.FindElement(butttonCreate).Click();
        }

        public bool IsCurrentRepositoryEmpty()
        {
            return driver.FindElement(labelEmptyRepoRecommendations).Displayed;
        }

        public string GetCurrentRepositoryName()
        {
            return driver.FindElement(linkCurrentRepository).Text;
        }

    }
}
