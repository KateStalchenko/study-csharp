using OpenQA.Selenium;

namespace GitHubAutomation.Pages
{
    public class NewFile
    {
        IWebDriver driver;

        public NewFile(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By fileName = By.XPath("//input[@class='form-control js-blob-filename js-breadcrumb-nav']");
        private By commitText = By.Id("commit-summary-input");
        private By commitButton = By.Id("submit-file");

        public void SetName(string fileName)
        {
            driver.FindElement(this.fileName).SendKeys(fileName);
        }

        public void Commit(string commit)
        {
            driver.FindElement(this.commitText).SendKeys(commit);
        }

        public bool CanCommit()
        {
            return driver.FindElement(commitButton).Enabled;
        }

        public void CommitNewFile()
        {
            driver.FindElement(commitButton).Click();
        }
    }
}
