using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using task_DEV10.PageObject;

namespace task_DEV10
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://av.by");

                MainPage mainPage = new MainPage(driver);
                mainPage.SelectBrand("Jaguar");
                mainPage.NavigateTo();

                ResultPage resultPage = new ResultPage(driver);
                resultPage.CalculateNumberOfEachModels();
                resultPage.SortListCars();
                resultPage.PrintListCars();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
