using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace task_DEV10.PageObject
{
    /// <summary>
    ///  This class is search results page. It contains methods for working with elements of this page.
    /// </summary>
    public class ResultPage
    {
        private IWebDriver driver { get; set; }
        private WebDriverWait wait;
        public List<string> allModels= new List<string>();
        public List<Car> cars = new List<Car>();
        
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = Locator.nextPageLocator)]
        public IWebElement NextPage { get; set; }

        /// <summary>
        ///  This method calculate the count of car of each model and fill list of car with non-recurring models.
        /// </summary>
        public void CalculateNumberOfEachModels()
        {
            for(int j = 0; j < GetCountOfPages(); j++)
            {
                var elements = driver.FindElements(By.XPath(Locator.elementsLocator));
                foreach (IWebElement el in elements)
                {
                    allModels.Add(el.Text);
                }
                if(j == GetCountOfPages() - 1 )
                {
                    break;
                }
                NavigateTo();       
            }

            foreach(string m in allModels)
            {
                bool flag = false;
                foreach(Car c in cars)
                {
                    if(c.Model == m)
                    {
                        c.CountCars++;
                        flag = true;
                    }
                }
                if (flag)
                {
                    continue;
                }
                cars.Add(new Car(m, 1));
            }
        }

        /// <summary>
        ///  This method for sorting list of car for loss of quantity of model.
        /// </summary>
        public void SortListCars()
        {
            CarComparer carComparer = new CarComparer();
            cars.Sort(carComparer);
        }

        /// <summary>
        ///  This method for displaying car
        /// </summary>
        public void PrintListCars()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c.CountCars + "-----" + c.Model);
            }
        }

        /// <summary>
        ///  This method calculate the count of pages of list available cars
        /// </summary>
        public int GetCountOfPages()
        {
            var el = driver.FindElements(By.XPath(Locator.numberPageLocator));
            return el.Count;
        }

        /// <summary>
        ///  This method to go to next page of list available cars
        /// </summary>
        public void NavigateTo()
        {
            NextPage.Click();
        }
    }
}
