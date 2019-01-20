using GitHubAutomation.Steps;
using GitHubAutomation.Utils;
using GitHubAutomation.Pages;
using GitHubAutomation.Driver;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestGitHub
{
    [TestFixture]
    public class CreateNewFileInRepo
    {
        private Steps steps = new Steps();
        private const string USERNAME = "testautomationuser";
        private const string PASSWORD = "Time4Death!";
        private const int REPOSITORY_RANDOM_POSTFIX_LENGTH = 6;
        private const int NAME_LENGTH = 7;
        private const string DESCRIPTION = "demo";

        [SetUp]
        public void Start()
        {
            steps.InitBrowser();
            steps.LoginGithub(USERNAME, PASSWORD);
            steps.CreateNewRepository(RandomGenerator.GetRandomString(REPOSITORY_RANDOM_POSTFIX_LENGTH), DESCRIPTION);
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void CreateNewFile()
        {
            NewRepoPage newRepoPage = new NewRepoPage(DriverInstance.GetInstance());
            if (newRepoPage.CanCreateNewFile())
            {
                newRepoPage.CreateNewFile();
            }

            NewFile newFile = new NewFile(DriverInstance.GetInstance());
            newFile.SetName(RandomGenerator.GetRandomString(NAME_LENGTH));
            newFile.Commit(RandomGenerator.GetRandomString(NAME_LENGTH));
            if (newFile.CanCommit())
            {
                newFile.CommitNewFile();
            }

            Assert.False(newRepoPage.IsExistCreateNewFile());
        }
    }
}
