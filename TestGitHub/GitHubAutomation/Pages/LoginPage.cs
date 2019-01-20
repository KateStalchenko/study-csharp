using OpenQA.Selenium;
using System;

namespace GitHubAutomation.Pages
{
    public class LoginPage
    {
        private const string BASE_URL = "https://github.com/login";
        
        private By inputLogin = By.Id("login_field");
        
        private By inputPassword = By.Id("password");
        
        private By buttonSubmit = By.XPath("//input[@value='Sign in']");
        
        private By linkLoggedInUser = By.XPath("//meta[@name='user-login']");

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Login Page opened");
        }

        public void Login(string username, string password)
        {
            driver.FindElement(inputLogin).SendKeys(username);
            driver.FindElement(inputPassword).SendKeys(password);
            driver.FindElement(buttonSubmit).Click();
        }

        public string GetLoggedInUserName()
        {
            return driver.FindElement(linkLoggedInUser).GetAttribute("content");
        }
    }
}
