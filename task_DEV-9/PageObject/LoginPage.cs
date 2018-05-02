using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace task_DEV9
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id = 'index_email']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id = 'index_pass']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class = 'index_login_button flat_button button_big_text']")]
        public IWebElement Login { get; set; }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.vk.com");
        }
    }
}
