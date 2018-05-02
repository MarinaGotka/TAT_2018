using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace task_DEV_9.PageObject
{
    class FriendsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public FriendsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'friends_list']")]
        public IWebElement FriendsList { get; set; }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://vk.com/friends");
        }
    }
}
