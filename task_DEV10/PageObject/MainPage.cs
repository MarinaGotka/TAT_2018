using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace task_DEV10.PageObject
{
    /// <summary>
    ///  This class is main page. It contains methods for working with elements of this page.
    /// </summary>
    public class MainPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        List<string> brands = new List<string>();

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locator.brandLocator)]
        public IWebElement Brand { get; set; }

        [FindsBy(How = How.XPath, Using = Locator.showAllLocator)]
        public IWebElement ShowAll { get; set; }

        [FindsBy(How = How.XPath, Using = Locator.submitLocator)]
        public IWebElement Submit { get; set; }

        /// <summary>
        ///  This method for filling brand field.
        /// </summary>
        public void SelectBrand (string brand)
        {
            ShowAll.Click();
            var brandsList = driver.FindElements(By.XPath(Locator.brandListLocator));
            for (int i = 0; i < brandsList.Count; i++)
            {
                brands.Add(brandsList[i].Text);
            }
            if (!brands.Contains(brand))
            {
                throw new Exception("Error! Brands is not found.");
            }
            Brand.SendKeys(brand);
        }

        /// <summary>
        ///  This method to go to search.
        /// </summary>
        public void NavigateTo()
        {
            Submit.Click();
        }
    }
}
