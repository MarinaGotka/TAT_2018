using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace task_DEV9
{
    public class DialoguesPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public DialoguesPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'nim-dialog--cw']")]
        public IWebElement LastMessage { get; set; }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://vk.com/im");
        }
    }
}
