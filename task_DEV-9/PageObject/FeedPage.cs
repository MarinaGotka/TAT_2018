using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace task_DEV9
{
    public class FeedPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public FeedPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href = '/im']")]
        public IWebElement Dialogues { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = '_post_content']")]
        public IWebElement LastFeed { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href= '/albums157353430']")]
        public IWebElement Photos { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href= '/friends']")]
        public IWebElement Friends { get; set; }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://vk.com/feed");
        }
    }
}
