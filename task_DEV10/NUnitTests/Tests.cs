using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using task_DEV10;
using task_DEV10.PageObject;

namespace NUnitTests
{
    [TestFixture]
    class Tests
    {
        IWebDriver driver = new ChromeDriver();
        private WebDriverWait wait;

        [SetUp]
        public void Init()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://av.by");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void SelectBrandTestsValidBrand()
        {
            string brand = "Lincoln";
           
            MainPage mainPage = new MainPage(driver);
            mainPage.SelectBrand(brand);
            mainPage.NavigateTo();
            IWebElement expected = driver.FindElement(By.XPath("//div[@class = 'chosen-container chosen-container-single chosen-container-single-nosearch']/a[@class = 'chosen-single']"));

            Assert.AreEqual(brand,expected.Text);
        }

        [Test]
        public void SelectBrandTestsWrongBrand()
        {
            string brand = "Kkjj";
            MainPage mainPage = new MainPage(driver);

            Assert.Throws<Exception>(() => mainPage.SelectBrand(brand));
        }

        [Test]
        public void CalculateNumberOfEachModels()
        {
            MainPage mainPage = new MainPage(driver);
            string brand = "Acura";
            string model = "RL";
            mainPage.SelectBrand(brand);
            IWebElement selectModel = driver.FindElement(By.XPath("//select[@name = 'model_id[]']"));
            selectModel.SendKeys(model);
            var expextedList = driver.FindElements(By.XPath(Locator.elementsLocator));

            ResultPage resultPage = new ResultPage(driver);
            resultPage.CalculateNumberOfEachModels();
            foreach(Car c in resultPage.cars)
            {
                if(c.Model == model)
                {
                    Assert.AreEqual(expextedList.Count, c.CountCars);
                }
            }
        }
    }
}
