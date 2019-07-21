using OpenQA.Selenium;
using System;

namespace github_test_automation_framework.Driver
{
    class WebDriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("You need to initialize driver");
                }
                return driver;
            }

            private set
            {
                driver = value;
            }
        }
    }
}
