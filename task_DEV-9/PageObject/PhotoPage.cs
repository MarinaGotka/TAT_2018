using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace task_DEV_9.PageObject
{
    class PhotoPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public PhotoPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://vk.com/albums157353430");
        }
    }
}
